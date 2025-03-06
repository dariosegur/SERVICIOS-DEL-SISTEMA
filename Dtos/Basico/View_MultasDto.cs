//********************************************************
//* Archivo auto generado para Dto View_Multas
//********************************************************
namespace Dtos.Basico{

using System;
using System.Collections.Generic;    

public partial class View_Multas:DtoBase
{
        public long MultaId { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public long DeudorId { get; set; }
        public string Deudor { get; set; }
        public long CreadoId { get; set; }
        public string NombreCreador { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<long> ModificadoId { get; set; }
        public string NombreModifica { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public int EstadoMultaId { get; set; }
        public string EstadoMulta { get; set; }
    }
}
