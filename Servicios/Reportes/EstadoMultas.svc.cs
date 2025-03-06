using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dtos;
using Dtos.Basico;

namespace Servicios.Reportes
{
    public class EstadoMultas:IEstadoMultas
    {
        public Dtos.Reportes.Lista_View_EstadoMultas getEstadoMultas(DateTime? FechaInicial, DateTime? FechaFinal){
            var respuesta = new Dtos.Reportes.Lista_View_EstadoMultas();
            try
            {
                var negocio = new Negocio.Reportes.EstadoMultas();
                respuesta = negocio.getEstadoMultas(FechaInicial,FechaFinal);
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

    }
}
