//********************************************************
//* Archivo auto generado para Dto View_AnotacionesActivas
//********************************************************
namespace Dtos.Registro{

using System;
using System.Collections.Generic;    

public partial class View_AnotacionesActivas:DtoBase
{
        public long AnotacionId { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string NombreCreador { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string NombreModifica { get; set; }
        public Nullable<long> UsuarioId { get; set; }
    }
}
