//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sede
    {
        public Sede()
        {
            this.Facultads = new HashSet<Facultad>();
        }
    
        public int SedeId { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public long CreadoId { get; set; }
        public Nullable<long> ModificadoId { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        public virtual ICollection<Facultad> Facultads { get; set; }
    }
}
