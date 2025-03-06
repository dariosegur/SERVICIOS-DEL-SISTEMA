using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Servicios.Gestion
{
    [ServiceContract]
    public interface ICopiasDeSeguridad
    {

        [OperationContract]
        //Gestion.CopiasDeSeguridad
        Dtos.Gestion.InformacionCopiasDeSeguridad getInformacionBackup(long UsuarioId);
        [OperationContract]
        //Gestion.CopiasDeSeguridad
        Dtos.DtoBase CreateBackup();
        [OperationContract]
        //Gestion.CopiasDeSeguridad
        Dtos.DtoBase RestoreBackup(string file, long UserId);

    }
}
