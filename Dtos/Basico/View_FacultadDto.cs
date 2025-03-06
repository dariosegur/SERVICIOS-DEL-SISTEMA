//********************************************************
//* Archivo auto generado para Dto View_Facultad
//********************************************************
namespace Dtos.Basico{

using System;
using System.Collections.Generic;    

public partial class View_Facultad:DtoBase
{
        public int FacultadId { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public bool Activo { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public long UsuarioCreaId { get; set; }
        public string UsuarioCrea { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<long> UsuarioModificaId { get; set; }
        public string UsuarioMoifica { get; set; }
        public string NombreSede { get; set; }
        public Nullable<int> SedeId { get; set; }
    }
}
