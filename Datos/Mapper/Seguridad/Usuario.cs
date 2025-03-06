using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Mapper.Seguridad
{
    public partial class Usuario
    {
        static public Datos.Usuario FromEstudianteAdd(Dtos.Basico.View_Estudiante newEstudiante)
        {
            return new Datos.Usuario
            {
                Activo = newEstudiante.Activo,
                Nombres = newEstudiante.Nombres,
                Apellidos = newEstudiante.Apellidos,
                Codigo = newEstudiante.Codigo,
                Documento = newEstudiante.Documento,
                BarCode = newEstudiante.Barcode,
                CreadoId = newEstudiante.UsuarioCreaId ?? 0,
                FechaCreacion = DateTime.Now,
                FacultadId = newEstudiante.FacultadId,
                SemestreBasico = newEstudiante.SemestreBasico,
                TipoUsuarioId = (int)Constantes.TipoUsuairo.Estudiante,
                FechaModificacion = null,
                ModificadoId = null
            };
        }
        static public void FromEstudianteEdit(Dtos.Basico.View_Estudiante newEstudiante, ref Datos.Usuario usuario)
        {
            usuario.Activo = newEstudiante.Activo;
            usuario.Nombres = newEstudiante.Nombres;
            usuario.Apellidos = newEstudiante.Apellidos;
            usuario.Codigo = newEstudiante.Codigo;
            usuario.Documento = newEstudiante.Documento;
            usuario.BarCode = newEstudiante.Barcode;
            usuario.FacultadId = newEstudiante.FacultadId;
            usuario.SemestreBasico = newEstudiante.SemestreBasico;
            usuario.TipoUsuarioId = (int)Constantes.TipoUsuairo.Estudiante;
            usuario.FechaModificacion = DateTime.Now;
            usuario.ModificadoId = newEstudiante.UsuarioModificaId;
        }

        static public Datos.Usuario FromDocenteAdd(Dtos.Basico.View_Docente newDocente)
        {
            return new Datos.Usuario
            {
                Activo = newDocente.Activo,
                Nombres = newDocente.Nombres,
                Apellidos = newDocente.Apellidos,
                Documento = newDocente.Documento,
                BarCode = newDocente.Barcode,
                CreadoId = newDocente.UsuarioCreaId ?? 0,
                FechaCreacion = DateTime.Now,
                FacultadId = newDocente.FacultadId,
                TipoUsuarioId = (int)Constantes.TipoUsuairo.Docente,
                FechaModificacion = null,
                ModificadoId = null,
                CorreoElectronico = newDocente.CorreoElectronico
            };
        }
        static public void FromDocenteEdit(Dtos.Basico.View_Docente newDocente, ref Datos.Usuario usuario)
        {
            usuario.Activo = newDocente.Activo;
            usuario.Nombres = newDocente.Nombres;
            usuario.Apellidos = newDocente.Apellidos;
            usuario.Documento = newDocente.Documento;
            usuario.BarCode = newDocente.Barcode;
            usuario.FacultadId = newDocente.FacultadId;
            usuario.TipoUsuarioId = (int)Constantes.TipoUsuairo.Docente;
            usuario.FechaModificacion = DateTime.Now;
            usuario.ModificadoId = newDocente.UsuarioModificaId;
            usuario.CorreoElectronico = newDocente.CorreoElectronico;
        }

        static public Datos.Usuario FromAuxiliarAdd(Dtos.Basico.View_Auxiliar newAuxiliar)
        {
            return new Datos.Usuario
            {
                Activo = newAuxiliar.Activo,
                Nombres = newAuxiliar.Nombres,
                Apellidos = newAuxiliar.Apellidos,
                Documento = newAuxiliar.Documento,
                BarCode = newAuxiliar.Barcode,
                Password = Encoding.UTF8.GetBytes(newAuxiliar.Password),
                CreadoId = newAuxiliar.UsuarioCreaId ?? 0,
                FechaCreacion = DateTime.Now,
                TipoUsuarioId = (int)Constantes.TipoUsuairo.Auxiliar,
                FechaModificacion = null,
                ModificadoId = null,
                CorreoElectronico=newAuxiliar.CorreoElectronico
            };
        }
        static public void FromAuxiliarEdit(Dtos.Basico.View_Auxiliar newAuxiliar, ref Datos.Usuario usuario)
        {
            usuario.Activo = newAuxiliar.Activo;
            usuario.Nombres = newAuxiliar.Nombres;
            usuario.Apellidos = newAuxiliar.Apellidos;
            usuario.Documento = newAuxiliar.Documento;
            usuario.BarCode = newAuxiliar.Barcode;
            usuario.CorreoElectronico = newAuxiliar.CorreoElectronico;
            if (!string.IsNullOrEmpty(newAuxiliar.Password))
            {
                usuario.Password = Encoding.UTF8.GetBytes(newAuxiliar.Password);
            }
            usuario.TipoUsuarioId = (int)Constantes.TipoUsuairo.Auxiliar;
            usuario.FechaModificacion = DateTime.Now;
            usuario.ModificadoId = newAuxiliar.UsuarioModificaId;
        }

        static public Datos.Usuario FromAdministrativoAdd(Dtos.Basico.View_Administrativo newAdministrativo)
        {
            return new Datos.Usuario
            {
                Activo = newAdministrativo.Activo,
                Nombres = newAdministrativo.Nombres,
                Apellidos = newAdministrativo.Apellidos,
                Documento = newAdministrativo.Documento,
                BarCode = newAdministrativo.Barcode,
                Password = Encoding.UTF8.GetBytes(newAdministrativo.Password),
                CreadoId = newAdministrativo.UsuarioCreaId ?? 0,
                FechaCreacion = DateTime.Now,
                TipoUsuarioId = (int)Constantes.TipoUsuairo.Administrativo,
                FechaModificacion = null,
                ModificadoId = null,
                CorreoElectronico = newAdministrativo.CorreoElectronico
            };
        }
        static public void FromAdministrativoEdit(Dtos.Basico.View_Administrativo newAdministrativo, ref Datos.Usuario usuario)
        {
            usuario.Activo = newAdministrativo.Activo;
            usuario.Nombres = newAdministrativo.Nombres;
            usuario.Apellidos = newAdministrativo.Apellidos;
            usuario.Documento = newAdministrativo.Documento;
            usuario.BarCode = newAdministrativo.Barcode;
            usuario.CorreoElectronico = newAdministrativo.CorreoElectronico;
            if (!string.IsNullOrEmpty(newAdministrativo.Password))
            {
                usuario.Password = Encoding.UTF8.GetBytes(newAdministrativo.Password);
            }
            usuario.TipoUsuarioId = (int)Constantes.TipoUsuairo.Administrativo;
            usuario.FechaModificacion = DateTime.Now;
            usuario.ModificadoId = newAdministrativo.UsuarioModificaId;
        }
    }
}
;