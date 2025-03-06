//********************************************************
//* Archivo auto generado para Mapper Multa
//********************************************************
namespace Datos.Mapper.Registro
{

using System;
using System.Collections.Generic;    

public partial class Multa:MapperBase
{
        public Dtos.Registro.Multa Mapper(Datos.Multa Origen)
        {
            var Destino = new Dtos.Registro.Multa();
            Destino.MultaId=Origen.MultaId;
            Destino.DeudorId=Origen.DeudorId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Valor=Origen.Valor;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.EstadoMultaId=Origen.EstadoMultaId;
            return Destino;
        }

        public Datos.Multa Mapper(Dtos.Registro.Multa Origen)
        {
            var Destino = new Datos.Multa();
            Destino.MultaId=Origen.MultaId;
            Destino.DeudorId=Origen.DeudorId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Valor=Origen.Valor;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.EstadoMultaId=Origen.EstadoMultaId;
          return Destino;
    }
}
}
