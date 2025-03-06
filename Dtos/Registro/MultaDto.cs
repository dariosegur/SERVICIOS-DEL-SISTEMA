//********************************************************
//* Archivo auto generado para Dto Multa
//********************************************************
namespace Dtos.Registro{

using System;
using System.Collections.Generic;    

public partial class Multa:DtoBase
{
        public long MultaId { get; set; }
        public long DeudorId { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public long CreadoId { get; set; }
        public Nullable<long> ModificadoId { get; set; }
        public int EstadoMultaId { get; set; }
    }
}
