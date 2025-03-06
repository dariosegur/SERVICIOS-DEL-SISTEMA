//********************************************************
//* Archivo auto generado para Mapper View_Equipo
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_Equipo:MapperBase
{
        public Dtos.Basico.View_Equipo Mapper(Datos.View_Equipo Origen)
        {
            var Destino = new Dtos.Basico.View_Equipo();
            Destino.EquipoId=Origen.EquipoId;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.CodigoInventario=Origen.CodigoInventario;
            Destino.CodigoLaboratorio=Origen.CodigoLaboratorio;
            Destino.Serial=Origen.Serial;
            Destino.UsuarioResponsableId=Origen.UsuarioResponsableId;
            Destino.UsuarioResponsable=Origen.UsuarioResponsable;
            Destino.UsuarioResponsableCodigoBarras=Origen.UsuarioResponsableCodigoBarras;
            Destino.TipoEquipo=Origen.TipoEquipo;
            Destino.Marca=Origen.Marca;
            Destino.Referencia=Origen.Referencia;
            Destino.Activo=Origen.Activo;
            Destino.Creado=Origen.Creado;
            Destino.FechaCreado=Origen.FechaCreado;
            Destino.FechaModificado=Origen.FechaModificado;
            Destino.Modificado=Origen.Modificado;
            Destino.FechaCompra=Origen.FechaCompra;
            Destino.UsuarioInventarioResponsableId=Origen.UsuarioInventarioResponsableId;
            Destino.UsuarioInventarioResponsable=Origen.UsuarioInventarioResponsable;
            Destino.UsuarioInventarioResponsableCodigoBarras=Origen.UsuarioInventarioResponsableCodigoBarras;
            return Destino;
        }

        public Datos.View_Equipo Mapper(Dtos.Basico.View_Equipo Origen)
        {
            var Destino = new Datos.View_Equipo();
            Destino.EquipoId=Origen.EquipoId;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.CodigoInventario=Origen.CodigoInventario;
            Destino.CodigoLaboratorio=Origen.CodigoLaboratorio;
            Destino.Serial=Origen.Serial;
            Destino.UsuarioResponsableId=Origen.UsuarioResponsableId;
            Destino.UsuarioResponsable=Origen.UsuarioResponsable;
            Destino.UsuarioResponsableCodigoBarras=Origen.UsuarioResponsableCodigoBarras;
            Destino.TipoEquipo=Origen.TipoEquipo;
            Destino.Marca=Origen.Marca;
            Destino.Referencia=Origen.Referencia;
            Destino.Activo=Origen.Activo;
            Destino.Creado=Origen.Creado;
            Destino.FechaCreado=Origen.FechaCreado;
            Destino.FechaModificado=Origen.FechaModificado;
            Destino.Modificado=Origen.Modificado;
            Destino.FechaCompra=Origen.FechaCompra;
            Destino.UsuarioInventarioResponsableId=Origen.UsuarioInventarioResponsableId;
            Destino.UsuarioInventarioResponsable=Origen.UsuarioInventarioResponsable;
            Destino.UsuarioInventarioResponsableCodigoBarras=Origen.UsuarioInventarioResponsableCodigoBarras;
          return Destino;
    }
}
}
