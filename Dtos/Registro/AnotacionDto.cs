//********************************************************
//* Archivo auto generado para Dto Anotacion
//********************************************************
namespace Dtos.Registro{

using System;
using System.Collections.Generic;    

public partial class Anotacion:DtoBase
{
        public long AnotacionId { get; set; }
        public long UsuarioId { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public long CreadoId { get; set; }
        public Nullable<long> ModificadoId { get; set; }
        public int EstadoAnotacionId { get; set; }
    }
}
