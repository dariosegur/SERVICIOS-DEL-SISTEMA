//********************************************************
//* Archivo auto generado para Mapper View_Sede
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_Sede:MapperBase
{
        public Dtos.Basico.View_Sede Mapper(Datos.View_Sede Origen)
        {
            var Destino = new Dtos.Basico.View_Sede();
            Destino.SedeId=Origen.SedeId;
            Destino.Nombre=Origen.Nombre;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.Creado=Origen.Creado;
            Destino.Modificado=Origen.Modificado;
            return Destino;
        }

        public Datos.View_Sede Mapper(Dtos.Basico.View_Sede Origen)
        {
            var Destino = new Datos.View_Sede();
            Destino.SedeId=Origen.SedeId;
            Destino.Nombre=Origen.Nombre;
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
