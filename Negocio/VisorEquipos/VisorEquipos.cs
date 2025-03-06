using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.VisorEquipos
{
    public class VisorEquipos
    {

        public Dtos.Basico.Lista_View_Equipo getEquiposPrestados()
        {
            Dtos.Basico.Lista_View_Equipo respuesta = new Dtos.Basico.Lista_View_Equipo();
            respuesta.Items = new List<Dtos.Basico.View_Equipo>();
            try
            {
                var mapper = new Datos.Mapper.Basico.View_Equipo();
                using (var context = new Datos.LabManagerEntities())
                {
                    var lista = context.View_Equipo.Where(e=>e.UsuarioResponsableId!=null);
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
