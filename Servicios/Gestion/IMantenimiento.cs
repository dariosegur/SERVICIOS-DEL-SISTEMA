using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Servicios.Gestion
{
    [ServiceContract]
    public interface IMantenimiento
    {

        [OperationContract]
        //Gestion.Mantenimiento
        Dtos.Gestion.InformacionEliminarEstudiantesInactivos getInformacioneliminarEstudiantes(long UsuarioId);

        [OperationContract]
        //Gestion.Mantenimiento
        Dtos.DtoBase EliminarEstudiantesInactivos(long UsuarioId);
    }
}
