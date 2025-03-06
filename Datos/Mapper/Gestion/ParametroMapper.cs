//********************************************************
//* Archivo auto generado para Mapper Parametro
//********************************************************
namespace Datos.Mapper.Gestion
{

using System;
using System.Collections.Generic;    

public partial class Parametro:MapperBase
{
        public Dtos.Gestion.Parametro Mapper(Datos.Parametro Origen)
        {
            var Destino = new Dtos.Gestion.Parametro();
            Destino.ParametroId=Origen.ParametroId;
            Destino.Nombre=Origen.Nombre;
            Destino.Valor=Origen.Valor;
            Destino.Descripcion=Origen.Descripcion;
            return Destino;
        }

        public Datos.Parametro Mapper(Dtos.Gestion.Parametro Origen)
        {
            var Destino = new Datos.Parametro();
            Destino.ParametroId=Origen.ParametroId;
            Destino.Nombre=Origen.Nombre;
            Destino.Valor=Origen.Valor;
            Destino.Descripcion=Origen.Descripcion;
          return Destino;
    }
}
}
