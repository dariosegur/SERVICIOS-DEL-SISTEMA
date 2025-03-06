//********************************************************
//* Archivo auto generado para Mapper View_DetallePrestamoRecepcion
//********************************************************
namespace Datos.Mapper.Reportes
{

using System;
using System.Collections.Generic;    

public partial class View_DetallePrestamoRecepcion:MapperBase
{
        public Dtos.Reportes.View_DetallePrestamoRecepcion Mapper(Datos.View_DetallePrestamoRecepcion Origen)
        {
            var Destino = new Dtos.Reportes.View_DetallePrestamoRecepcion();
            Destino.Documento=Origen.Documento;
            Destino.Codigo=Origen.Codigo;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.Facultad=Origen.Facultad;
            Destino.Rol=Origen.Rol;
            Destino.CodigoEquipo=Origen.CodigoEquipo;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Marca=Origen.Marca;
            Destino.Referencia=Origen.Referencia;
            Destino.SemestreBasico=Origen.SemestreBasico;
            Destino.PrestamoMaual=Origen.PrestamoMaual;
            Destino.FechaPrestamo=Origen.FechaPrestamo;
            Destino.PrestadoPor=Origen.PrestadoPor;
            Destino.RecepcionManual=Origen.RecepcionManual;
            Destino.FechaRecepcion=Origen.FechaRecepcion;
            Destino.RecibidoPor=Origen.RecibidoPor;
            Destino.FacultadId=Origen.FacultadId;
            Destino.PrestamoRecepcionId=Origen.PrestamoRecepcionId;
            return Destino;
        }

        public Datos.View_DetallePrestamoRecepcion Mapper(Dtos.Reportes.View_DetallePrestamoRecepcion Origen)
        {
            var Destino = new Datos.View_DetallePrestamoRecepcion();
            Destino.Documento=Origen.Documento;
            Destino.Codigo=Origen.Codigo;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.Facultad=Origen.Facultad;
            Destino.Rol=Origen.Rol;
            Destino.CodigoEquipo=Origen.CodigoEquipo;
            Destino.Descripcion=Origen.Descripcion;
            Destino.Marca=Origen.Marca;
            Destino.Referencia=Origen.Referencia;
            Destino.SemestreBasico=Origen.SemestreBasico;
            Destino.PrestamoMaual=Origen.PrestamoMaual;
            Destino.FechaPrestamo=Origen.FechaPrestamo;
            Destino.PrestadoPor=Origen.PrestadoPor;
            Destino.RecepcionManual=Origen.RecepcionManual;
            Destino.FechaRecepcion=Origen.FechaRecepcion;
            Destino.RecibidoPor=Origen.RecibidoPor;
            Destino.FacultadId=Origen.FacultadId;
            Destino.PrestamoRecepcionId=Origen.PrestamoRecepcionId;
          return Destino;
    }
}
}
