//********************************************************
//* Archivo auto generado para Dto View_EstadisticasPrestamoEquipos
//********************************************************
namespace Dtos.Reportes{

using System;
using System.Collections.Generic;    

public partial class View_EstadisticasPrestamoEquipos:DtoBase
{
        public int TipoEquipoId { get; set; }
        public long EquipoId { get; set; }
        public string TipoEquipo { get; set; }
        public string Marca { get; set; }
        public string Referencia { get; set; }
        public Nullable<bool> TipoEquipoActivo { get; set; }
        public Nullable<int> PrestamosTipoEquipo { get; set; }
        public string CodigoLaboratorio { get; set; }
        public Nullable<int> PrestamosEquipo { get; set; }
        public bool EquipoActivo { get; set; }
        public string Serial { get; set; }
        public string CodigoInventario { get; set; }
    }
}
