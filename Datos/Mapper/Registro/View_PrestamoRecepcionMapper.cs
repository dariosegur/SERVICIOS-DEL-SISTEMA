//********************************************************
//* Archivo auto generado para Mapper View_PrestamoRecepcion
//********************************************************
namespace Datos.Mapper.Registro
{

using System;
using System.Collections.Generic;    

public partial class View_PrestamoRecepcion:MapperBase
{
        public Dtos.Registro.View_PrestamoRecepcion Mapper(Datos.View_PrestamoRecepcion Origen)
        {
            var Destino = new Dtos.Registro.View_PrestamoRecepcion();
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.TipoUsuarioId=Origen.TipoUsuarioId;
            Destino.TipoUsuario=Origen.TipoUsuario;
            Destino.BarCode=Origen.BarCode;
            Destino.FacultadId=Origen.FacultadId;
            Destino.SemestreBasico=Origen.SemestreBasico;
            Destino.nAnotaciones=Origen.nAnotaciones;
            Destino.nMultas=Origen.nMultas;
            Destino.nEquipos=Origen.nEquipos;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.Facultad=Origen.Facultad;
            Destino.Activo=Origen.Activo;
            return Destino;
        }

        public Datos.View_PrestamoRecepcion Mapper(Dtos.Registro.View_PrestamoRecepcion Origen)
        {
            var Destino = new Datos.View_PrestamoRecepcion();
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.TipoUsuarioId=Origen.TipoUsuarioId;
            Destino.TipoUsuario=Origen.TipoUsuario;
            Destino.BarCode=Origen.BarCode;
            Destino.FacultadId=Origen.FacultadId;
            Destino.SemestreBasico=Origen.SemestreBasico;
            Destino.nAnotaciones=Origen.nAnotaciones;
            Destino.nMultas=Origen.nMultas;
            Destino.nEquipos=Origen.nEquipos;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.Facultad=Origen.Facultad;
            Destino.Activo=Origen.Activo;
          return Destino;
    }
}
}
