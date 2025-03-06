//********************************************************
//* Archivo auto generado para Mapper PrestamoRecepcion
//********************************************************
namespace Datos.Mapper.Registro
{

using System;
using System.Collections.Generic;    

public partial class PrestamoRecepcion:MapperBase
{
        public Dtos.Registro.PrestamoRecepcion Mapper(Datos.PrestamoRecepcion Origen)
        {
            var Destino = new Dtos.Registro.PrestamoRecepcion();
            Destino.PrestamoRecepcionId=Origen.PrestamoRecepcionId;
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.EquipoId=Origen.EquipoId;
            Destino.FacultadId=Origen.FacultadId;
            Destino.SemestreBasico=Origen.SemestreBasico;
            Destino.AuxilliarPrestaId=Origen.AuxilliarPrestaId;
            Destino.FechaPrestamo=Origen.FechaPrestamo;
            Destino.PrestamoMaual=Origen.PrestamoMaual;
            Destino.AuxilliarRecibeId=Origen.AuxilliarRecibeId;
            Destino.FechaRecepcion=Origen.FechaRecepcion;
            Destino.RecepcionManual=Origen.RecepcionManual;
            return Destino;
        }

        public Datos.PrestamoRecepcion Mapper(Dtos.Registro.PrestamoRecepcion Origen)
        {
            var Destino = new Datos.PrestamoRecepcion();
            Destino.PrestamoRecepcionId=Origen.PrestamoRecepcionId;
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.EquipoId=Origen.EquipoId;
            Destino.FacultadId=Origen.FacultadId;
            Destino.SemestreBasico=Origen.SemestreBasico;
            Destino.AuxilliarPrestaId=Origen.AuxilliarPrestaId;
            Destino.FechaPrestamo=Origen.FechaPrestamo;
            Destino.PrestamoMaual=Origen.PrestamoMaual;
            Destino.AuxilliarRecibeId=Origen.AuxilliarRecibeId;
            Destino.FechaRecepcion=Origen.FechaRecepcion;
            Destino.RecepcionManual=Origen.RecepcionManual;
          return Destino;
    }
}
}
