using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Administracion
{
    public class Auxiliar
    {

        public Dtos.Basico.Lista_View_Auxiliar getAuxiliares(string FiltroTexto, bool? Activo)
        {
            Dtos.Basico.Lista_View_Auxiliar respuesta = new Dtos.Basico.Lista_View_Auxiliar();
            respuesta.Items = new List<Dtos.Basico.View_Auxiliar>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_Auxiliar();
                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.Auxiliar(FiltroTexto, Activo).ToList();
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

        public Dtos.Basico.Lista_View_Auxiliar_Activo getAuxiliaresActivos()
        {
            Dtos.Basico.Lista_View_Auxiliar_Activo respuesta = new Dtos.Basico.Lista_View_Auxiliar_Activo();
            respuesta.Items = new List<Dtos.Basico.View_Auxiliar_Activo>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_Auxiliar_Activo();
                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.View_Auxiliar_Activo.ToList();
                    respuesta.Items = 
                        lista.Select(i=>mapper.Mapper(i)).ToList();
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

        public Dtos.DtoBase AddAuxiliar(Dtos.Basico.View_Auxiliar newAuxiliar)
        {
            ValidaAuxiliar(newAuxiliar, true);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var ne = Datos.Mapper.Seguridad.Usuario.FromAuxiliarAdd(newAuxiliar);
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

        public Dtos.DtoBase EditAuxiliar(Dtos.Basico.View_Auxiliar editAuxiliar)
        {
            ValidaAuxiliar(editAuxiliar, false);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var Auxiliar= contex.Usuarios.Single(u => u.UsuarioId == editAuxiliar.UsuarioId);
                    Datos.Mapper.Seguridad.Usuario.FromAuxiliarEdit(editAuxiliar, ref Auxiliar);
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

        private void ValidaAuxiliar(Dtos.Basico.View_Auxiliar Auxiliar, bool nuevo)
        {
            List<string> errores = new List<string>();
            if (string.IsNullOrEmpty(Auxiliar.Nombres)) errores.Add("El nombre es obligatrio");
            if (string.IsNullOrEmpty(Auxiliar.Apellidos)) errores.Add("El apellido es obligatrio");
            if (string.IsNullOrEmpty(Auxiliar.Documento)) errores.Add("El documento es obligatrio");
            if (string.IsNullOrEmpty(Auxiliar.Barcode)) errores.Add("El código de baras es obligatrio");
            if (!string.IsNullOrEmpty(Auxiliar.Password) && Auxiliar.Password.Length < 8) errores.Add("La contraseña debe ser de mínimo 8 caracteres");
            if (string.IsNullOrEmpty(Auxiliar.Password) && nuevo) errores.Add("La contraseña es obligatoria y debe ser de mínimo 8 caracteres");

            if (nuevo && (Auxiliar.UsuarioCreaId == null || Auxiliar.UsuarioCreaId < 0)) errores.Add("El usuario que crea el registro es obligatorio");
            if (!nuevo && (Auxiliar.UsuarioModificaId == null || Auxiliar.UsuarioModificaId < 0)) errores.Add("El usuario que modifica el registro es obligatorio");
            if (!nuevo && Auxiliar.UsuarioId < 0) errores.Add("El usuario que modifica el registro es obligatorio");
            using (var contexto = new LabManagerEntities())
            {
                var existeDocuemnto = contexto.Usuarios.Any(u => u.Documento == Auxiliar.Documento && u.UsuarioId != Auxiliar.UsuarioId);
                var existeBarcode = contexto.Usuarios.Any(u => u.BarCode == Auxiliar.Barcode && u.UsuarioId != Auxiliar.UsuarioId);
                if (existeDocuemnto) errores.Add("El documento ya esta asignado a otro Auxiliar o a otro usuario");
                if (existeBarcode) errores.Add("El código de barras ya esta asignado a otro Auxiliar o a otro usuario");
            }

            if (errores.Count > 0)
            {
                var error = string.Join("\r\n", errores);
                throw new Exception(error);
            }

        }
    }
}
