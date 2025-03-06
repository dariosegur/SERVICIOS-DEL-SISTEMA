//********************************************************
//* Archivo auto generado para Dto View_Estudiante
//********************************************************
namespace Dtos.Basico{

using System;
using System.Collections.Generic;    

public partial class View_Estudiante:DtoBase
{
        public long UsuarioId { get; set; }
        public Nullable<int> FacultadId { get; set; }
        public string Documento { get; set; }
        public string Barcode { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string FacultadNombre { get; set; }
        public bool Activo { get; set; }
        public string Codigo { get; set; }
        public Nullable<long> UsuarioCreaId { get; set; }
        public Nullable<long> UsuarioModificaId { get; set; }
        public Nullable<int> SemestreBasico { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string Creado { get; set; }
        public string Modificado { get; set; }
    }
}
