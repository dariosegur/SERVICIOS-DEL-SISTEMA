using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dtos;
using Dtos.Basico;

namespace Servicios.VisorEquipos
{
    public class VisorEquipos:IVisorEquipos
    {
        public Dtos.Basico.Lista_View_Equipo getEquiposPrestados(){
            var respuesta = new Dtos.Basico.Lista_View_Equipo();
            try
            {
                var negocio = new Negocio.VisorEquipos.VisorEquipos();
                respuesta = negocio.getEquiposPrestados();
            }
            catch (Exception ex)
            {
                ErrorServiceHandle.ExtractError(respuesta, ex);
            }
            return respuesta;
        }

    }
}
