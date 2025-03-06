namespace Dtos.Gestion
{
    using System;
    using System.Collections.Generic;

    public partial class InformacionEliminarEstudiantesInactivos : DtoBase
    {
        public int EstudiantesInactivos { get; set; }
        public int EstudiantesCandidatosEliminar { get; set; }
        public int RegistrosHistorialEliminar { get; set; }
    }
}
