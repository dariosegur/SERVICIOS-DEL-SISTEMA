using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Administracion
{
    public class Administrativo
    {

        public Dtos.Basico.Lista_View_Administrativo getAdministrativos(string FiltroTexto, bool? Activo)
        {
            Dtos.Basico.Lista_View_Administrativo respuesta = new Dtos.Basico.Lista_View_Administrativo();
            respuesta.Items = new List<Dtos.Basico.View_Administrativo>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_Administrativo();
                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.Administrativo(FiltroTexto, Activo).ToList();
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

        public Dtos.DtoBase AddAdministrativo(Dtos.Basico.View_Administrativo newAdministrativo)
        {
            ValidaAdministrativo(newAdministrativo, true);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var ne = Datos.Mapper.Seguridad.Usuario.FromAdministrativoAdd(newAdministrativo);
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

        public Dtos.DtoBase EditAdministrativo(Dtos.Basico.View_Administrativo editAdministrativo)
        {
            ValidaAdministrativo(editAdministrativo, false);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var Administrativo= contex.Usuarios.Single(u => u.UsuarioId == editAdministrativo.UsuarioId);
                    Datos.Mapper.Seguridad.Usuario.FromAdministrativoEdit(editAdministrativo, ref Administrativo);
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

        private void ValidaAdministrativo(Dtos.Basico.View_Administrativo Administrativo, bool nuevo)
        {
            List<string> errores = new List<string>();
            if (string.IsNullOrEmpty(Administrativo.Nombres)) errores.Add("El nombre es obligatrio");
            if (string.IsNullOrEmpty(Administrativo.Apellidos)) errores.Add("El apellido es obligatrio");
            if (string.IsNullOrEmpty(Administrativo.Documento)) errores.Add("El documento es obligatrio");
            if (string.IsNullOrEmpty(Administrativo.Barcode)) errores.Add("El código de baras es obligatrio");
            if (!string.IsNullOrEmpty(Administrativo.Password)&&Administrativo.Password.Length<8) errores.Add("La contraseña debe ser de mínimo 8 caracteres");
            if (string.IsNullOrEmpty(Administrativo.Password)&&nuevo) errores.Add("La contraseña es obligatoria y debe ser de mínimo 8 caracteres");

            if (nuevo && (Administrativo.UsuarioCreaId == null || Administrativo.UsuarioCreaId < 0)) errores.Add("El usuario que crea el registro es obligatorio");
            if (!nuevo && (Administrativo.UsuarioModificaId == null || Administrativo.UsuarioModificaId < 0)) errores.Add("El usuario que modifica el registro es obligatorio");
            if (!nuevo && Administrativo.UsuarioId < 0) errores.Add("El usuario que modifica el registro es obligatorio");
            using (var contexto = new LabManagerEntities())
            {
                var existeDocuemnto = contexto.Usuarios.Any(u => u.Documento == Administrativo.Documento && u.UsuarioId != Administrativo.UsuarioId);
                var existeBarcode = contexto.Usuarios.Any(u => u.BarCode == Administrativo.Barcode && u.UsuarioId != Administrativo.UsuarioId);
                if (existeDocuemnto) errores.Add("El documento ya esta asignado a otro Administrativo o a otro usuario");
                if (existeBarcode) errores.Add("El código de barras ya esta asignado a otro Administrativo o a otro usuario");
            }

            if (errores.Count > 0)
            {
                var error = string.Join("\r\n", errores);
                throw new Exception(error);
            }

        }
    }
}
