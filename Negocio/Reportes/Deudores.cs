using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Reportes
{
    public class Deudores
    {
        public Dtos.Reportes.Lista_View_Deudores getDeudores()
        {
            Dtos.Reportes.Lista_View_Deudores respuesta = new Dtos.Reportes.Lista_View_Deudores();
            respuesta.Items = new List<Dtos.Reportes.View_Deudores>();
            try
            {
                var mapper = new Datos.Mapper.Reportes.View_Deudores();
                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.View_Deudores.ToList();
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
