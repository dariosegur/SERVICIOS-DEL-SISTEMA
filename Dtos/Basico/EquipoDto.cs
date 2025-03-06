//********************************************************
//* Archivo auto generado para Dto Equipo
//********************************************************
namespace Dtos.Basico{

using System;
using System.Collections.Generic;    

public partial class Equipo:DtoBase
{
        public long EquipoId { get; set; }
        public int TipoEquipoId { get; set; }
        public string CodigoLaboratorio { get; set; }
        public string CodigoInventario { get; set; }
        public string Serial { get; set; }
        public bool Activo { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public long CreadoId { get; set; }
        public Nullable<long> ModificadoId { get; set; }
        public Nullable<int> EquipoMigraId { get; set; }
        public Nullable<long> ResponsableId { get; set; }
        public Nullable<System.DateTime> FechaCompra { get; set; }
    }
}
