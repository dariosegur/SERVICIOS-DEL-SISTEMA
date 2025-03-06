using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dtos;
using Dtos.Basico;

namespace Servicios.Gestion
{
    public class InactivarEstudiante:IInactivarEstudiante
    {
        public Dtos.Gestion.Lista_View_Parametros getParametros(string FiltroTexto, int UsuarioId){
            var respuesta = new Dtos.Gestion.Lista_View_Parametros();
            try
            {
                var negocio = new Negocio.Gestion.InactivarEstudiante();
                respuesta = negocio.getParametros(FiltroTexto,UsuarioId);
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

        public Dtos.Gestion.InformacionInactivar getInformacionInactivar(){
            var respuesta = new Dtos.Gestion.InformacionInactivar();
            try
            {
                var negocio = new Negocio.Gestion.InactivarEstudiante();
                respuesta = negocio.getInformacionInactivar();
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

        public Dtos.DtoBase InactivarEstudiantes(long UsuarioId){
            var respuesta = new Dtos.DtoBase();
            try
            {
                var negocio = new Negocio.Gestion.InactivarEstudiante();
                respuesta = negocio.InactivarEstudiantes(UsuarioId);
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

        public Dtos.DtoBase ActivarEstudiantes(long UsuarioId, long UsuarioIdActivar){
            var respuesta = new Dtos.DtoBase();
            try
            {
                var negocio = new Negocio.Gestion.InactivarEstudiante();
                respuesta = negocio.ActivarEstudiantes(UsuarioId,UsuarioIdActivar);
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

    }
}
