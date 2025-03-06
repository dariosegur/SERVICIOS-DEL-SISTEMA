using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Mapper.Seguridad
{
    public partial class Facultad
    {
        static public Datos.Facultad FromFacultadAdd(Dtos.Basico.View_Facultad newFacultad)
        {
            return new Datos.Facultad
            {
                FacultadId = newFacultad.FacultadId,
                Nombre = newFacultad.Nombre,
                Codigo = newFacultad.Codigo,
                Activo = newFacultad.Activo,
                FechaCreacion = DateTime.Now,
                CreadoId = newFacultad.UsuarioCreaId,
                FechaModificacion = null,
                ModificadoId = null,
                SedeId = newFacultad.SedeId
            };
        }
    
        static public void FromFacultadEdit(Dtos.Basico.View_Facultad newFacultad, ref Datos.Facultad Facultad)
        {
            Facultad.FacultadId = newFacultad.FacultadId;
            Facultad.Nombre = newFacultad.Nombre;
            Facultad.Codigo = newFacultad.Codigo;
            Facultad.Activo = newFacultad.Activo;
            Facultad.FechaModificacion = newFacultad.FechaModificacion;
            Facultad.ModificadoId = newFacultad.UsuarioModificaId;
            Facultad.FechaModificacion = DateTime.Now;
            Facultad.SedeId = newFacultad.SedeId;
        }
    }
}
;