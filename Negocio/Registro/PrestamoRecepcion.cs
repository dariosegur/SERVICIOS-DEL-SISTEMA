using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Registro
{
    public class PrestamoRecepcion
    {
        public Dtos.Registro.View_PrestamoRecepcion getInfoPrestamoRecepcion(string barCode)
        {
            Dtos.Registro.View_PrestamoRecepcion respuesta = new Dtos.Registro.View_PrestamoRecepcion();
            try
            {
                var mapperPrestamoRecepcion = new Datos.Mapper.Registro.View_PrestamoRecepcion();
                using (var context = new Datos.LabManagerEntities())
                {
                    var prs = context.View_PrestamoRecepcion.Where(p=>p.BarCode==barCode).ToList();
                    if (prs.Count <= 0) throw new Exception("El código no es de un estudiante, de un docente o está inactivo ");
                    if (prs.Count > 1) throw new Exception("La información no puede ser consultada (getInfoPrestamoRecepcion)");
                    var pr = prs[0];
                    
                    respuesta = mapperPrestamoRecepcion.Mapper(pr);
                    
                    if (pr.nAnotaciones > 0)
                    {
                        var anotaciones = context.View_AnotacionesActivas.Where(a => a.UsuarioId == pr.UsuarioId).ToList();
                        var mapper = new Datos.Mapper.Registro.View_AnotacionesActivas();
                        respuesta.Anotaciones = anotaciones.Select(a => mapper.Mapper(a)).ToList();
                    }
                    else {
                        respuesta.Anotaciones = new List<Dtos.Registro.View_AnotacionesActivas>();
                    }
                    if (pr.nMultas > 0)
                    {
                        var multas = context.View_MultasActivas.Where(m => m.DeudorId == pr.UsuarioId).ToList();
                        var mapper = new Datos.Mapper.Registro.View_MultasActivas();
                        respuesta.Multas = multas.Select(m => mapper.Mapper(m)).ToList();
                    }
                    else {
                        respuesta.Multas = new List<Dtos.Registro.View_MultasActivas>();
                    }
                    if (pr.nEquipos > 0)
                    {
                        var equipos = context.View_EquiposACargo.Where(e => e.UsuarioId == pr.UsuarioId).ToList();
                        var mapper = new Datos.Mapper.Registro.View_EquiposACargo();
                        respuesta.Equipos = equipos.Select(e => mapper.Mapper(e)).ToList();
                    }
                    else {
                        respuesta.Equipos = new List<Dtos.Registro.View_EquiposACargo>();
                    }

                    respuesta.Error = false;
                    respuesta.Mensaje = respuesta.Activo?"":"INACTIVO";
                }
            }
            catch (Exception ex)
            {
                respuesta.Error = true;
                respuesta.Mensaje = ex.Message;
            }
            return respuesta;
        }
        public Dtos.Registro.RestriccionDto getRestriccionesEquipo(string barCodeEquipo)
        {
            var respuesta = new Dtos.Registro.RestriccionDto();
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    var equipos = context.View_Equipo.Where(eq => eq.CodigoLaboratorio == barCodeEquipo || eq.CodigoInventario == barCodeEquipo).ToList();
                    if (equipos.Count <= 0) throw new Exception("El código no pertenece a un equipo registrado");
                    if (equipos.Count > 1) throw new Exception("La información no puede ser consultada (getRestriccionesEquipo)");
                    var equipo = equipos[0];

                    var restriccionEquipos = context.RestriccionTipoEquipoes.Where(rte=>rte.TipoEquipoId==equipo.TipoEquipoId && rte.Activo).ToList();
                    var idRestricciones = restriccionEquipos.Select(re=>re.RestriccionId).ToArray();
                    if (restriccionEquipos.Count > 0)
                    {
                        var mapper = new Datos.Mapper.Basico.Restriccion();
                        var restricciones = context.Restriccions.Where(r=>idRestricciones.Contains(r.RestriccionId));
                        respuesta.Restricciones = new List<Dtos.Basico.Restriccion>();
                        foreach (var r in restricciones)
                        {
                            respuesta.Restricciones.Add(mapper.Mapper(r));
                        }
                    }
                    respuesta.Error = false;
                    respuesta.Mensaje = "";
                }
            }
            catch (Exception ex)
            {
                respuesta.Error = true;
                respuesta.Mensaje = ex.Message;
            }
            return respuesta;
        }
        public Dtos.Registro.View_EquiposACargo PrestarRecibirEquipo(
            long usuarioId, long auxiliarId, 
            int? FacultadId, int? SemestreBasico,
            string barCodeEquipo, 
            bool operacionManual
            ){
            var respuesta = new Dtos.Registro.View_EquiposACargo();
            respuesta.Prestado = false;
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    var equipos = context.View_Equipo.Where(eq => eq.CodigoLaboratorio == barCodeEquipo && eq.Activo).ToList();
                    if (equipos.Count <= 0) {
                        equipos = context.View_Equipo.Where(eq => eq.CodigoInventario == barCodeEquipo && eq.Activo).ToList();
                    }
                    if (equipos.Count <= 0) throw new Exception("El código no pertenece a un equipo registrado o esta inactivo");
                    if (equipos.Count > 1) throw new Exception("La información no puede ser consultada (PrestarRecibirEquipo)");
                    var equipo = equipos[0];
                    if (equipo.UsuarioResponsableId == null)
                    {
                        Prestar(usuarioId, auxiliarId, equipo.EquipoId, FacultadId, SemestreBasico, operacionManual, context);
                        respuesta.Prestado = true;
                    }
                    else if (equipo.UsuarioResponsableId != usuarioId)
                    {
                        throw new Exception("El equipo esta a cargo de otro estudiante: " + equipo.UsuarioResponsable);
                    }
                    else if (equipo.UsuarioResponsableId == usuarioId)
                    {
                        Recibir(usuarioId, auxiliarId, equipo.EquipoId, operacionManual, context);
                        respuesta.Prestado = false;
                    }
                  
                    respuesta.CodigoLaboratorio = equipo.CodigoLaboratorio;
                    respuesta.TipoEquipo = equipo.TipoEquipo;
                    respuesta.Error = false;
                    respuesta.Mensaje = "";
                }
            }
            catch (Exception ex)
            {
                respuesta.Error = true;
                respuesta.Mensaje = ex.Message;
            }
            return respuesta;
        }
        public Dtos.DtoInt getTimeLogOut()
        {
            var respuesta = new Dtos.DtoInt();
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    var parametro = context.Parametroes.Where(p=>p.Nombre== "TimeLogout").ToArray();
                    if (parametro.Count() <= 0) throw new Exception("El parámetro  TimeLogout no esta definido");
                    if (parametro.Count() > 1) throw new Exception("La información no puede ser consultada (getRestriccionesEquipo)");
                    var timeout = int.Parse(parametro[0].Valor);
                    respuesta.Valor = timeout;
                    respuesta.Error = false;
                    respuesta.Mensaje = "";
                }
            }
            catch (Exception ex)
            {
                respuesta.Error = true;
                respuesta.Mensaje = ex.Message;
            }
            return respuesta;
        }

        private void Prestar(long usuarioId, long auxiliarId, long equipoId, int? facultadId, int? semestreBasico, bool operacionManual, Datos.LabManagerEntities contexto)
        {
            var registro = new Datos.PrestamoRecepcion
            {
                UsuarioId = usuarioId,
                EquipoId = equipoId,
                FacultadId = facultadId,
                SemestreBasico = semestreBasico,
                AuxilliarPrestaId = auxiliarId,
                FechaPrestamo = DateTime.Now,
                PrestamoMaual = operacionManual
            };
            contexto.PrestamoRecepcions.Add(registro);
            contexto.SaveChanges();
        }
        private void Recibir(long usuarioId, long auxiliarId, long equipoId, bool operacionManual, Datos.LabManagerEntities contexto)
        {
            var registro = contexto.PrestamoRecepcions.Single(pr=>pr.UsuarioId==usuarioId && pr.EquipoId==equipoId && pr.FechaRecepcion==null);
            registro.AuxilliarRecibeId = auxiliarId;
            registro.FechaRecepcion = DateTime.Now;
            registro.RecepcionManual = operacionManual;
            contexto.SaveChanges();
        }
    }
}
