//********************************************************
//* Archivo auto generado para Mapper View_RestriccionTipoEquipo
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_RestriccionTipoEquipo:MapperBase
{
        public Dtos.Basico.View_RestriccionTipoEquipo Mapper(Datos.View_RestriccionTipoEquipo Origen)
        {
            var Destino = new Dtos.Basico.View_RestriccionTipoEquipo();
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.RestriccionId=Origen.RestriccionId;
            Destino.RestriccionTipoEquipoId=Origen.RestriccionTipoEquipoId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Activa=Origen.Activa;
            return Destino;
        }

        public Datos.View_RestriccionTipoEquipo Mapper(Dtos.Basico.View_RestriccionTipoEquipo Origen)
        {
            var Destino = new Datos.View_RestriccionTipoEquipo();
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.RestriccionId=Origen.RestriccionId;
            Destino.RestriccionTipoEquipoId=Origen.RestriccionTipoEquipoId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Activa=Origen.Activa;
          return Destino;
    }
}
}
