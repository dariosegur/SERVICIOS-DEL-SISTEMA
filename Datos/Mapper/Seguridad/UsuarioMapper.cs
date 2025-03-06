//********************************************************
//* Archivo auto generado para Mapper Usuario
//********************************************************
namespace Datos.Mapper.Seguridad
{

using System;
using System.Collections.Generic;    

public partial class Usuario:MapperBase
{
        public Dtos.Seguridad.Usuario Mapper(Datos.Usuario Origen)
        {
            var Destino = new Dtos.Seguridad.Usuario();
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.TipoUsuarioId=Origen.TipoUsuarioId;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.Documento=Origen.Documento;
            Destino.BarCode=Origen.BarCode;
            Destino.Password=Origen.Password;
            Destino.PasswordCoded=Origen.PasswordCoded;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.FacultadId=Origen.FacultadId;
            Destino.SemestreBasico=Origen.SemestreBasico;
            Destino.Token=Origen.Token;
            Destino.TokenDate=Origen.TokenDate;
            Destino.Codigo=Origen.Codigo;
            Destino.CorreoElectronico=Origen.CorreoElectronico;
            return Destino;
        }

        public Datos.Usuario Mapper(Dtos.Seguridad.Usuario Origen)
        {
            var Destino = new Datos.Usuario();
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.TipoUsuarioId=Origen.TipoUsuarioId;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.Documento=Origen.Documento;
            Destino.BarCode=Origen.BarCode;
            Destino.Password=Origen.Password;
            Destino.PasswordCoded=Origen.PasswordCoded;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.FacultadId=Origen.FacultadId;
            Destino.SemestreBasico=Origen.SemestreBasico;
            Destino.Token=Origen.Token;
            Destino.TokenDate=Origen.TokenDate;
            Destino.Codigo=Origen.Codigo;
            Destino.CorreoElectronico=Origen.CorreoElectronico;
          return Destino;
    }
}
}
