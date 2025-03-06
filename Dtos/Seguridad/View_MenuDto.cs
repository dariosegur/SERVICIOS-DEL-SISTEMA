//********************************************************
//* Archivo auto generado para Dto View_Menu
//********************************************************
namespace Dtos.Seguridad{

using System;
using System.Collections.Generic;    

public partial class View_Menu:DtoBase
{
        public int MenuId { get; set; }
        public bool Activo { get; set; }
        public string Texto { get; set; }
        public string Imagen { get; set; }
        public string Destino { get; set; }
        public int Orden { get; set; }
        public long CreaId { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<long> ModificaId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string Grupo { get; set; }
    }
}
