//********************************************************
//* Archivo auto generado para Mapper View_MultasActivas
//********************************************************
namespace Datos.Mapper.Registro
{

using System;
using System.Collections.Generic;    

public partial class View_MultasActivas:MapperBase
{
        public Dtos.Registro.View_MultasActivas Mapper(Datos.View_MultasActivas Origen)
        {
            var Destino = new Dtos.Registro.View_MultasActivas();
            Destino.MultaId=Origen.MultaId;
            Destino.Documento=Origen.Documento;
            Destino.Nombre=Origen.Nombre;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Valor=Origen.Valor;
            Destino.NombreCreador=Origen.NombreCreador;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.NombreModifica=Origen.NombreModifica;
            Destino.DeudorId=Origen.DeudorId;
            Destino.FechaModificacion=Origen.FechaModificacion;
            return Destino;
        }

        public Datos.View_MultasActivas Mapper(Dtos.Registro.View_MultasActivas Origen)
        {
            var Destino = new Datos.View_MultasActivas();
            Destino.MultaId=Origen.MultaId;
            Destino.Documento=Origen.Documento;
            Destino.Nombre=Origen.Nombre;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Valor=Origen.Valor;
            Destino.NombreCreador=Origen.NombreCreador;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.NombreModifica=Origen.NombreModifica;
            Destino.DeudorId=Origen.DeudorId;
            Destino.FechaModificacion=Origen.FechaModificacion;
          return Destino;
    }
}
}
