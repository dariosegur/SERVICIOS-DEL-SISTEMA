using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Administracion
{
    public class Anotacion
    {

        public Dtos.Basico.Lista_View_Anotaciones getAnotaciones(long UsuarioId)
        {
            Dtos.Basico.Lista_View_Anotaciones respuesta = new Dtos.Basico.Lista_View_Anotaciones();
            respuesta.Items = new List<Dtos.Basico.View_Anotaciones>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_Anotaciones();
                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.View_Anotaciones.Where(a=>a.UsuarioId==UsuarioId)
                        .OrderBy(a => a.EstadoAnotacionId).ThenByDescending(a => a.FechaCreacion).ToList();
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

        public Dtos.DtoBase AddAnotacion(Dtos.Basico.View_Anotaciones newAnotacion)
        {
            ValidaAnotacion(newAnotacion, true);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var nuevo = new Datos.Anotacion {
                        UsuarioId=newAnotacion.UsuarioId,
                        Descripcion = newAnotacion.Descripcion,
                        EstadoAnotacionId = newAnotacion.EstadoAnotacionId,
                        CreadoId = newAnotacion.CreadoId,
                        FechaCreacion = DateTime.Now
                    };                   
                    contex.Anotacions.Add(nuevo);
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

        public Dtos.DtoBase EditAnotacion(Dtos.Basico.View_Anotaciones editAnotacion)
        {
            ValidaAnotacion(editAnotacion, false);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var anotacion = contex.Anotacions.Single(a=>a.AnotacionId == editAnotacion.AnotacionId);
                    anotacion.Descripcion =editAnotacion.Descripcion;
                    anotacion.EstadoAnotacionId =editAnotacion.EstadoAnotacionId;
                    anotacion.ModificadoId = editAnotacion.ModificadoId;
                    anotacion.FechaModificacion = DateTime.Now;
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

        public Dtos.Basico.Lista_View_EstadoAnotacion getEstadosAnotacion()
        {
            Dtos.Basico.Lista_View_EstadoAnotacion respuesta = new Dtos.Basico.Lista_View_EstadoAnotacion();
            respuesta.Items = new List<Dtos.Basico.EstadoAnotacion>();
            try
            {
                var mapper = new Datos.Mapper.Basico.EstadoAnotacion();
                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.EstadoAnotacions.ToList();
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

        private void ValidaAnotacion(Dtos.Basico.View_Anotaciones anotacion, bool nuevo)
        {
            List<string> errores = new List<string>();
            if (string.IsNullOrEmpty(anotacion.Descripcion))
            {
                errores.Add("La descripción es obligatoria");
            }
            else if(anotacion.Descripcion.Length<10 || anotacion.Descripcion.Length>200){
                errores.Add("La descripción debe tener entre 10 y 200 caracteres");
            }
            if (!Enum.IsDefined(typeof(Constantes.EstadoAnotacion),anotacion.EstadoAnotacionId)) errores.Add("El estado seleccionado no es válido");

            if (nuevo && (anotacion.CreadoId <= 0)) errores.Add("El usuario que crea el registro es obligatorio");
            if (!nuevo && (anotacion.ModificadoId == null || anotacion.ModificadoId <= 0)) errores.Add("El usuario que modifica el registro es obligatorio");
            if (anotacion.UsuarioId <= 0) errores.Add("La información del usuario es obligatoria");

            using (var context=new LabManagerEntities())
            {
                var curAnotacion = context.Anotacions.Where(a=>a.AnotacionId==anotacion.AnotacionId).ToList();
                if (curAnotacion.Count == 1)
                {
                    if (curAnotacion[0].EstadoAnotacionId != (int)Constantes.EstadoAnotacion.Activa) errores.Add("Solo las anotaciones en estado activo se pueden modificar");
                }
                else
                {
                    if (anotacion.EstadoAnotacionId != (int)Constantes.EstadoAnotacion.Activa) errores.Add("Una anotación solo se puede crear en estado activa");
                }
            }
            if (errores.Count > 0)
            {
                var error = string.Join("\r\n", errores);
                throw new Exception(error);
            }

        }
    }
}
