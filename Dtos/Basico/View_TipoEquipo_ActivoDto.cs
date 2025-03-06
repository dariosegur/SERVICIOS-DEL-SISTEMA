//********************************************************
//* Archivo auto generado para Dto View_TipoEquipo_Activo
//********************************************************
namespace Dtos.Basico{

using System;
using System.Collections.Generic;    

public partial class View_TipoEquipo_Activo:DtoBase
{
        public int TipoEquipoId { get; set; }
        public long CreadoId { get; set; }
        public Nullable<long> ModificadoId { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Referencia { get; set; }
        public bool Activo { get; set; }
        public string Creado { get; set; }
        public System.DateTime FechaCreado { get; set; }
        public Nullable<System.DateTime> FechaModificado { get; set; }
        public string Modificado { get; set; }
        public string TextoCorto { get; set; }
    }
}
