//********************************************************
//* Archivo auto generado para Mapper Restriccion
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class Restriccion:MapperBase
{
        public Dtos.Basico.Restriccion Mapper(Datos.Restriccion Origen)
        {
            var Destino = new Dtos.Basico.Restriccion();
            Destino.RestriccionId=Origen.RestriccionId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.Texto=Origen.Texto;
            return Destino;
        }

        public Datos.Restriccion Mapper(Dtos.Basico.Restriccion Origen)
        {
            var Destino = new Datos.Restriccion();
            Destino.RestriccionId=Origen.RestriccionId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.Texto=Origen.Texto;
          return Destino;
    }
}
}
