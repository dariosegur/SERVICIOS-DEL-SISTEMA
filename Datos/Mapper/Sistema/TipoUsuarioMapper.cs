//********************************************************
//* Archivo auto generado para Mapper TipoUsuario
//********************************************************
namespace Datos.Mapper.Sistema
{

using System;
using System.Collections.Generic;    

public partial class TipoUsuario:MapperBase
{
        public Dtos.Sistema.TipoUsuario Mapper(Datos.TipoUsuario Origen)
        {
            var Destino = new Dtos.Sistema.TipoUsuario();
            Destino.TipoUsuarioId=Origen.TipoUsuarioId;
            Destino.Nombre=Origen.Nombre;
            return Destino;
        }

        public Datos.TipoUsuario Mapper(Dtos.Sistema.TipoUsuario Origen)
        {
            var Destino = new Datos.TipoUsuario();
            Destino.TipoUsuarioId=Origen.TipoUsuarioId;
            Destino.Nombre=Origen.Nombre;
          return Destino;
    }
}
}
