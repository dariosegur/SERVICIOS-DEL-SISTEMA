//********************************************************
//* Archivo auto generado para Dto View_Historial
//********************************************************
namespace Dtos.Registro{

using System;
using System.Collections.Generic;    

public partial class View_Historial:DtoBase
{
        public long PrestamorecepcionId { get; set; }
        public long UsuarioId { get; set; }
        public long AuxilliarPrestaId { get; set; }
        public Nullable<long> AuxilliarRecibeId { get; set; }
        public long EquipoId { get; set; }
        public Nullable<int> TipoEquipoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string AuxiliarPresta { get; set; }
        public string AuxiliarRecibe { get; set; }
        public System.DateTime FechaPrestamo { get; set; }
        public Nullable<System.DateTime> FechaRecepcion { get; set; }
        public string CodigoInventario { get; set; }
        public string CodigoLaboratorio { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
    }
}
