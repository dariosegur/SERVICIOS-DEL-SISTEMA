namespace Dtos.Gestion
{
    using System;
    using System.Collections.Generic;

    public partial class InformacionInactivar : DtoBase
    {
        public int EstudiantesTotal { get; set; }
        public int EstudiantesActivos { get; set; }
        public int EstudiantesInactivos { get; set; }
    }
}
