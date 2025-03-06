//********************************************************
//* Archivo auto generado para Mapper View_Facultad
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_Facultad:MapperBase
{
        public Dtos.Basico.View_Facultad Mapper(Datos.View_Facultad Origen)
        {
            var Destino = new Dtos.Basico.View_Facultad();
            Destino.FacultadId=Origen.FacultadId;
            Destino.Nombre=Origen.Nombre;
            Destino.Codigo=Origen.Codigo;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.UsuarioCreaId=Origen.UsuarioCreaId;
            Destino.UsuarioCrea=Origen.UsuarioCrea;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.UsuarioModificaId=Origen.UsuarioModificaId;
            Destino.UsuarioMoifica=Origen.UsuarioMoifica;
            Destino.NombreSede=Origen.NombreSede;
            Destino.SedeId=Origen.SedeId;
            return Destino;
        }

        public Datos.View_Facultad Mapper(Dtos.Basico.View_Facultad Origen)
        {
            var Destino = new Datos.View_Facultad();
            Destino.FacultadId=Origen.FacultadId;
            Destino.Nombre=Origen.Nombre;
            Destino.Codigo=Origen.Codigo;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.UsuarioCreaId=Origen.UsuarioCreaId;
            Destino.UsuarioCrea=Origen.UsuarioCrea;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.UsuarioModificaId=Origen.UsuarioModificaId;
            Destino.UsuarioMoifica=Origen.UsuarioMoifica;
            Destino.NombreSede=Origen.NombreSede;
            Destino.SedeId=Origen.SedeId;
          return Destino;
    }
}
}
