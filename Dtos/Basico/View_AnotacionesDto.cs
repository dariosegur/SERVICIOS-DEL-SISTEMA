//********************************************************
//* Archivo auto generado para Dto View_Anotaciones
//********************************************************
namespace Dtos.Basico{

using System;
using System.Collections.Generic;    

public partial class View_Anotaciones:DtoBase
{
        public long AnotacionId { get; set; }
        public string Descripcion { get; set; }
        public long UsuarioId { get; set; }
        public string Usuario { get; set; }
        public long CreadoId { get; set; }
        public string NombreCreador { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<long> ModificadoId { get; set; }
        public string NombreModifica { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public int EstadoAnotacionId { get; set; }
        public string EstadoAnotacion { get; set; }
    }
}
