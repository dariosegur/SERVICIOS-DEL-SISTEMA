//********************************************************
//* Archivo auto generado para Mapper View_TipoEquipo_Activo
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_TipoEquipo_Activo:MapperBase
{
        public Dtos.Basico.View_TipoEquipo_Activo Mapper(Datos.View_TipoEquipo_Activo Origen)
        {
            var Destino = new Dtos.Basico.View_TipoEquipo_Activo();
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
            Destino.TextoCorto=Origen.TextoCorto;
            return Destino;
        }

        public Datos.View_TipoEquipo_Activo Mapper(Dtos.Basico.View_TipoEquipo_Activo Origen)
        {
            var Destino = new Datos.View_TipoEquipo_Activo();
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
            Destino.TextoCorto=Origen.TextoCorto;
          return Destino;
    }
}
}
