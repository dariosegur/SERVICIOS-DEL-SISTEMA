//********************************************************
//* Archivo auto generado para Mapper View_Historial_Equipo
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_Historial_Equipo:MapperBase
{
        public Dtos.Basico.View_Historial_Equipo Mapper(Datos.View_Historial_Equipo Origen)
        {
            var Destino = new Dtos.Basico.View_Historial_Equipo();
            Destino.PrestamorecepcionId=Origen.PrestamorecepcionId;
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.EquipoId=Origen.EquipoId;
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.UsuarioDocumento=Origen.UsuarioDocumento;
            Destino.UsuarioResponsable=Origen.UsuarioResponsable;
            Destino.FechaPrestamo=Origen.FechaPrestamo;
            Destino.FechaRecepcion=Origen.FechaRecepcion;
            Destino.CodigoInventario=Origen.CodigoInventario;
            Destino.CodigoLaboratorio=Origen.CodigoLaboratorio;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Marca=Origen.Marca;
            return Destino;
        }

        public Datos.View_Historial_Equipo Mapper(Dtos.Basico.View_Historial_Equipo Origen)
        {
            var Destino = new Datos.View_Historial_Equipo();
            Destino.PrestamorecepcionId=Origen.PrestamorecepcionId;
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.EquipoId=Origen.EquipoId;
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.UsuarioDocumento=Origen.UsuarioDocumento;
            Destino.UsuarioResponsable=Origen.UsuarioResponsable;
            Destino.FechaPrestamo=Origen.FechaPrestamo;
            Destino.FechaRecepcion=Origen.FechaRecepcion;
            Destino.CodigoInventario=Origen.CodigoInventario;
            Destino.CodigoLaboratorio=Origen.CodigoLaboratorio;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Marca=Origen.Marca;
          return Destino;
    }
}
}
