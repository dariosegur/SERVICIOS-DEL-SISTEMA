using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicios.Seguridad
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISeguridad" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISeguridad
    {
        [OperationContract]
        //Seguridad
        Dtos.Seguridad.View_UsuarioAutentica Validar(string User, string Password);
        [OperationContract]
        //Seguridad
        Dtos.Seguridad.Lista_View_Menu MenuUsuario(long UsuarioId);
        [OperationContract]
        //Seguridad
        Dtos.Seguridad.Lista_View_Menu MenuReportesUsuario(long UsuarioId);
        [OperationContract]
        //Seguridad
        Dtos.Seguridad.Lista_View_Menu MenuPrincipalUsuario(long UsuarioId);
        [OperationContract]
        //Seguridad
        Dtos.Seguridad.Lista_View_Menu MenuGestionUsuario(long UsuarioId);
    }
}
