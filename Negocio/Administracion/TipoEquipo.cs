using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Administracion
{
    public class TipoEquipo
    {

        public Dtos.Basico.Lista_View_TiposEquipo getTiposEquipo(string FiltroTexto, bool? Activo)
        {
            Dtos.Basico.Lista_View_TiposEquipo respuesta = new Dtos.Basico.Lista_View_TiposEquipo();
            respuesta.Items = new List<Dtos.Basico.View_TipoEquipo>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_TipoEquipo();
                var mapperRestricciones = new Datos.Mapper.Basico.View_RestriccionTipoEquipo();
                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.TiposEquipo(FiltroTexto, Activo).ToList();
                    foreach (var item in lista)
                    {
                        var r = mapper.Mapper(item);
                        r.Restricciones = new List<Dtos.Basico.View_RestriccionTipoEquipo>();
                        var restricciones =
                            context.
                            View_RestriccionTipoEquipo.Where(rte => rte.TipoEquipoId == item.TipoEquipoId)
                            .ToList();
                        foreach (var re in restricciones)
                        {
                            r.Restricciones.Add(mapperRestricciones.Mapper(re));
                        }
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

        public Dtos.Basico.Lista_View_TipoEquipo_Activo getTipoEquiposActivos()
        {
            Dtos.Basico.Lista_View_TipoEquipo_Activo respuesta = new Dtos.Basico.Lista_View_TipoEquipo_Activo();
            respuesta.Items = new List<Dtos.Basico.View_TipoEquipo_Activo>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_TipoEquipo_Activo();
                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.View_TipoEquipo_Activo.
                        OrderBy(te=>te.Descripcion).ThenBy(te=>te.Marca).ThenBy(te=>te.Referencia).ToList();
                    respuesta.Items =
                        lista.Select(i => mapper.Mapper(i)).ToList();
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

        public Dtos.DtoBase AddTipoEquipo(Dtos.Basico.View_TipoEquipo newTipoEquipo)
        {
            ValidaTipoEquipo(newTipoEquipo, true);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var nuevo = new Datos.TipoEquipo {
                        Descripcion = newTipoEquipo.Descripcion,
                        Referencia = newTipoEquipo.Referencia,
                        Marca  = newTipoEquipo.Marca,
                        Activo = newTipoEquipo.Activo,
                        CreadoId = newTipoEquipo.CreadoId,
                        FechaCreacion = DateTime.Now,
                        RestriccionTipoEquipoes =new List<RestriccionTipoEquipo>()
                    };
                    foreach (var restriccion in newTipoEquipo.Restricciones)
                    {
                        var nRestriccion = new Datos.RestriccionTipoEquipo {
                            Activo=true,
                            RestriccionId = restriccion.RestriccionId,
                            FechaCreacion = DateTime.Now,
                            CreadoId = newTipoEquipo.CreadoId
                        };
                        nuevo.RestriccionTipoEquipoes.Add(nRestriccion);
                    }                   
                    contex.TipoEquipoes.Add(nuevo);
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

        public Dtos.DtoBase EditTipoEquipo(Dtos.Basico.View_TipoEquipo editTipoEquipo)
        {
            ValidaTipoEquipo(editTipoEquipo, false);
            try
            {
                using (var context = new LabManagerEntities())
                {
                    var tipoequipo = context.TipoEquipoes.Single(a=>a.TipoEquipoId == editTipoEquipo.TipoEquipoId);
                    tipoequipo.Descripcion =editTipoEquipo.Descripcion;
                    tipoequipo.Marca =editTipoEquipo.Marca;
                    tipoequipo.Referencia =editTipoEquipo.Referencia;
                    tipoequipo.Activo =editTipoEquipo.Activo;
                    tipoequipo.ModificadoId = editTipoEquipo.ModificadoId;
                    tipoequipo.FechaModificacion = DateTime.Now;

                    SalvaRestricciones(context,editTipoEquipo);

                    context.SaveChanges();
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

        private void ValidaTipoEquipo(Dtos.Basico.View_TipoEquipo tipoEquipo, bool nuevo)
        {
            List<string> errores = new List<string>();
            if (string.IsNullOrEmpty(tipoEquipo.Descripcion))
            {
                errores.Add("La descripción es obligatoria");
            }
            else if(tipoEquipo.Descripcion.Length<4 || tipoEquipo.Descripcion.Length>200){
                errores.Add("La descripción debe tener entre 4 y 200 caracteres");
            }

            if (string.IsNullOrEmpty(tipoEquipo.Marca))
            {
                errores.Add("La marca es obligatoria");
            }
            else if (tipoEquipo.Marca.Length < 2 || tipoEquipo.Marca.Length > 200)
            {
                errores.Add("La marca debe tener entre 2 y 200 caracteres");
            }

            if (string.IsNullOrEmpty(tipoEquipo.Referencia))
            {
                errores.Add("La referencia es obligatoria");
            }
            else if (tipoEquipo.Referencia.Length < 2 || tipoEquipo.Referencia.Length > 200)
            {
                errores.Add("La referencia debe tener entre 2 y 200 caracteres");
            }

            if (nuevo && (tipoEquipo.CreadoId <= 0)) errores.Add("El usuario que crea el registro es obligatorio");
            if (!nuevo && (tipoEquipo.ModificadoId == null || tipoEquipo.ModificadoId <= 0)) errores.Add("El usuario que modifica el registro es obligatorio");

            using (var context=new LabManagerEntities())
            {
                var curTipoEquipo = context.TipoEquipoes.Where(a=>
                a.Marca==tipoEquipo.Marca &&
                a.Referencia==tipoEquipo.Referencia &&
                a.Descripcion==tipoEquipo.Descripcion &&
                a.TipoEquipoId!=tipoEquipo.TipoEquipoId 
                ).ToList();
                if (curTipoEquipo.Count > 0) errores.Add("Ya existe un tipo de equipo con estas caractersticas creado");
            }
            if (errores.Count > 0)
            {
                var error = string.Join("\r\n", errores);
                throw new Exception(error);
            }

        }

        private void SalvaRestricciones(LabManagerEntities context, Dtos.Basico.View_TipoEquipo editTipoEquipo) {
            var restriccionesModificadasId = editTipoEquipo.Restricciones
                .Where(rm=>rm.RestriccionTipoEquipoId!=-1)
                .Select(rm => rm.RestriccionId).ToArray();
            var restriccionesToAddId = editTipoEquipo.Restricciones
                .Where(rm=>rm.RestriccionTipoEquipoId ==-1)
                .Select(rm => rm.RestriccionId).ToArray();
            var restriccionesActuales = context.RestriccionTipoEquipoes.Where(rte=>rte.TipoEquipoId==editTipoEquipo.TipoEquipoId && rte.Activo==true);
            var ToInactivate = restriccionesActuales.Where(ra=>!restriccionesModificadasId.Contains(ra.RestriccionId));
            foreach (var r in ToInactivate)
            {
                r.Activo = false;
                r.ModificadoId = editTipoEquipo.ModificadoId;
                r.FechaModificacion = DateTime.Now;
            }
            foreach (var r in restriccionesToAddId)
            {
                var rta = new RestriccionTipoEquipo
                {
                    Activo = true,
                    RestriccionId = r,
                    TipoEquipoId = editTipoEquipo.TipoEquipoId,
                    CreadoId = (long)editTipoEquipo.ModificadoId,
                    FechaCreacion = DateTime.Now
                };
                context.RestriccionTipoEquipoes.Add(rta);
            }
        }
    }
}
