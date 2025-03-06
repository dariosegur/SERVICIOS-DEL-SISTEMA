//********************************************************
//* Archivo auto generado para Dto View_Restriccion
//********************************************************
namespace Dtos.Basico{

using System;
using System.Collections.Generic;    

public partial class View_Restriccion:DtoBase
{
        public int RestriccionId { get; set; }
        public string Descripcion { get; set; }
        public string Texto { get; set; }
        public bool Activo { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public long CreadoId { get; set; }
        public Nullable<long> ModificadoId { get; set; }
        public string Creado { get; set; }
        public string Modificado { get; set; }
    }
}
