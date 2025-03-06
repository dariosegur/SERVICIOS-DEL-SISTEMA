//********************************************************
//* Archivo auto generado para Mapper EstadoMulta
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class EstadoMulta:MapperBase
{
        public Dtos.Basico.EstadoMulta Mapper(Datos.EstadoMulta Origen)
        {
            var Destino = new Dtos.Basico.EstadoMulta();
            Destino.EstadoMultaId=Origen.EstadoMultaId;
            Destino.Descripcion=Origen.Descripcion;
            return Destino;
        }

        public Datos.EstadoMulta Mapper(Dtos.Basico.EstadoMulta Origen)
        {
            var Destino = new Datos.EstadoMulta();
            Destino.EstadoMultaId=Origen.EstadoMultaId;
            Destino.Descripcion=Origen.Descripcion;
          return Destino;
    }
}
}
