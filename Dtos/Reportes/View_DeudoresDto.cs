//********************************************************
//* Archivo auto generado para Dto View_Deudores
//********************************************************
namespace Dtos.Reportes{

using System;
using System.Collections.Generic;    

public partial class View_Deudores:DtoBase
{
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Facultad { get; set; }
        public int Valor { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string CreadaPor { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string ModificadaPor { get; set; }
        public string Codigo { get; set; }
        public long MultaId { get; set; }
    }
}
