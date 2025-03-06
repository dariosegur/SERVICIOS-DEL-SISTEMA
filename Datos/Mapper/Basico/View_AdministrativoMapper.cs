//********************************************************
//* Archivo auto generado para Mapper View_Administrativo
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_Administrativo:MapperBase
{
        public Dtos.Basico.View_Administrativo Mapper(Datos.View_Administrativo Origen)
        {
            var Destino = new Dtos.Basico.View_Administrativo();
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.UsuarioCreaId=Origen.UsuarioCreaId;
            Destino.UsuarioModificaId=Origen.UsuarioModificaId;
            Destino.Documento=Origen.Documento;
            Destino.Barcode=Origen.Barcode;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.Password=Origen.Password;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.Creado=Origen.Creado;
            Destino.Modificado=Origen.Modificado;
            Destino.CorreoElectronico=Origen.CorreoElectronico;
            return Destino;
        }

        public Datos.View_Administrativo Mapper(Dtos.Basico.View_Administrativo Origen)
        {
            var Destino = new Datos.View_Administrativo();
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.UsuarioCreaId=Origen.UsuarioCreaId;
            Destino.UsuarioModificaId=Origen.UsuarioModificaId;
            Destino.Documento=Origen.Documento;
            Destino.Barcode=Origen.Barcode;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.Password=Origen.Password;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.Creado=Origen.Creado;
            Destino.Modificado=Origen.Modificado;
            Destino.CorreoElectronico=Origen.CorreoElectronico;
          return Destino;
    }
}
}
