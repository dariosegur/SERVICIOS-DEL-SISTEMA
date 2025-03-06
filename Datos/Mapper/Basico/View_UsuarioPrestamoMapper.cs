//********************************************************
//* Archivo auto generado para Mapper View_UsuarioPrestamo
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class View_UsuarioPrestamo:MapperBase
{
        public Dtos.Basico.View_UsuarioPrestamo Mapper(Datos.View_UsuarioPrestamo Origen)
        {
            var Destino = new Dtos.Basico.View_UsuarioPrestamo();
            Destino.Activo=Origen.Activo;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.Documento=Origen.Documento;
            Destino.Facultad=Origen.Facultad;
            Destino.BarCode=Origen.BarCode;
            Destino.UsuarioId=Origen.UsuarioId;
            return Destino;
        }

        public Datos.View_UsuarioPrestamo Mapper(Dtos.Basico.View_UsuarioPrestamo Origen)
        {
            var Destino = new Datos.View_UsuarioPrestamo();
            Destino.Activo=Origen.Activo;
            Destino.Nombres=Origen.Nombres;
            Destino.Apellidos=Origen.Apellidos;
            Destino.Documento=Origen.Documento;
            Destino.Facultad=Origen.Facultad;
            Destino.BarCode=Origen.BarCode;
            Destino.UsuarioId=Origen.UsuarioId;
          return Destino;
    }
}
}
