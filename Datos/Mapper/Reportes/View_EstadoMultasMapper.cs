//********************************************************
//* Archivo auto generado para Mapper View_EstadoMultas
//********************************************************
namespace Datos.Mapper.Reportes
{

using System;
using System.Collections.Generic;    

public partial class View_EstadoMultas:MapperBase
{
        public Dtos.Reportes.View_EstadoMultas Mapper(Datos.View_EstadoMultas Origen)
        {
            var Destino = new Dtos.Reportes.View_EstadoMultas();
            Destino.MultaId=Origen.MultaId;
            Destino.DeudorId=Origen.DeudorId;
            Destino.Deudor=Origen.Deudor;
            Destino.TipoDeudor=Origen.TipoDeudor;
            Destino.UsuarioCreaId=Origen.UsuarioCreaId;
            Destino.UsuarioCrea=Origen.UsuarioCrea;
            Destino.FechaCrea=Origen.FechaCrea;
            Destino.UsuarioModificaId=Origen.UsuarioModificaId;
            Destino.UsuarioModifica=Origen.UsuarioModifica;
            Destino.FechaModifica=Origen.FechaModifica;
            Destino.EstadoMultaId=Origen.EstadoMultaId;
            Destino.EstadoMulta=Origen.EstadoMulta;
            Destino.Valor=Origen.Valor;
            Destino.Descripcion=Origen.Descripcion;
            Destino.DeudorDocumento=Origen.DeudorDocumento;
            return Destino;
        }

        public Datos.View_EstadoMultas Mapper(Dtos.Reportes.View_EstadoMultas Origen)
        {
            var Destino = new Datos.View_EstadoMultas();
            Destino.MultaId=Origen.MultaId;
            Destino.DeudorId=Origen.DeudorId;
            Destino.Deudor=Origen.Deudor;
            Destino.TipoDeudor=Origen.TipoDeudor;
            Destino.UsuarioCreaId=Origen.UsuarioCreaId;
            Destino.UsuarioCrea=Origen.UsuarioCrea;
            Destino.FechaCrea=Origen.FechaCrea;
            Destino.UsuarioModificaId=Origen.UsuarioModificaId;
            Destino.UsuarioModifica=Origen.UsuarioModifica;
            Destino.FechaModifica=Origen.FechaModifica;
            Destino.EstadoMultaId=Origen.EstadoMultaId;
            Destino.EstadoMulta=Origen.EstadoMulta;
            Destino.Valor=Origen.Valor;
            Destino.Descripcion=Origen.Descripcion;
            Destino.DeudorDocumento=Origen.DeudorDocumento;
          return Destino;
    }
}
}
