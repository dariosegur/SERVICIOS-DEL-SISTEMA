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
    public class CopiasDeSeguridad:ICopiasDeSeguridad
    {
        public Dtos.Gestion.InformacionCopiasDeSeguridad getInformacionBackup(long UsuarioId){
            var respuesta = new Dtos.Gestion.InformacionCopiasDeSeguridad();
            try
            {
                var negocio = new Negocio.Gestion.CopiasDeSeguridad();
                respuesta = negocio.getInformacionBackup(UsuarioId);
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

        public Dtos.DtoBase CreateBackup(){
            var respuesta = new Dtos.DtoBase();
            try
            {
                var negocio = new Negocio.Gestion.CopiasDeSeguridad();
                respuesta = negocio.CreateBackup();
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

        public Dtos.DtoBase RestoreBackup(string file, long UserId){
            var respuesta = new Dtos.DtoBase();
            try
            {
                var negocio = new Negocio.Gestion.CopiasDeSeguridad();
                respuesta = negocio.RestoreBackup(file,UserId);
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

    }
}
