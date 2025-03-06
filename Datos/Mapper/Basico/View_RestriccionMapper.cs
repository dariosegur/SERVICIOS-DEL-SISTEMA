//********************************************************
//* Archivo auto generado para Mapper View_Restriccion
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_Restriccion:MapperBase
{
        public Dtos.Basico.View_Restriccion Mapper(Datos.View_Restriccion Origen)
        {
            var Destino = new Dtos.Basico.View_Restriccion();
            Destino.RestriccionId=Origen.RestriccionId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Texto=Origen.Texto;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.Creado=Origen.Creado;
            Destino.Modificado=Origen.Modificado;
            return Destino;
        }

        public Datos.View_Restriccion Mapper(Dtos.Basico.View_Restriccion Origen)
        {
            var Destino = new Datos.View_Restriccion();
            Destino.RestriccionId=Origen.RestriccionId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Texto=Origen.Texto;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.Creado=Origen.Creado;
            Destino.Modificado=Origen.Modificado;
          return Destino;
    }
}
}
