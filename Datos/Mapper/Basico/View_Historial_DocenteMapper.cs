//********************************************************
//* Archivo auto generado para Mapper View_Historial_Docente
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_Historial_Docente:MapperBase
{
        public Dtos.Basico.View_Historial_Docente Mapper(Datos.View_Historial_Docente Origen)
        {
            var Destino = new Dtos.Basico.View_Historial_Docente();
            Destino.PrestamorecepcionId=Origen.PrestamorecepcionId;
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.EquipoId=Origen.EquipoId;
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.FechaPrestamo=Origen.FechaPrestamo;
            Destino.FechaRecepcion=Origen.FechaRecepcion;
            Destino.CodigoInventario=Origen.CodigoInventario;
            Destino.CodigoLaboratorio=Origen.CodigoLaboratorio;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Marca=Origen.Marca;
            return Destino;
        }

        public Datos.View_Historial_Docente Mapper(Dtos.Basico.View_Historial_Docente Origen)
        {
            var Destino = new Datos.View_Historial_Docente();
            Destino.PrestamorecepcionId=Origen.PrestamorecepcionId;
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.EquipoId=Origen.EquipoId;
            Destino.TipoEquipoId=Origen.TipoEquipoId;
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
