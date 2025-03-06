//********************************************************
//* Archivo auto generado para Dto View_UsuarioAutentica
//********************************************************
namespace Dtos.Seguridad{

using System;
using System.Collections.Generic;    

public partial class View_UsuarioAutentica:DtoBase
{
        public long UsuarioId { get; set; }
        public int TipoUsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string BarCode { get; set; }
        public string Documento { get; set; }
        public Nullable<int> FacultadId { get; set; }
        public string Codigo { get; set; }
    }
}
