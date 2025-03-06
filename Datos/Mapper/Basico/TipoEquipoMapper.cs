//********************************************************
//* Archivo auto generado para Mapper TipoEquipo
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class TipoEquipo:MapperBase
{
        public Dtos.Basico.TipoEquipo Mapper(Datos.TipoEquipo Origen)
        {
            var Destino = new Dtos.Basico.TipoEquipo();
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Marca=Origen.Marca;
            Destino.Referencia=Origen.Referencia;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            return Destino;
        }

        public Datos.TipoEquipo Mapper(Dtos.Basico.TipoEquipo Origen)
        {
            var Destino = new Datos.TipoEquipo();
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Marca=Origen.Marca;
            Destino.Referencia=Origen.Referencia;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
          return Destino;
    }
}
}
