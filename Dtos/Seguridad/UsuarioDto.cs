//********************************************************
//* Archivo auto generado para Dto Usuario
//********************************************************
namespace Dtos.Seguridad{

using System;
using System.Collections.Generic;    

public partial class Usuario:DtoBase
{
        public long UsuarioId { get; set; }
        public int TipoUsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Documento { get; set; }
        public string BarCode { get; set; }
        public byte[] Password { get; set; }
        public bool PasswordCoded { get; set; }
        public bool Activo { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public long CreadoId { get; set; }
        public Nullable<long> ModificadoId { get; set; }
        public Nullable<int> FacultadId { get; set; }
        public Nullable<int> SemestreBasico { get; set; }
        public byte[] Token { get; set; }
        public Nullable<System.DateTime> TokenDate { get; set; }
        public string Codigo { get; set; }
        public string CorreoElectronico { get; set; }
    }
}
