//********************************************************
//* Archivo auto generado para Dto Facultad
//********************************************************
namespace Dtos.Basico{

using System;
using System.Collections.Generic;    

public partial class Facultad:DtoBase
{
        public int FacultadId { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public bool Activo { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public long CreadoId { get; set; }
        public Nullable<long> ModificadoId { get; set; }
        public Nullable<int> SedeId { get; set; }
    }
}
