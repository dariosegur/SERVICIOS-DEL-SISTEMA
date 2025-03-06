using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Seguridad
    {
        public Dtos.Seguridad.View_UsuarioAutentica Validar(string User, string Password)
        {
            var resultado = new Dtos.Seguridad.View_UsuarioAutentica();
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    var listaUsuarios = context.Validar(User,Password).ToArray();
                    var validado = listaUsuarios.Count() != 1 ? false : true;
                    if (!validado) throw new Exception("Usuario o contraseña incorrecto");
                    resultado = new Datos.Mapper.Seguridad.View_UsuarioAutentica().Mapper(listaUsuarios[0]);
                    resultado.Error = false;
                }
            }
            catch (Exception ex)
            {
                resultado.Error = true;
                resultado.Mensaje = ex.Message;
            }
            return resultado;
        }
        public Dtos.Seguridad.Lista_View_Menu MenuUsuario(long UsuarioId)
        {
            var resultado = new Dtos.Seguridad.Lista_View_Menu();
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    var listaMenu = context.MenuUsuario(UsuarioId).ToList();
                    if (listaMenu.Count <= 0) throw new Exception("El usuario no tiene acceso al sistema");
                    resultado.MenuOpciones = listaMenu.Select(m => new Datos.Mapper.Seguridad.View_Menu().Mapper(m)).ToList();
                    resultado.Error = false;
                }
            }
            catch (Exception ex)
            {
                resultado.Error = true;
                resultado.Mensaje = ex.Message;
            }
            return resultado;
        }
        public Dtos.Seguridad.Lista_View_Menu MenuReportesUsuario(long UsuarioId)
        {
            var resultado = new Dtos.Seguridad.Lista_View_Menu();
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    var listaMenu = context.MenuUsuarioReportes(UsuarioId).ToList();
                    if (listaMenu.Count <= 0) throw new Exception("El usuario no tiene acceso al sistema");
                    resultado.MenuOpciones = listaMenu.Select(m => new Datos.Mapper.Seguridad.View_Menu().Mapper(m)).ToList();
                    resultado.Error = false;
                }
            }
            catch (Exception ex)
            {
                resultado.Error = true;
                resultado.Mensaje = ex.Message;
            }
            return resultado;
        }
        public Dtos.Seguridad.Lista_View_Menu MenuGestionUsuario(long UsuarioId)
        {
            var resultado = new Dtos.Seguridad.Lista_View_Menu();
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    var listaMenu = context.MenuUsuarioGestion(UsuarioId).ToList();
                    if (listaMenu.Count <= 0) throw new Exception("El usuario no tiene acceso al sistema");
                    resultado.MenuOpciones = listaMenu.Select(m => new Datos.Mapper.Seguridad.View_Menu().Mapper(m)).ToList();
                    resultado.Error = false;
                }
            }
            catch (Exception ex)
            {
                resultado.Error = true;
                resultado.Mensaje = ex.Message;
            }
            return resultado;
        }
        public Dtos.Seguridad.Lista_View_Menu MenuPrincipalUsuario(long UsuarioId)
        {
            var resultado = new Dtos.Seguridad.Lista_View_Menu();
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    var listaMenu = context.MenuUsuarioPrincipal(UsuarioId).ToList();
                    if (listaMenu.Count <= 0) throw new Exception("El usuario no tiene acceso al sistema");
                    resultado.MenuOpciones = listaMenu.Select(m => new Datos.Mapper.Seguridad.View_Menu().Mapper(m)).ToList();
                    resultado.Error = false;
                }
            }
            catch (Exception ex)
            {
                resultado.Error = true;
                resultado.Mensaje = ex.Message;
            }
            return resultado;
        }
    }
}
