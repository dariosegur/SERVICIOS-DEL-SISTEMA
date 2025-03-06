//********************************************************
//* Archivo auto generado para Mapper View_EquiposACargo
//********************************************************
namespace Datos.Mapper.Registro
{

using System;
using System.Collections.Generic;    

public partial class View_EquiposACargo:MapperBase
{
        public Dtos.Registro.View_EquiposACargo Mapper(Datos.View_EquiposACargo Origen)
        {
            var Destino = new Dtos.Registro.View_EquiposACargo();
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.CodigoLaboratorio=Origen.CodigoLaboratorio;
            Destino.TipoEquipo=Origen.TipoEquipo;
            Destino.EquipoId=Origen.EquipoId;
            return Destino;
        }

        public Datos.View_EquiposACargo Mapper(Dtos.Registro.View_EquiposACargo Origen)
        {
            var Destino = new Datos.View_EquiposACargo();
            Destino.UsuarioId=Origen.UsuarioId;
            Destino.CodigoLaboratorio=Origen.CodigoLaboratorio;
            Destino.TipoEquipo=Origen.TipoEquipo;
            Destino.EquipoId=Origen.EquipoId;
          return Destino;
    }
}
}
