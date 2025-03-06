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
    public class EstadisticasPrestamoEquipos:IEstadisticasPrestamoEquipos
    {
        public Dtos.Reportes.Lista_View_EstadisticasPrestamoEquipos getEstadisticasPrestamoEquipos(DateTime? FechaInicial, DateTime? FechaFinal){
            var respuesta = new Dtos.Reportes.Lista_View_EstadisticasPrestamoEquipos();
            try
            {
                var negocio = new Negocio.Reportes.EstadisticasPrestamoEquipos();
                respuesta = negocio.getEstadisticasPrestamoEquipos(FechaInicial,FechaFinal);
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

    }
}
