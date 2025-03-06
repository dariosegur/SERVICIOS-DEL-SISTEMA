//********************************************************
//* Archivo auto generado para Mapper View_Docente
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_Docente:MapperBase
{
        public Dtos.Basico.View_Docente Mapper(Datos.View_Docente Origen)
        {
            var Destino = new Dtos.Basico.View_Docente();
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.FacultadId=Origen.FacultadId;
            Destino.UsuarioCreaId=Origen.UsuarioCreaId;
            Destino.UsuarioModificaId=Origen.UsuarioModificaId;
            Destino.Documento=Origen.Documento;
            Destino.Barcode=Origen.Barcode;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.FacultadNombre=Origen.FacultadNombre;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.Creado=Origen.Creado;
            Destino.Modificado=Origen.Modificado;
            Destino.CorreoElectronico=Origen.CorreoElectronico;
            return Destino;
        }

        public Datos.View_Docente Mapper(Dtos.Basico.View_Docente Origen)
        {
            var Destino = new Datos.View_Docente();
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.FacultadId=Origen.FacultadId;
            Destino.UsuarioCreaId=Origen.UsuarioCreaId;
            Destino.UsuarioModificaId=Origen.UsuarioModificaId;
            Destino.Documento=Origen.Documento;
            Destino.Barcode=Origen.Barcode;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.FacultadNombre=Origen.FacultadNombre;
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
