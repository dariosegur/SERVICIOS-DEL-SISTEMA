//********************************************************
//* Archivo auto generado para Dto View_Historial_Estudiante
//********************************************************
namespace Dtos.Basico{

using System;
using System.Collections.Generic;    

public partial class View_Historial_Estudiante:DtoBase
{
        public long PrestamorecepcionId { get; set; }
        public long UsuarioId { get; set; }
        public long EquipoId { get; set; }
        public Nullable<int> TipoEquipoId { get; set; }
        public System.DateTime FechaPrestamo { get; set; }
        public Nullable<System.DateTime> FechaRecepcion { get; set; }
        public string CodigoInventario { get; set; }
        public string CodigoLaboratorio { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
    }
}
