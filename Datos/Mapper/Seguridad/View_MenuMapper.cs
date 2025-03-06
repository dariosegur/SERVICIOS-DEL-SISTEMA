//********************************************************
//* Archivo auto generado para Mapper View_Menu
//********************************************************
namespace Datos.Mapper.Seguridad
{

using System;
using System.Collections.Generic;    

public partial class View_Menu:MapperBase
{
        public Dtos.Seguridad.View_Menu Mapper(Datos.View_Menu Origen)
        {
            var Destino = new Dtos.Seguridad.View_Menu();
            Destino.MenuId=Origen.MenuId;
            Destino.Activo=Origen.Activo;
            Destino.Texto=Origen.Texto;
            Destino.Imagen=Origen.Imagen;
            Destino.Destino=Origen.Destino;
            Destino.Orden=Origen.Orden;
            Destino.CreaId=Origen.CreaId;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.ModificaId=Origen.ModificaId;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.Grupo=Origen.Grupo;
            return Destino;
        }

        public Datos.View_Menu Mapper(Dtos.Seguridad.View_Menu Origen)
        {
            var Destino = new Datos.View_Menu();
            Destino.MenuId=Origen.MenuId;
            Destino.Activo=Origen.Activo;
            Destino.Texto=Origen.Texto;
            Destino.Imagen=Origen.Imagen;
            Destino.Destino=Origen.Destino;
            Destino.Orden=Origen.Orden;
            Destino.CreaId=Origen.CreaId;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.ModificaId=Origen.ModificaId;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.Grupo=Origen.Grupo;
          return Destino;
    }
}
}
