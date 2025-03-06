using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Gestion
{
    public class Mantenimiento
    {
        public Dtos.Gestion.InformacionEliminarEstudiantesInactivos getInformacioneliminarEstudiantes(long UsuarioId)
        {
            Dtos.Gestion.InformacionEliminarEstudiantesInactivos respuesta = new Dtos.Gestion.InformacionEliminarEstudiantesInactivos();
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    var datos = context.InformacionEliminarEstudiantes(UsuarioId).ToList();
                    respuesta.EstudiantesInactivos = datos[0].Inactivos ?? 0 ;
                    respuesta.EstudiantesCandidatosEliminar = datos[0].Candidatos ?? 0;
                    respuesta.RegistrosHistorialEliminar = datos[0].HistorialEliminar??0;
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
        public Dtos.DtoBase EliminarEstudiantesInactivos(long UsuarioId)
        {
            Dtos.DtoBase respuesta = new Dtos.DtoBase();
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    context.EliminarEstudiantes(UsuarioId);
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
