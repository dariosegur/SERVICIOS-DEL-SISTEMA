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
    public class Mantenimiento:IMantenimiento
    {
        public Dtos.Gestion.InformacionEliminarEstudiantesInactivos getInformacioneliminarEstudiantes(long UsuarioId){
            var respuesta = new Dtos.Gestion.InformacionEliminarEstudiantesInactivos();
            try
            {
                var negocio = new Negocio.Gestion.Mantenimiento();
                respuesta = negocio.getInformacioneliminarEstudiantes(UsuarioId);
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

        public Dtos.DtoBase EliminarEstudiantesInactivos(long UsuarioId){
            var respuesta = new Dtos.DtoBase();
            try
            {
                var negocio = new Negocio.Gestion.Mantenimiento();
                respuesta = negocio.EliminarEstudiantesInactivos(UsuarioId);
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

    }
}
