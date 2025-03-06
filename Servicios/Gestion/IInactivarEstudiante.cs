using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Servicios.Gestion
{
    [ServiceContract]
    public interface IInactivarEstudiante
    {

        [OperationContract]
        //Gestion.InactivarEstudiante
        Dtos.Gestion.Lista_View_Parametros getParametros(string FiltroTexto, int UsuarioId);

        [OperationContract]
        //Gestion.InactivarEstudiante
        Dtos.Gestion.InformacionInactivar getInformacionInactivar();

        [OperationContract]
        //Gestion.InactivarEstudiante
        Dtos.DtoBase InactivarEstudiantes(long UsuarioId);

        [OperationContract]
        //Gestion.InactivarEstudiante
        Dtos.DtoBase ActivarEstudiantes(long UsuarioId, long UsuarioIdActivar);
    }
}
