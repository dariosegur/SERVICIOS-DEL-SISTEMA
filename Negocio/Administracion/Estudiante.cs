using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio.Administracion
{
    public class Estudiante
    {
        public Dtos.Basico.Lista_View_Estudiantes getEstudiantes(string FiltroTexto, bool? Activo)
        {
            Dtos.Basico.Lista_View_Estudiantes respuesta = new Dtos.Basico.Lista_View_Estudiantes();
            respuesta.Items = new List<Dtos.Basico.View_Estudiante>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_Estudiante();
                using (var context = new Datos.LabManagerEntities())
                {
                    var prs = context.Estudiante(FiltroTexto, Activo).ToList();
                    foreach (var pr in prs)
                    {
                        var r = mapper.Mapper(pr);
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

        public Dtos.DtoBase AddEstudiante(Dtos.Basico.View_Estudiante newEstudiante)
        {
            ValidaEstudiante(newEstudiante, true);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var ne = Datos.Mapper.Seguridad.Usuario.FromEstudianteAdd(newEstudiante);
                    contex.Usuarios.Add(ne);
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

        public Dtos.DtoBase EditEstudiante(Dtos.Basico.View_Estudiante editEstudiante)
        {
            ValidaEstudiante(editEstudiante, false);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var estudiante = contex.Usuarios.Single(u => u.UsuarioId == editEstudiante.UsuarioId);
                    Datos.Mapper.Seguridad.Usuario.FromEstudianteEdit(editEstudiante, ref estudiante);
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

        public Dtos.Basico.Lista_View_Historial_Estudiante getHistorialBasico(long UsuarioId, DateTime FechaInicio, DateTime FechaFin)
        {
            if (FechaFin < FechaInicio) throw new Exception("La fecha final debe ser mayor a la inicial");
            Dtos.Basico.Lista_View_Historial_Estudiante respuesta = new Dtos.Basico.Lista_View_Historial_Estudiante();
            respuesta.Items = new List<Dtos.Basico.View_Historial_Estudiante>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_Historial_Estudiante();
                using (var context = new Datos.LabManagerEntities())
                {
                    var prs = context.View_Historial_Estudiante.Where(
                        he=>he.UsuarioId==UsuarioId && 
                        he.FechaPrestamo>=FechaInicio &&
                        he.FechaPrestamo <= FechaFin
                        ).ToList();                    
                    respuesta.Items = prs.Select(i=>mapper.Mapper(i)).OrderByDescending(a => a.FechaPrestamo).ThenByDescending(a => a.FechaRecepcion).ToList();
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

        private void ValidaEstudiante(Dtos.Basico.View_Estudiante estudiante, bool nuevo)
        {
            List<string> errores = new List<string>();
            if (string.IsNullOrEmpty(estudiante.Nombres)) errores.Add("El nombre es obligatrio");
            if (string.IsNullOrEmpty(estudiante.Apellidos)) errores.Add("El apellido es obligatrio");
            if (string.IsNullOrEmpty(estudiante.Documento)) errores.Add("El documento es obligatrio");
            if (string.IsNullOrEmpty(estudiante.Codigo)) errores.Add("El código es obligatrio");
            if (string.IsNullOrEmpty(estudiante.Barcode)) errores.Add("El código de baras es obligatrio");
            if (estudiante.FacultadId == null || estudiante.FacultadId < 0) errores.Add("La facultad es obligatoria");
            if (estudiante.SemestreBasico == null || estudiante.SemestreBasico <= 0 || estudiante.SemestreBasico > 10) errores.Add("El semestre básico es obligatorio, y debe ser entre 1 y 10");
            if (nuevo && (estudiante.UsuarioCreaId == null || estudiante.UsuarioCreaId < 0)) errores.Add("El usuario que crea el registro es obligatorio");
            if (!nuevo && (estudiante.UsuarioModificaId == null || estudiante.UsuarioModificaId < 0)) errores.Add("El usuario que modifica el registro es obligatorio");
            if (!nuevo && estudiante.UsuarioId <= 0) errores.Add("La información interna del estudiante es obligatoria");
            using (var contexto = new LabManagerEntities())
            {
                var existeDocuemnto = contexto.Usuarios.Any(u=>u.Documento==estudiante.Documento && u.UsuarioId!=estudiante.UsuarioId);
                var existeBarcode = contexto.Usuarios.Any(u=>u.BarCode==estudiante.Barcode && u.UsuarioId!=estudiante.UsuarioId);
                var existeCodigo = contexto.Usuarios.Any(u=>u.Codigo==estudiante.Codigo && u.UsuarioId!=estudiante.UsuarioId);
                if(existeDocuemnto) errores.Add("El documento ya esta asignado a otro estudiante o a otro usuario");
                if(existeBarcode) errores.Add("El código de barras ya esta asignado a otro estudiante o a otro usuario");
                if(existeCodigo) errores.Add("El código ya esta asignado a otro estudiante o a otro usuario");
            }
            
            if (errores.Count > 0)
            {
                var error = string.Join("\r\n", errores);
                throw new Exception(error);
            }
            
        }
    }
}
