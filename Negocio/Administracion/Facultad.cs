using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Administracion
{
    public class Facultad
    {
        public Dtos.Basico.Lista_View_Facultad getFacultad(string FiltroTexto, bool? Activo)
        {
            Dtos.Basico.Lista_View_Facultad respuesta = new Dtos.Basico.Lista_View_Facultad();
            respuesta.Items = new List<Dtos.Basico.View_Facultad>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_Facultad();
                using (var context = new Datos.LabManagerEntities())
                {
                    var prs = context.Facultades(FiltroTexto, Activo).ToList();
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

        public Dtos.DtoBase AddFacultad(Dtos.Basico.View_Facultad newFacultad)
        {
            ValidaFacultad(newFacultad, true);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var ne = Datos.Mapper.Seguridad.Facultad.FromFacultadAdd(newFacultad);
                    contex.Facultads.Add(ne);
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

        public Dtos.DtoBase EditFacultad(Dtos.Basico.View_Facultad editFacultad)
        {
            ValidaFacultad(editFacultad, false);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var facultad = contex.Facultads.Single(f => f.FacultadId == editFacultad.FacultadId);
                    Datos.Mapper.Seguridad.Facultad.FromFacultadEdit(editFacultad, ref facultad);
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

        private void ValidaFacultad(Dtos.Basico.View_Facultad facultad, bool nuevo)
        {
            List<string> errores = new List<string>();
            if (string.IsNullOrEmpty(facultad.Nombre)) errores.Add("El nombre es obligatrio");
            if (facultad.Codigo<=0) errores.Add("El código es obligatrio");
            if (nuevo && facultad.UsuarioCreaId <= 0) errores.Add("El usuario que crea el registro es obligatorio");
            if (!nuevo && (facultad.UsuarioModificaId == null || facultad.UsuarioModificaId <= 0)) errores.Add("El usuario que modifica el registro es obligatorio");
            using (var contexto = new LabManagerEntities())
            {
                var existeFacultad = contexto.Facultads.Any(f => f.FacultadId!=facultad.FacultadId&&f.Nombre==facultad.Nombre);
                var existeCodigo = contexto.Facultads.Any(f => f.FacultadId!=facultad.FacultadId && f.Codigo==facultad.Codigo);
                if (existeFacultad) errores.Add("El nombre de la facultad ya existe");
                if (existeCodigo) errores.Add("El código de la facultad ya existe");
            }
            if (errores.Count > 0)
            {
                var error = string.Join("\r\n", errores);
                throw new Exception(error);
            }
        }
    }
}
