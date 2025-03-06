//********************************************************
//* Archivo auto generado para Mapper View_Multas
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_Multas:MapperBase
{
        public Dtos.Basico.View_Multas Mapper(Datos.View_Multas Origen)
        {
            var Destino = new Dtos.Basico.View_Multas();
            Destino.MultaId=Origen.MultaId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Valor=Origen.Valor;
            Destino.DeudorId=Origen.DeudorId;
            Destino.Deudor=Origen.Deudor;
            Destino.CreadoId=Origen.CreadoId;
            Destino.NombreCreador=Origen.NombreCreador;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.NombreModifica=Origen.NombreModifica;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.EstadoMultaId=Origen.EstadoMultaId;
            Destino.EstadoMulta=Origen.EstadoMulta;
            return Destino;
        }

        public Datos.View_Multas Mapper(Dtos.Basico.View_Multas Origen)
        {
            var Destino = new Datos.View_Multas();
            Destino.MultaId=Origen.MultaId;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Valor=Origen.Valor;
            Destino.DeudorId=Origen.DeudorId;
            Destino.Deudor=Origen.Deudor;
            Destino.CreadoId=Origen.CreadoId;
            Destino.NombreCreador=Origen.NombreCreador;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.NombreModifica=Origen.NombreModifica;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.EstadoMultaId=Origen.EstadoMultaId;
            Destino.EstadoMulta=Origen.EstadoMulta;
          return Destino;
    }
}
}
