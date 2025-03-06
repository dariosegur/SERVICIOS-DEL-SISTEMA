using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Herramientas
    {
        static public Exception ExtractException(Exception ex)
        {
            var exFinal = ex;
            while (exFinal.InnerException != null)
            {
                exFinal = exFinal.InnerException;
            }
            return exFinal;
        }
    }
}
