//********************************************************
//* Archivo auto generado para Mapper Equipo
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class Equipo:MapperBase
{
        public Dtos.Basico.Equipo Mapper(Datos.Equipo Origen)
        {
            var Destino = new Dtos.Basico.Equipo();
            Destino.EquipoId=Origen.EquipoId;
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.CodigoLaboratorio=Origen.CodigoLaboratorio;
            Destino.CodigoInventario=Origen.CodigoInventario;
            Destino.Serial=Origen.Serial;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.EquipoMigraId=Origen.EquipoMigraId;
            Destino.ResponsableId=Origen.ResponsableId;
            Destino.FechaCompra=Origen.FechaCompra;
            return Destino;
        }

        public Datos.Equipo Mapper(Dtos.Basico.Equipo Origen)
        {
            var Destino = new Datos.Equipo();
            Destino.EquipoId=Origen.EquipoId;
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.CodigoLaboratorio=Origen.CodigoLaboratorio;
            Destino.CodigoInventario=Origen.CodigoInventario;
            Destino.Serial=Origen.Serial;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.EquipoMigraId=Origen.EquipoMigraId;
            Destino.ResponsableId=Origen.ResponsableId;
            Destino.FechaCompra=Origen.FechaCompra;
          return Destino;
    }
}
}
