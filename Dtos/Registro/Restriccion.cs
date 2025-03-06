//********************************************************
//* Archivo extención para Dto View_PrestamoRecepcion
//********************************************************
namespace Dtos.Registro
{

    using System;
    using System.Collections.Generic;

    public partial class RestriccionDto : DtoBase
    {
        public List<Dtos.Basico.Restriccion> Restricciones { get; set; }
    }
}
