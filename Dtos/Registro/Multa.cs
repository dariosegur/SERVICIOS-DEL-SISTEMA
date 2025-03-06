using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.PrestamoRecepcion
{
    public class Multa : DtoBase
    {
        public int Valor { get; set; }
        public string Descripcion { get; set; }
    }
}
