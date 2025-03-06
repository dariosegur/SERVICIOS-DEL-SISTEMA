//********************************************************
//* Archivo auto generado para Dto View_DetallePrestamoRecepcion
//********************************************************
namespace Dtos.Reportes{

using System;
using System.Collections.Generic;    

public partial class View_DetallePrestamoRecepcion:DtoBase
{
        public string Documento { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Facultad { get; set; }
        public string Rol { get; set; }
        public string CodigoEquipo { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Referencia { get; set; }
        public Nullable<int> SemestreBasico { get; set; }
        public bool PrestamoMaual { get; set; }
        public System.DateTime FechaPrestamo { get; set; }
        public string PrestadoPor { get; set; }
        public Nullable<bool> RecepcionManual { get; set; }
        public Nullable<System.DateTime> FechaRecepcion { get; set; }
        public string RecibidoPor { get; set; }
        public Nullable<int> FacultadId { get; set; }
        public long PrestamoRecepcionId { get; set; }
    }
}
