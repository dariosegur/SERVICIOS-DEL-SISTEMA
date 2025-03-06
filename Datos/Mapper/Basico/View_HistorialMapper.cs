//********************************************************
//* Archivo auto generado para Mapper View_Historial
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_Historial:MapperBase
{
        public Dtos.Basico.View_Historial Mapper(Datos.View_Historial Origen)
        {
            var Destino = new Dtos.Basico.View_Historial();
            Destino.PrestamorecepcionId=Origen.PrestamorecepcionId;
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.AuxilliarPrestaId=Origen.AuxilliarPrestaId;
            Destino.AuxilliarRecibeId=Origen.AuxilliarRecibeId;
            Destino.EquipoId=Origen.EquipoId;
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.AuxiliarPresta=Origen.AuxiliarPresta;
            Destino.AuxiliarRecibe=Origen.AuxiliarRecibe;
            Destino.FechaPrestamo=Origen.FechaPrestamo;
            Destino.FechaRecepcion=Origen.FechaRecepcion;
            Destino.CodigoInventario=Origen.CodigoInventario;
            Destino.CodigoLaboratorio=Origen.CodigoLaboratorio;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Marca=Origen.Marca;
            return Destino;
        }

        public Datos.View_Historial Mapper(Dtos.Basico.View_Historial Origen)
        {
            var Destino = new Datos.View_Historial();
            Destino.PrestamorecepcionId=Origen.PrestamorecepcionId;
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.AuxilliarPrestaId=Origen.AuxilliarPrestaId;
            Destino.AuxilliarRecibeId=Origen.AuxilliarRecibeId;
            Destino.EquipoId=Origen.EquipoId;
            Destino.TipoEquipoId=Origen.TipoEquipoId;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.AuxiliarPresta=Origen.AuxiliarPresta;
            Destino.AuxiliarRecibe=Origen.AuxiliarRecibe;
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
