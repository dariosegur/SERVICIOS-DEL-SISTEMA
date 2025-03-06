//********************************************************
//* Archivo auto generado para Dto View_UsuarioPrestamo
//********************************************************
namespace Dtos.Basico{

using System;
using System.Collections.Generic;    

public partial class View_UsuarioPrestamo:DtoBase
{
        public bool Activo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Documento { get; set; }
        public string Facultad { get; set; }
        public string BarCode { get; set; }
        public long UsuarioId { get; set; }
    }
}
