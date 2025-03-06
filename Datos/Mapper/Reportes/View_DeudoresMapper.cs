//********************************************************
//* Archivo auto generado para Mapper View_Deudores
//********************************************************
namespace Datos.Mapper.Reportes
{

using System;
using System.Collections.Generic;    

public partial class View_Deudores:MapperBase
{
        public Dtos.Reportes.View_Deudores Mapper(Datos.View_Deudores Origen)
        {
            var Destino = new Dtos.Reportes.View_Deudores();
            Destino.Documento=Origen.Documento;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.Facultad=Origen.Facultad;
            Destino.Valor=Origen.Valor;
            Destino.Descripcion=Origen.Descripcion;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.CreadaPor=Origen.CreadaPor;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.ModificadaPor=Origen.ModificadaPor;
            Destino.Codigo=Origen.Codigo;
            Destino.MultaId=Origen.MultaId;
            return Destino;
        }

        public Datos.View_Deudores Mapper(Dtos.Reportes.View_Deudores Origen)
        {
            var Destino = new Datos.View_Deudores();
            Destino.Documento=Origen.Documento;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.Facultad=Origen.Facultad;
            Destino.Valor=Origen.Valor;
            Destino.Descripcion=Origen.Descripcion;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.CreadaPor=Origen.CreadaPor;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.ModificadaPor=Origen.ModificadaPor;
            Destino.Codigo=Origen.Codigo;
            Destino.MultaId=Origen.MultaId;
          return Destino;
    }
}
}
