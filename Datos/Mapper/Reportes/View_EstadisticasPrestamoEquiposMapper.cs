//********************************************************
//* Archivo auto generado para Mapper View_EstadisticasPrestamoEquipos
//********************************************************
namespace Datos.Mapper.Reportes
{

using System;
using System.Collections.Generic;    

public partial class View_EstadisticasPrestamoEquipos:MapperBase
{
        public Dtos.Reportes.View_EstadisticasPrestamoEquipos Mapper(Datos.View_EstadisticasPrestamoEquipos Origen)
        {
            var Destino = new Dtos.Reportes.View_EstadisticasPrestamoEquipos();
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.EquipoId=Origen.EquipoId;
            Destino.TipoEquipo=Origen.TipoEquipo;
            Destino.Marca=Origen.Marca;
            Destino.Referencia=Origen.Referencia;
            Destino.TipoEquipoActivo=Origen.TipoEquipoActivo;
            Destino.PrestamosTipoEquipo=Origen.PrestamosTipoEquipo;
            Destino.CodigoLaboratorio=Origen.CodigoLaboratorio;
            Destino.PrestamosEquipo=Origen.PrestamosEquipo;
            Destino.EquipoActivo=Origen.EquipoActivo;
            Destino.Serial=Origen.Serial;
            Destino.CodigoInventario=Origen.CodigoInventario;
            return Destino;
        }

        public Datos.View_EstadisticasPrestamoEquipos Mapper(Dtos.Reportes.View_EstadisticasPrestamoEquipos Origen)
        {
            var Destino = new Datos.View_EstadisticasPrestamoEquipos();
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.EquipoId=Origen.EquipoId;
            Destino.TipoEquipo=Origen.TipoEquipo;
            Destino.Marca=Origen.Marca;
            Destino.Referencia=Origen.Referencia;
            Destino.TipoEquipoActivo=Origen.TipoEquipoActivo;
            Destino.PrestamosTipoEquipo=Origen.PrestamosTipoEquipo;
            Destino.CodigoLaboratorio=Origen.CodigoLaboratorio;
            Destino.PrestamosEquipo=Origen.PrestamosEquipo;
            Destino.EquipoActivo=Origen.EquipoActivo;
            Destino.Serial=Origen.Serial;
            Destino.CodigoInventario=Origen.CodigoInventario;
          return Destino;
    }
}
}
