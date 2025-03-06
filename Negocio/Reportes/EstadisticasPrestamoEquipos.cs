using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Reportes
{
    public class EstadisticasPrestamoEquipos
    {
        public Dtos.Reportes.Lista_View_EstadisticasPrestamoEquipos getEstadisticasPrestamoEquipos(DateTime? FechaInicial, DateTime? FechaFinal)
        {
            var hoy = DateTime.Now;
            FechaInicial = FechaInicial ?? new DateTime(hoy.Year, hoy.Month, hoy.Day,0,0,0);
            FechaFinal = FechaFinal ?? new DateTime(hoy.Year, hoy.Month, hoy.Day,23,59,59);
            Dtos.Reportes.Lista_View_EstadisticasPrestamoEquipos respuesta = new Dtos.Reportes.Lista_View_EstadisticasPrestamoEquipos();
            respuesta.Items = new List<Dtos.Reportes.View_EstadisticasPrestamoEquipos>();
            try
            {
                var mapper = new Datos.Mapper.Reportes.View_EstadisticasPrestamoEquipos();
                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.EstadisticasPrestamoEquipos(FechaInicial, FechaFinal).ToList();
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
