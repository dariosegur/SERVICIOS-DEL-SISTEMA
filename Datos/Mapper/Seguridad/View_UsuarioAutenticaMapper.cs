//********************************************************
//* Archivo auto generado para Mapper View_UsuarioAutentica
//********************************************************
namespace Datos.Mapper.Seguridad
{

using System;
using System.Collections.Generic;    

public partial class View_UsuarioAutentica:MapperBase
{
        public Dtos.Seguridad.View_UsuarioAutentica Mapper(Datos.View_UsuarioAutentica Origen)
        {
            var Destino = new Dtos.Seguridad.View_UsuarioAutentica();
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.TipoUsuarioId=Origen.TipoUsuarioId;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.BarCode=Origen.BarCode;
            Destino.Documento=Origen.Documento;
            Destino.FacultadId=Origen.FacultadId;
            Destino.Codigo=Origen.Codigo;
            return Destino;
        }

        public Datos.View_UsuarioAutentica Mapper(Dtos.Seguridad.View_UsuarioAutentica Origen)
        {
            var Destino = new Datos.View_UsuarioAutentica();
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.TipoUsuarioId=Origen.TipoUsuarioId;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.BarCode=Origen.BarCode;
            Destino.Documento=Origen.Documento;
            Destino.FacultadId=Origen.FacultadId;
            Destino.Codigo=Origen.Codigo;
          return Destino;
    }
}
}
