//********************************************************
//* Archivo auto generado para Mapper View_AnotacionesActivas
//********************************************************
namespace Datos.Mapper.Registro
{

using System;
using System.Collections.Generic;    

public partial class View_AnotacionesActivas:MapperBase
{
        public Dtos.Registro.View_AnotacionesActivas Mapper(Datos.View_AnotacionesActivas Origen)
        {
            var Destino = new Dtos.Registro.View_AnotacionesActivas();
            Destino.AnotacionId=Origen.AnotacionId;
            Destino.Documento=Origen.Documento;
            Destino.Nombre=Origen.Nombre;
            Destino.Descripcion=Origen.Descripcion;
            Destino.NombreCreador=Origen.NombreCreador;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.NombreModifica=Origen.NombreModifica;
            Destino.UsuarioId=Origen.UsuarioId;
            return Destino;
        }

        public Datos.View_AnotacionesActivas Mapper(Dtos.Registro.View_AnotacionesActivas Origen)
        {
            var Destino = new Datos.View_AnotacionesActivas();
            Destino.AnotacionId=Origen.AnotacionId;
            Destino.Documento=Origen.Documento;
            Destino.Nombre=Origen.Nombre;
            Destino.Descripcion=Origen.Descripcion;
            Destino.NombreCreador=Origen.NombreCreador;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.NombreModifica=Origen.NombreModifica;
            Destino.UsuarioId=Origen.UsuarioId;
          return Destino;
    }
}
}
