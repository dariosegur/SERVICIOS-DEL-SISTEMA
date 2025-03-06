//********************************************************
//* Archivo auto generado para Dto PrestamoRecepcion
//********************************************************
namespace Dtos.Registro{

using System;
using System.Collections.Generic;    

public partial class PrestamoRecepcion:DtoBase
{
        public long PrestamoRecepcionId { get; set; }
        public long UsuarioId { get; set; }
        public long EquipoId { get; set; }
        public Nullable<int> FacultadId { get; set; }
        public Nullable<int> SemestreBasico { get; set; }
        public long AuxilliarPrestaId { get; set; }
        public System.DateTime FechaPrestamo { get; set; }
        public bool PrestamoMaual { get; set; }
        public Nullable<long> AuxilliarRecibeId { get; set; }
        public Nullable<System.DateTime> FechaRecepcion { get; set; }
        public Nullable<bool> RecepcionManual { get; set; }
    }
}
