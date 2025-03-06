using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Gestion
{
    public class InactivarEstudiante
    {
        public Dtos.Gestion.Lista_View_Parametros getParametros(string FiltroTexto, int UsuarioId)
        {
            Dtos.Gestion.Lista_View_Parametros respuesta = new Dtos.Gestion.Lista_View_Parametros();
            respuesta.Items = new List<Dtos.Gestion.Parametro>();
            try
            {
                var mapper = new Datos.Mapper.Gestion.Parametro();
                var nombreParametros = FiltroTexto.Split(',');
                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.Parametroes.Where(p=>nombreParametros.Contains(p.Nombre)).ToList();
                    foreach (var reg in lista)
                    {
                        var r = mapper.Mapper(reg);
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
        public Dtos.Gestion.InformacionInactivar getInformacionInactivar()
        {
            Dtos.Gestion.InformacionInactivar respuesta = new Dtos.Gestion.InformacionInactivar();
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    respuesta.EstudiantesTotal = context.Usuarios.Count(u => u.TipoUsuarioId == 1);
                    respuesta.EstudiantesActivos = context.Usuarios.Count(u => u.TipoUsuarioId == 1 && u.Activo);
                    respuesta.EstudiantesInactivos = respuesta.EstudiantesTotal - respuesta.EstudiantesActivos;
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
        public Dtos.DtoBase InactivarEstudiantes(long UsuarioId)
        {
            Dtos.DtoBase respuesta = new Dtos.DtoBase();
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    context.InactivarEstudiantes(UsuarioId);
                    respuesta.Error = false;
                    respuesta.Mensaje = "";
                }
            }
            catch (Exception ex)
            {
                ex = Herramientas.ExtractException(ex);
                respuesta.Error = true;
                respuesta.Mensaje = ex.Message;
            }
            return respuesta;
        }
        public Dtos.DtoBase ActivarEstudiantes(long UsuarioId, long UsuarioIdActivar)
        {
            Dtos.DtoBase respuesta = new Dtos.DtoBase();
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    context.ActivarEstudiantes(UsuarioId,UsuarioIdActivar);
                    respuesta.Error = false;
                    respuesta.Mensaje = "";
                }
            }
            catch (Exception ex)
            {
                ex = Herramientas.ExtractException(ex);
                respuesta.Error = true;
                respuesta.Mensaje = ex.Message;
            }
            return respuesta;
        }
        public Dtos.DtoBool IsUserActive(String BarCode)
        {
            Dtos.DtoBool respuesta = new Dtos.DtoBool();
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    var r = context.Usuarios.Where(u=>u.BarCode==BarCode);
                    if (r.Count() != 1) throw new Exception("No user");
                    respuesta.Valor = r.ToArray()[0].Activo;
                    respuesta.Error = false;
                    respuesta.Mensaje = "";
                }
            }
            catch (Exception ex)
            {
                ex = Herramientas.ExtractException(ex);
                respuesta.Error = true;
                respuesta.Mensaje = ex.Message;
            }
            return respuesta;
        }
    }
}
