using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Reportes
{
    public class DetallePrestamoRecepcion
    {
        public Dtos.Reportes.Lista_View_DetallePrestamoRecepcion getDetallePrestamoRecepcion(DateTime? FechaInicial, DateTime? FechaFinal, int? FacultadId=null)
        {
            var hoy = DateTime.Now;
            FechaInicial = FechaInicial ?? new DateTime(hoy.Year, hoy.Month, hoy.Day,0,0,0);
            FechaFinal = FechaFinal ?? new DateTime(hoy.Year, hoy.Month, hoy.Day,23,59,59);
            Dtos.Reportes.Lista_View_DetallePrestamoRecepcion respuesta = new Dtos.Reportes.Lista_View_DetallePrestamoRecepcion();
            respuesta.Items = new List<Dtos.Reportes.View_DetallePrestamoRecepcion>();
            try
            {
                var mapper = new Datos.Mapper.Reportes.View_DetallePrestamoRecepcion();
                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.DetallePrestamoRecepcion(FechaInicial, FechaFinal, FacultadId).ToList();
                    foreach (var item in lista)
                    {
                        var r = mapper.Mapper(item);
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
    }
}
