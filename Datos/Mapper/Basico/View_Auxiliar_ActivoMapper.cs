//********************************************************
//* Archivo auto generado para Mapper View_Auxiliar_Activo
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_Auxiliar_Activo:MapperBase
{
        public Dtos.Basico.View_Auxiliar_Activo Mapper(Datos.View_Auxiliar_Activo Origen)
        {
            var Destino = new Dtos.Basico.View_Auxiliar_Activo();
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
            Destino.TextoCorto=Origen.TextoCorto;
            Destino.CorreoElectronico=Origen.CorreoElectronico;
            return Destino;
        }

        public Datos.View_Auxiliar_Activo Mapper(Dtos.Basico.View_Auxiliar_Activo Origen)
        {
            var Destino = new Datos.View_Auxiliar_Activo();
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
            Destino.TextoCorto=Origen.TextoCorto;
            Destino.CorreoElectronico=Origen.CorreoElectronico;
          return Destino;
    }
}
}
