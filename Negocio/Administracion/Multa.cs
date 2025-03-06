using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Administracion
{
    public class Multa
    {
        public Dtos.Basico.Lista_View_Multas getMultas(long UsuarioId)
        {
            Dtos.Basico.Lista_View_Multas respuesta = new Dtos.Basico.Lista_View_Multas();
            respuesta.Items = new List<Dtos.Basico.View_Multas>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_Multas();
                using (var context = new Datos.LabManagerEntities())
                {
                    var prs = context.View_Multas.Where(m=>m.DeudorId==UsuarioId).ToList();
                    prs = prs.OrderBy(m=>m.EstadoMultaId).ThenByDescending(m=>m.FechaCreacion).ToList();
                    foreach (var pr in prs)
                    {
                        var r = mapper.Mapper(pr);
                        respuesta.Items.Add(r);
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

        public Dtos.DtoBase AddMulta(Dtos.Basico.View_Multas newMulta)
        {
            ValidaMulta(newMulta, true);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var nuevo = new Datos.Multa {
                        DeudorId=newMulta.DeudorId,
                        Descripcion = newMulta.Descripcion,
                        Valor = newMulta.Valor,
                        EstadoMultaId = newMulta.EstadoMultaId,
                        CreadoId = newMulta.CreadoId,
                        FechaCreacion = DateTime.Now
                    };                   
                    contex.Multas.Add(nuevo);
                    contex.SaveChanges();
                }
                return new Dtos.DtoBase
                {
                    Error = false,
                    Mensaje = ""
                };
            }
            catch (Exception ex)
            {
                return new Dtos.DtoBase
                {
                    Error = true,
                    Mensaje = ex.Message
                };
            }
        }

        public Dtos.DtoBase EditMulta(Dtos.Basico.View_Multas editMulta)
        {
            ValidaMulta(editMulta, false);
            try
            {
                using (var contex = new LabManagerEntities())
                {
                    var multa = contex.Multas.Single(m=>m.MultaId == editMulta.MultaId);
                    multa.Descripcion =editMulta.Descripcion;
                    multa.Valor = editMulta.Valor;
                    multa.EstadoMultaId =editMulta.EstadoMultaId;
                    multa.ModificadoId = editMulta.ModificadoId;
                    multa.FechaModificacion = DateTime.Now;
                    contex.SaveChanges();
                }
                return new Dtos.DtoBase
                {
                    Error = false,
                    Mensaje = ""
                };
            }
            catch (Exception ex)
            {
                return new Dtos.DtoBase
                {
                    Error = true,
                    Mensaje = ex.Message
                };
            }
        }

        public Dtos.Basico.Lista_View_EstadoMulta getEstadosMulta()
        {
            Dtos.Basico.Lista_View_EstadoMulta respuesta = new Dtos.Basico.Lista_View_EstadoMulta();
            respuesta.Items = new List<Dtos.Basico.EstadoMulta>();
            try
            {
                var mapper = new Datos.Mapper.Basico.EstadoMulta();
                using (var context = new Datos.LabManagerEntities())
                {
                    var prs = context.EstadoMultas.ToList();
                    foreach (var pr in prs)
                    {
                        var r = mapper.Mapper(pr);
                        respuesta.Items.Add(r);
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

        private void ValidaMulta(Dtos.Basico.View_Multas multa, bool nuevo)
        {
            List<string> errores = new List<string>();
            if (string.IsNullOrEmpty(multa.Descripcion))
            {
                errores.Add("La descripción es obligatoria");
            }
            else if(multa.Descripcion.Length<10 || multa.Descripcion.Length>200){
                errores.Add("La descripción debe tener entre 10 y 200 caracteres");
            }
            if (multa.Valor<=0) errores.Add("El valor es obligatorio");
            if (!Enum.IsDefined(typeof(Constantes.EstadoMulta),multa.EstadoMultaId)) errores.Add("El estado seleccionado no es válido");

            if (nuevo && (multa.CreadoId <= 0)) errores.Add("El usuario que crea el registro es obligatorio");
            if (!nuevo && (multa.ModificadoId == null || multa.ModificadoId <= 0)) errores.Add("El usuario que modifica el registro es obligatorio");
            if (multa.DeudorId <= 0) errores.Add("La información del deudor es obligatoria");

            using (var context=new LabManagerEntities())
            {
                var curMulta = context.Multas.Where(m=>m.MultaId==multa.MultaId).ToList();
                if (curMulta.Count == 1)
                {
                    if (curMulta[0].EstadoMultaId != (int)Datos.Constantes.EstadoMulta.Activa) errores.Add("Solo las multas en estado activo se pueden modificar");
                }
                else
                {
                    if (multa.EstadoMultaId != (int)Datos.Constantes.EstadoMulta.Activa) errores.Add("Una multa solo se puede crear en estado activa");
                }
            }
            if (errores.Count > 0)
            {
                var error = string.Join("\r\n", errores);
                throw new Exception(error);
            }

        }
    }
}
