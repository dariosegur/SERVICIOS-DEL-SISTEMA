//********************************************************
//* Archivo auto generado para Dto View_PrestamoRecepcion
//********************************************************
namespace Dtos.Registro{

using System;
using System.Collections.Generic;    

public partial class View_PrestamoRecepcion:DtoBase
{
        public long UsuarioId { get; set; }
        public int TipoUsuarioId { get; set; }
        public string TipoUsuario { get; set; }
        public string BarCode { get; set; }
        public Nullable<int> FacultadId { get; set; }
        public Nullable<int> SemestreBasico { get; set; }
        public Nullable<int> nAnotaciones { get; set; }
        public Nullable<int> nMultas { get; set; }
        public Nullable<int> nEquipos { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Facultad { get; set; }
        public bool Activo { get; set; }
    }
}
