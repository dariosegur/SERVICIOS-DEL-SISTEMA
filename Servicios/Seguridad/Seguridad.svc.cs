using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dtos;
using Dtos.Basico;

namespace Servicios.Seguridad
{
    public class Seguridad:ISeguridad
    {
        public Dtos.Seguridad.View_UsuarioAutentica Validar(string User, string Password){
            var respuesta = new Dtos.Seguridad.View_UsuarioAutentica();
            try
            {
                var negocio = new Negocio.Seguridad();
                respuesta = negocio.Validar(User,Password);
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

        public Dtos.Seguridad.Lista_View_Menu MenuUsuario(long UsuarioId){
            var respuesta = new Dtos.Seguridad.Lista_View_Menu();
            try
            {
                var negocio = new Negocio.Seguridad();
                respuesta = negocio.MenuUsuario(UsuarioId);
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

        public Dtos.Seguridad.Lista_View_Menu MenuReportesUsuario(long UsuarioId){
            var respuesta = new Dtos.Seguridad.Lista_View_Menu();
            try
            {
                var negocio = new Negocio.Seguridad();
                respuesta = negocio.MenuReportesUsuario(UsuarioId);
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

        public Dtos.Seguridad.Lista_View_Menu MenuPrincipalUsuario(long UsuarioId){
            var respuesta = new Dtos.Seguridad.Lista_View_Menu();
            try
            {
                var negocio = new Negocio.Seguridad();
                respuesta = negocio.MenuPrincipalUsuario(UsuarioId);
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

        public Dtos.Seguridad.Lista_View_Menu MenuGestionUsuario(long UsuarioId){
            var respuesta = new Dtos.Seguridad.Lista_View_Menu();
            try
            {
                var negocio = new Negocio.Seguridad();
                respuesta = negocio.MenuGestionUsuario(UsuarioId);
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

    }
}
