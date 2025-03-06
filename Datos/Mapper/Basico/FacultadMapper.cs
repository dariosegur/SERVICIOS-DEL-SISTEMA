//********************************************************
//* Archivo auto generado para Mapper Facultad
//********************************************************
namespace Datos.Mapper.Basico
{

using System;
using System.Collections.Generic;    

public partial class Facultad:MapperBase
{
        public Dtos.Basico.Facultad Mapper(Datos.Facultad Origen)
        {
            var Destino = new Dtos.Basico.Facultad();
            Destino.FacultadId=Origen.FacultadId;
            Destino.Nombre=Origen.Nombre;
            Destino.Codigo=Origen.Codigo;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.SedeId=Origen.SedeId;
            return Destino;
        }

        public Datos.Facultad Mapper(Dtos.Basico.Facultad Origen)
        {
            var Destino = new Datos.Facultad();
            Destino.FacultadId=Origen.FacultadId;
            Destino.Nombre=Origen.Nombre;
            Destino.Codigo=Origen.Codigo;
            Destino.Activo=Origen.Activo;
            Destino.FechaCreacion=Origen.FechaCreacion;
            Destino.FechaModificacion=Origen.FechaModificacion;
            Destino.CreadoId=Origen.CreadoId;
            Destino.ModificadoId=Origen.ModificadoId;
            Destino.SedeId=Origen.SedeId;
          return Destino;
    }
}
}
