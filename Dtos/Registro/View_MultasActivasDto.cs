//********************************************************
//* Archivo auto generado para Dto View_MultasActivas
//********************************************************
namespace Dtos.Registro{

using System;
using System.Collections.Generic;    

public partial class View_MultasActivas:DtoBase
{
        public long MultaId { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public string NombreCreador { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string NombreModifica { get; set; }
        public long DeudorId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
    }
}
