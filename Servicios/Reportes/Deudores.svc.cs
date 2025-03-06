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
    public class Deudores:IDeudores
    {
        public Dtos.Reportes.Lista_View_Deudores getDeudores(){
            var respuesta = new Dtos.Reportes.Lista_View_Deudores();
            try
            {
                var negocio = new Negocio.Reportes.Deudores();
                respuesta = negocio.getDeudores();
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

    }
}
