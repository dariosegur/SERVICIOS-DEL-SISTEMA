using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio.Administracion
{
    public class Docente
    {
        public Dtos.Basico.Lista_View_Docentes getDocentes(string FiltroTexto, bool? Activo)
        {
            Dtos.Basico.Lista_View_Docentes respuesta = new Dtos.Basico.Lista_View_Docentes();
            respuesta.Items = new List<Dtos.Basico.View_Docente>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_Docente();
                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.Docente(FiltroTexto, Activo).ToList();
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

        public Dtos.DtoBase AddDocente(Dtos.Basico.View_Docente newDocente)
        {
            ValidaDocente(newDocente, true);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var ne = Datos.Mapper.Seguridad.Usuario.FromDocenteAdd(newDocente);
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

        public Dtos.DtoBase EditDocente(Dtos.Basico.View_Docente editDocente)
        {
            ValidaDocente(editDocente, false);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var Docente = contex.Usuarios.Single(u => u.UsuarioId == editDocente.UsuarioId);
                    Datos.Mapper.Seguridad.Usuario.FromDocenteEdit(editDocente, ref Docente);
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

        public Dtos.Basico.Lista_View_Historial_Docente getHistorialBasico(long UsuarioId, DateTime FechaInicio, DateTime FechaFin)
        {
            if (FechaFin < FechaInicio) throw new Exception("La fecha final debe ser mayor a la inicial");
            Dtos.Basico.Lista_View_Historial_Docente respuesta = new Dtos.Basico.Lista_View_Historial_Docente();
            respuesta.Items = new List<Dtos.Basico.View_Historial_Docente>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_Historial_Docente();
                using (var context = new Datos.LabManagerEntities())
                {
                    var prs = context.View_Historial_Docente.Where(
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

        private void ValidaDocente(Dtos.Basico.View_Docente Docente, bool nuevo)
        {
            List<string> errores = new List<string>();
            if (string.IsNullOrEmpty(Docente.Nombres)) errores.Add("El nombre es obligatrio");
            if (string.IsNullOrEmpty(Docente.Apellidos)) errores.Add("El apellido es obligatrio");
            if (string.IsNullOrEmpty(Docente.Documento)) errores.Add("El documento es obligatrio");
            if (string.IsNullOrEmpty(Docente.Barcode)) errores.Add("El código de baras es obligatrio");
            if (Docente.FacultadId == null || Docente.FacultadId < 0) errores.Add("La facultad es obligatoria");
            if (nuevo && (Docente.UsuarioCreaId == null || Docente.UsuarioCreaId < 0)) errores.Add("El usuario que crea el registro es obligatorio");
            if (!nuevo && (Docente.UsuarioModificaId == null || Docente.UsuarioModificaId < 0)) errores.Add("El usuario que modifica el registro es obligatorio");
            if (!nuevo && Docente.UsuarioId < 0) errores.Add("El usuario que modifica el registro es obligatorio");
            using (var contexto = new LabManagerEntities())
            {
                var existeDocuemnto = contexto.Usuarios.Any(u=>u.Documento==Docente.Documento && u.UsuarioId!=Docente.UsuarioId);
                var existeBarcode = contexto.Usuarios.Any(u=>u.BarCode==Docente.Barcode && u.UsuarioId!=Docente.UsuarioId);
                if(existeDocuemnto) errores.Add("El documento ya esta asignado a otro Docente o a otro usuario");
                if(existeBarcode) errores.Add("El código de barras ya esta asignado a otro Docente o a otro usuario");
            }
            
            if (errores.Count > 0)
            {
                var error = string.Join("\r\n", errores);
                throw new Exception(error);
            }
            
        }
    }
}
