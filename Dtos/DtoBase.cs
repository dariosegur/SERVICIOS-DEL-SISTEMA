using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{
    public class DtoBase
    {
        public bool Error  { get; set; }
        public string Mensaje { get; set; }
        public byte[] Token { get; set; }
    }
}
