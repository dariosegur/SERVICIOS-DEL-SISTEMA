//********************************************************
//* Archivo auto generado para Mapper View_TipoEquipo
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_TipoEquipo:MapperBase
{
        public Dtos.Basico.View_TipoEquipo Mapper(Datos.View_TipoEquipo Origen)
        {
            var Destino = new Dtos.Basico.View_TipoEquipo();
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Marca=Origen.Marca;
            Destino.Referencia=Origen.Referencia;
            Destino.Activo=Origen.Activo;
            Destino.Creado=Origen.Creado;
            Destino.FechaCreado=Origen.FechaCreado;
            Destino.FechaModificado=Origen.FechaModificado;
            Destino.Modificado=Origen.Modificado;
            return Destino;
        }

        public Datos.View_TipoEquipo Mapper(Dtos.Basico.View_TipoEquipo Origen)
        {
            var Destino = new Datos.View_TipoEquipo();
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Marca=Origen.Marca;
            Destino.Referencia=Origen.Referencia;
            Destino.Activo=Origen.Activo;
            Destino.Creado=Origen.Creado;
            Destino.FechaCreado=Origen.FechaCreado;
            Destino.FechaModificado=Origen.FechaModificado;
            Destino.Modificado=Origen.Modificado;
          return Destino;
    }
}
}
