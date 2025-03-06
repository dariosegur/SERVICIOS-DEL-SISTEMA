//********************************************************
//* Archivo auto generado para Dto View_EstadoMultas
//********************************************************
namespace Dtos.Reportes{

using System;
using System.Collections.Generic;    

public partial class View_EstadoMultas:DtoBase
{
        public long MultaId { get; set; }
        public long DeudorId { get; set; }
        public string Deudor { get; set; }
        public string TipoDeudor { get; set; }
        public long UsuarioCreaId { get; set; }
        public string UsuarioCrea { get; set; }
        public System.DateTime FechaCrea { get; set; }
        public Nullable<long> UsuarioModificaId { get; set; }
        public string UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public int EstadoMultaId { get; set; }
        public string EstadoMulta { get; set; }
        public int Valor { get; set; }
        public string Descripcion { get; set; }
        public string DeudorDocumento { get; set; }
    }
}
