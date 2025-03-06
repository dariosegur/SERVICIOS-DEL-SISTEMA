//********************************************************
//* Archivo auto generado para Dto View_Equipo
//********************************************************
namespace Dtos.Basico{

using System;
using System.Collections.Generic;    

public partial class View_Equipo:DtoBase
{
        public long EquipoId { get; set; }
        public long CreadoId { get; set; }
        public Nullable<long> ModificadoId { get; set; }
        public int TipoEquipoId { get; set; }
        public string CodigoInventario { get; set; }
        public string CodigoLaboratorio { get; set; }
        public string Serial { get; set; }
        public Nullable<long> UsuarioResponsableId { get; set; }
        public string UsuarioResponsable { get; set; }
        public string UsuarioResponsableCodigoBarras { get; set; }
        public string TipoEquipo { get; set; }
        public string Marca { get; set; }
        public string Referencia { get; set; }
        public bool Activo { get; set; }
        public string Creado { get; set; }
        public System.DateTime FechaCreado { get; set; }
        public Nullable<System.DateTime> FechaModificado { get; set; }
        public string Modificado { get; set; }
        public Nullable<System.DateTime> FechaCompra { get; set; }
        public Nullable<long> UsuarioInventarioResponsableId { get; set; }
        public string UsuarioInventarioResponsable { get; set; }
        public string UsuarioInventarioResponsableCodigoBarras { get; set; }
    }
}
