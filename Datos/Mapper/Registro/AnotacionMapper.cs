//********************************************************
//* Archivo auto generado para Mapper Anotacion
//********************************************************
namespace Datos.Mapper.Registro
{

using System;
using System.Collections.Generic;    

public partial class Anotacion:MapperBase
{
        public Dtos.Registro.Anotacion Mapper(Datos.Anotacion Origen)
        {
            var Destino = new Dtos.Registro.Anotacion();
            Destino.AnotacionId=Origen.AnotacionId;
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.EstadoAnotacionId=Origen.EstadoAnotacionId;
            return Destino;
        }

        public Datos.Anotacion Mapper(Dtos.Registro.Anotacion Origen)
        {
            var Destino = new Datos.Anotacion();
            Destino.AnotacionId=Origen.AnotacionId;
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.EstadoAnotacionId=Origen.EstadoAnotacionId;
          return Destino;
    }
}
}
