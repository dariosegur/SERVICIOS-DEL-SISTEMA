//********************************************************
//* Archivo auto generado para Mapper EstadoAnotacion
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class EstadoAnotacion:MapperBase
{
        public Dtos.Basico.EstadoAnotacion Mapper(Datos.EstadoAnotacion Origen)
        {
            var Destino = new Dtos.Basico.EstadoAnotacion();
            Destino.EstadoAnotacionId=Origen.EstadoAnotacionId;
            Destino.Descripcion=Origen.Descripcion;
            return Destino;
        }

        public Datos.EstadoAnotacion Mapper(Dtos.Basico.EstadoAnotacion Origen)
        {
            var Destino = new Datos.EstadoAnotacion();
            Destino.EstadoAnotacionId=Origen.EstadoAnotacionId;
            Destino.Descripcion=Origen.Descripcion;
          return Destino;
    }
}
}
