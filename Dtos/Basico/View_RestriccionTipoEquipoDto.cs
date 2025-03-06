//********************************************************
//* Archivo auto generado para Dto View_RestriccionTipoEquipo
//********************************************************
namespace Dtos.Basico{

using System;
using System.Collections.Generic;    

public partial class View_RestriccionTipoEquipo:DtoBase
{
        public int TipoEquipoId { get; set; }
        public int RestriccionId { get; set; }
        public int RestriccionTipoEquipoId { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> Activa { get; set; }
    }
}
