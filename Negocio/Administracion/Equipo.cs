using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Administracion
{
    public class Equipo
    {

        public Dtos.Basico.Lista_View_Equipo getEquipos(string FiltroTexto, bool? Activo)
        {
            Dtos.Basico.Lista_View_Equipo respuesta = new Dtos.Basico.Lista_View_Equipo();
            respuesta.Items = new List<Dtos.Basico.View_Equipo>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_Equipo();
                using (var context = new Datos.LabManagerEntities())
                {
                    var tmp = context.Equipos(FiltroTexto, Activo);
                    var lista = tmp.ToList();
                    foreach (var item in lista)
                    {
                        var r = mapper.Mapper(item);
                        respuesta.Items.Add(r);
                    }
                    respuesta.Error = false;
                    respuesta.Mensaje = "";
                }
            }
            catch (Exception ex)
            {
                respuesta.Error = true;
                respuesta.Mensaje = ex.Message;
            }
            return respuesta;
        }

        public Dtos.DtoBase AddEquipo(Dtos.Basico.View_Equipo newEquipo)
        {
            ValidaEquipo(newEquipo, true);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var ne = new Datos.Equipo {
                        Activo=newEquipo.Activo,
                        CodigoInventario=newEquipo.CodigoInventario,
                        CodigoLaboratorio=newEquipo.CodigoLaboratorio,
                        CreadoId=newEquipo.CreadoId,
                        FechaCreacion = DateTime.Now,
                        Serial=newEquipo.Serial,
                        TipoEquipoId=newEquipo.TipoEquipoId,
                        ResponsableId = newEquipo.UsuarioInventarioResponsableId,
                        FechaCompra = newEquipo.FechaCompra
                    };
                    contex.Equipoes.Add(ne);
                    contex.SaveChanges();
                }
                return new Dtos.DtoBase
                {
                    Error = false,
                    Mensaje = ""
                };
            }
            catch (Exception ex)
            {
                return new Dtos.DtoBase
                {
                    Error = true,
                    Mensaje = ex.Message
                };
            }
        }

        public Dtos.DtoBase EditEquipo(Dtos.Basico.View_Equipo editEquipo)
        {
            ValidaEquipo(editEquipo, false);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var Equipo= contex.Equipoes.Single(e => e.EquipoId == editEquipo.EquipoId);
                    Equipo.Activo = editEquipo.Activo;
                    Equipo.CodigoInventario = editEquipo.CodigoInventario;
                    Equipo.CodigoLaboratorio = editEquipo.CodigoLaboratorio;
                    Equipo.ModificadoId = editEquipo.ModificadoId;
                    Equipo.FechaModificacion = DateTime.Now;
                    Equipo.Serial = editEquipo.Serial;
                    Equipo.TipoEquipoId = editEquipo.TipoEquipoId;
                    Equipo.ResponsableId = editEquipo.UsuarioInventarioResponsableId;
                    Equipo.FechaCompra = editEquipo.FechaCompra;
                    contex.SaveChanges();
                }
                return new Dtos.DtoBase
                {
                    Error = false,
                    Mensaje = ""
                };
            }
            catch (Exception ex)
            {
                return new Dtos.DtoBase
                {
                    Error = true,
                    Mensaje = ex.Message
                };
            }
        }

        private void ValidaEquipo(Dtos.Basico.View_Equipo Equipo, bool nuevo)
        {
            List<string> errores = new List<string>();

            if (Equipo.TipoEquipoId <= 0) errores.Add("El tipo de equipo es obligatrio");
            //if (string.IsNullOrEmpty(Equipo.CodigoInventario)) errores.Add("El código de inventario es obligatrio");
            if (string.IsNullOrEmpty(Equipo.CodigoLaboratorio)) errores.Add("El código de laboratorio es obligatrio");
            //if (string.IsNullOrEmpty(Equipo.Serial)) errores.Add("El serial es obligatrio");
            //if (Equipo.UsuarioResponsableId<=0) errores.Add("El el usuario responsable es obligatrio");
            
            using (var contexto = new LabManagerEntities())
            {
                var existeCodigoLaboratorio = contexto.Equipoes.Any(e => e.EquipoId != Equipo.EquipoId && e.CodigoLaboratorio== Equipo.CodigoLaboratorio);
                var existeCodigoInventario = string.IsNullOrEmpty(Equipo.CodigoInventario)?false:contexto.Equipoes.Any(e => e.EquipoId != Equipo.EquipoId && e.CodigoInventario== Equipo.CodigoInventario);
                var existeSerial = string.IsNullOrEmpty(Equipo.Serial)?false:contexto.Equipoes.Any(e => e.EquipoId != Equipo.EquipoId && e.Serial== Equipo.Serial);

                if (existeCodigoLaboratorio) errores.Add("El código de laboratorio ya esta asignado a otro Equipo");
                if (existeCodigoInventario) errores.Add("El código de invetario ya esta asignado a otro Equipo");
                if (existeSerial) errores.Add("El serial ya esta asignado a otro Equipo");
            }

            if (errores.Count > 0)
            {
                var error = string.Join("\r\n", errores);
                throw new Exception(error);
            }

        }

        public Dtos.Basico.Lista_View_Historial_Equipo getHistorial(long EquipoId, DateTime FechaInicio, DateTime FechaFin)
        {
            if (FechaFin < FechaInicio) throw new Exception("La fecha final debe ser mayor a la inicial");
            Dtos.Basico.Lista_View_Historial_Equipo respuesta = new Dtos.Basico.Lista_View_Historial_Equipo();
            respuesta.Items = new List<Dtos.Basico.View_Historial_Equipo>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_Historial_Equipo();
                using (var context = new Datos.LabManagerEntities())
                {
                    var prs = context.View_Historial_Equipo.Where(
                        he => he.EquipoId == EquipoId &&
                        he.FechaPrestamo >= FechaInicio &&
                        he.FechaPrestamo <= FechaFin
                        ).ToList();
                    respuesta.Items = prs.Select(i => mapper.Mapper(i)).ToList();
                    respuesta.Error = false;
                    respuesta.Mensaje = "";
                }
            }
            catch (Exception ex)
            {
                respuesta.Error = true;
                respuesta.Mensaje = ex.Message;
            }
            return respuesta;
        }

        public Dtos.DtoBool IsCodigoInventario(string codigo)
        {
            var respuesta = new Dtos.DtoBool();
            try
            {
                using (var context = new LabManagerEntities())
                {
                    var n=context.Equipoes.Count(eq=>eq.CodigoInventario==codigo);
                    respuesta.Valor = n > 0;
                    respuesta.Error = false;
                    respuesta.Mensaje = "";
                }
            }
            catch (Exception ex)
            {
                respuesta.Error = true;
                respuesta.Mensaje = ex.Message;
            }
            return respuesta;
        }
    }
}
