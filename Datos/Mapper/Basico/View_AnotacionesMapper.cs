//********************************************************
//* Archivo auto generado para Mapper View_Anotaciones
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_Anotaciones:MapperBase
{
        public Dtos.Basico.View_Anotaciones Mapper(Datos.View_Anotaciones Origen)
        {
            var Destino = new Dtos.Basico.View_Anotaciones();
            Destino.AnotacionId=Origen.AnotacionId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.Usuario=Origen.Usuario;
            Destino.CreadoId=Origen.CreadoId;
            Destino.NombreCreador=Origen.NombreCreador;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.NombreModifica=Origen.NombreModifica;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.EstadoAnotacionId=Origen.EstadoAnotacionId;
            Destino.EstadoAnotacion=Origen.EstadoAnotacion;
            return Destino;
        }

        public Datos.View_Anotaciones Mapper(Dtos.Basico.View_Anotaciones Origen)
        {
            var Destino = new Datos.View_Anotaciones();
            Destino.AnotacionId=Origen.AnotacionId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.Usuario=Origen.Usuario;
            Destino.CreadoId=Origen.CreadoId;
            Destino.NombreCreador=Origen.NombreCreador;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.NombreModifica=Origen.NombreModifica;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.EstadoAnotacionId=Origen.EstadoAnotacionId;
            Destino.EstadoAnotacion=Origen.EstadoAnotacion;
          return Destino;
    }
}
}
