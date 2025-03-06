namespace Dtos.Gestion
{
    using System;
    using System.Collections.Generic;

    public partial class InformacionCopiasDeSeguridad : DtoBase
    {
        public string Path { get; set; }
        public string[] Archivos { get; set; }
        public bool Default { get; set; }
    }
}
