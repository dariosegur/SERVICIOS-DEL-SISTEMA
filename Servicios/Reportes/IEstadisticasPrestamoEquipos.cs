using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicios.Reportes
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPrestamoRecepcion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEstadisticasPrestamoEquipos
    {
        [OperationContract]
        //Reportes.EstadisticasPrestamoEquipos
        Dtos.Reportes.Lista_View_EstadisticasPrestamoEquipos getEstadisticasPrestamoEquipos(DateTime? FechaInicial, DateTime? FechaFinal);
    }
}
