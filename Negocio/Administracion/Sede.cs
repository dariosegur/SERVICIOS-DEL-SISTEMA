using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Administracion
{
    public class Sede
    {

        public Dtos.Basico.Lista_View_Sede getSede(string FiltroTexto, bool? Activo)
        {
            Dtos.Basico.Lista_View_Sede respuesta = new Dtos.Basico.Lista_View_Sede();

            respuesta.Items = new List<Dtos.Basico.View_Sede>();

            try
            {
                var mapper = new Datos.Mapper.Basico.View_Sede();

                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.Sede(FiltroTexto, Activo).ToList();
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
        
        public Dtos.DtoBase AddSede(Dtos.Basico.View_Sede newSede)
        {

            ValidarSede(newSede, true);
            try
            {
                
                using (var contex = new LabManagerEntities())
                {
                    var nuevo = new Datos.Sede {
                        Nombre=newSede.Nombre,
                        Activo = newSede.Activo,
                        FechaCreacion = DateTime.Now,
                        CreadoId = newSede.CreadoId
                    };                   
                    contex.Sedes.Add(nuevo);
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

        public Dtos.DtoBase EditSede(Dtos.Basico.View_Sede editSede)
        {
            ValidarSede(editSede, false);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var sede = contex.Sedes.Single(a=>a.SedeId == editSede.SedeId);
                    sede.Nombre = editSede.Nombre;
                    sede.Activo =editSede.Activo;
                    sede.FechaModificacion = DateTime.Now;
                    sede.ModificadoId = editSede.ModificadoId;
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

        private void ValidarSede(Dtos.Basico.View_Sede sede, bool nuevo)
        {
            List<string> errores = new List<string>();
            if (string.IsNullOrEmpty(sede.Nombre))
            {
                errores.Add("El nombre es obligatorio");
            }
            else if(sede.Nombre.Length>50){
                errores.Add("El nombre no puede contener mas de 50 caracteres");
            }

            if (nuevo && (sede.CreadoId <= 0)) errores.Add("El usuario que crea el registro es obligatorio");
            if (!nuevo && (sede.ModificadoId == null || sede.ModificadoId <= 0)) errores.Add("El usuario que modifica el registro es obligatorio");

            using (var context=new LabManagerEntities())
            {
                var curSede = context.Sedes.Where(a=>
                    a.Nombre==sede.Nombre&&
                    a.SedeId!=sede.SedeId
                ).ToList();
                if (curSede.Count > 0) errores.Add("Ya existe una sede con estas caractersticas creada");
            }
            if (errores.Count > 0)
            {
                var error = string.Join("\r\n", errores);
                throw new Exception(error);
            }

        }
    }
}
