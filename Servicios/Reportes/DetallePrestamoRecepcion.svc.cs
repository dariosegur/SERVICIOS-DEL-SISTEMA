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
    public class DetallePrestamoRecepcion:IDetallePrestamoRecepcion
    {
        public Dtos.Reportes.Lista_View_DetallePrestamoRecepcion getDetallePrestamoRecepcion(DateTime FechaInicial, DateTime FechaFinal, int? FacultadId){
            var respuesta = new Dtos.Reportes.Lista_View_DetallePrestamoRecepcion();
            try
            {
                var negocio = new Negocio.Reportes.DetallePrestamoRecepcion();
                respuesta = negocio.getDetallePrestamoRecepcion(FechaInicial,FechaFinal,FacultadId);
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

    }
}
