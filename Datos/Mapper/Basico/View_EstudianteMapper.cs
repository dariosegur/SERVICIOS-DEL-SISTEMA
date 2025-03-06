//********************************************************
//* Archivo auto generado para Mapper View_Estudiante
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_Estudiante:MapperBase
{
        public Dtos.Basico.View_Estudiante Mapper(Datos.View_Estudiante Origen)
        {
            var Destino = new Dtos.Basico.View_Estudiante();
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.FacultadId=Origen.FacultadId;
            Destino.Documento=Origen.Documento;
            Destino.Barcode=Origen.Barcode;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.FacultadNombre=Origen.FacultadNombre;
            Destino.Activo=Origen.Activo;
            Destino.Codigo=Origen.Codigo;
            Destino.UsuarioCreaId=Origen.UsuarioCreaId;
            Destino.UsuarioModificaId=Origen.UsuarioModificaId;
            Destino.SemestreBasico=Origen.SemestreBasico;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.Creado=Origen.Creado;
            Destino.Modificado=Origen.Modificado;
            return Destino;
        }

        public Datos.View_Estudiante Mapper(Dtos.Basico.View_Estudiante Origen)
        {
            var Destino = new Datos.View_Estudiante();
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.FacultadId=Origen.FacultadId;
            Destino.Documento=Origen.Documento;
            Destino.Barcode=Origen.Barcode;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.FacultadNombre=Origen.FacultadNombre;
            Destino.Activo=Origen.Activo;
            Destino.Codigo=Origen.Codigo;
            Destino.UsuarioCreaId=Origen.UsuarioCreaId;
            Destino.UsuarioModificaId=Origen.UsuarioModificaId;
            Destino.SemestreBasico=Origen.SemestreBasico;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.Creado=Origen.Creado;
            Destino.Modificado=Origen.Modificado;
          return Destino;
    }
}
}
