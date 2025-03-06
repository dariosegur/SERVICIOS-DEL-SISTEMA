//********************************************************
//* Archivo extención para Dto View_PrestamoRecepcion
//********************************************************
namespace Dtos.Registro
{

    using System;
    using System.Collections.Generic;

    public partial class View_PrestamoRecepcion : DtoBase
    {
        public List<Dtos.Registro.View_MultasActivas> Multas { get; set; }
        public List<Dtos.Registro.View_AnotacionesActivas> Anotaciones { get; set; }
        public List<Dtos.Registro.View_EquiposACargo> Equipos { get; set; }
    }
}
