using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Registro
{
    public class Historial
    {
        public Dtos.Registro.Lista_ViewHistorial getHistorial(string FiltroTexto, int UsuarioId)
        {
            Dtos.Registro.Lista_ViewHistorial respuesta = new Dtos.Registro.Lista_ViewHistorial();
            respuesta.Historial = new List<Dtos.Registro.View_Historial>();
            try
            {
                var mapper = new Datos.Mapper.Registro.View_Historial();
                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.Historial(FiltroTexto).Where(r=>r.UsuarioId==UsuarioId).ToList();
                    foreach (var reg in lista)
                    {
                        var r = mapper.Mapper(reg);
                        respuesta.Historial.Add(r);
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
