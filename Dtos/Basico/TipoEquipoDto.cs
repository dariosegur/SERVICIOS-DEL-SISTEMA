//********************************************************
//* Archivo auto generado para Dto TipoEquipo
//********************************************************
namespace Dtos.Basico{

using System;
using System.Collections.Generic;    

public partial class TipoEquipo:DtoBase
{
        public int TipoEquipoId { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Referencia { get; set; }
        public bool Activo { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public long CreadoId { get; set; }
        public Nullable<long> ModificadoId { get; set; }
    }
}
