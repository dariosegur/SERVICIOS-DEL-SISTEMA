using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Constantes
    {
        public enum TipoUsuairo
        {
            Administrador = 0,
            Estudiante=1,
            Auxiliar=2,
            Docente=3,
            Administrativo=4,
        }
        public enum EstadoMulta
        {
            Activa = 1,
            Paga = 2,
            Anulada = 3
        }
        public enum EstadoAnotacion
        {
            Activa = 1,
            Atendida = 2,
            Anulada = 3
        }
    }
}
