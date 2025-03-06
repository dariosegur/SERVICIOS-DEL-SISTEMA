using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Administracion
{
    public class Restriccion
    {
        public Dtos.Basico.Lista_View_Restriccion getRestricciones(string FiltroTexto, bool? Activo)
        {
            Dtos.Basico.Lista_View_Restriccion respuesta = new Dtos.Basico.Lista_View_Restriccion();
            respuesta.Items = new List<Dtos.Basico.View_Restriccion>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_Restriccion();
                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.Restricciones(FiltroTexto, Activo).ToList();
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

        public Dtos.DtoBase AddRestriccion(Dtos.Basico.View_Restriccion newRestriccion)
        {
            ValidaRestriccion(newRestriccion, true);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var ne = new Datos.Restriccion {
                        Descripcion = newRestriccion.Descripcion,
                        Texto=newRestriccion.Texto,
                        Activo = newRestriccion.Activo,
                        CreadoId = newRestriccion.CreadoId,
                        FechaCreacion = DateTime.Now,
                        
                        ModificadoId=null,
                        FechaModificacion = null
                    };
                    contex.Restriccions.Add(ne);
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

        public Dtos.DtoBase EditarRestriccion(Dtos.Basico.View_Restriccion editaRestriccion)
        {
            ValidaRestriccion(editaRestriccion, false);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var restriccion = contex.Restriccions.Single(m => m.RestriccionId == editaRestriccion.RestriccionId);
                    restriccion.Descripcion = editaRestriccion.Descripcion;
                    restriccion.Texto = editaRestriccion.Texto;
                    restriccion.Activo = editaRestriccion.Activo;

                    restriccion.ModificadoId = editaRestriccion.ModificadoId;
                    restriccion.FechaModificacion = DateTime.Now;
                    contex.SaveChanges(); contex.SaveChanges();
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

        private void ValidaRestriccion(Dtos.Basico.View_Restriccion Restriccion, bool nuevo)
        {
            List<string> errores = new List<string>();
            if (string.IsNullOrEmpty(Restriccion.Descripcion)) errores.Add("La descripción es obligatria");
            if (string.IsNullOrEmpty(Restriccion.Texto)) errores.Add("El texto es obligatrio");

            if (nuevo && (Restriccion.CreadoId < 0)) errores.Add("El usuario que crea el registro es obligatorio");
            if (!nuevo && (Restriccion.ModificadoId == null || Restriccion.ModificadoId < 0)) errores.Add("El usuario que modifica el registro es obligatorio");
            if (!nuevo && Restriccion.RestriccionId < 0) errores.Add("El registro de referencia es obligatorio");
            using (var contexto = new LabManagerEntities())
            {
                var existeDescripcion = contexto.Restriccions.Any(r => r.Descripcion == Restriccion.Descripcion && r.RestriccionId != Restriccion.RestriccionId);
            }

            if (errores.Count > 0)
            {
                var error = string.Join("\r\n", errores);
                throw new Exception(error);
            }

        }
    }
}
