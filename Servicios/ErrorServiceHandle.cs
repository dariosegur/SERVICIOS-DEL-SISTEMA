using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;

namespace Servicios
{
    class ErrorServiceHandle
    {
        public static void ExtractError(Dtos.DtoBase Dto, Exception ex)
        {
            while (ex != null)
            {
                Dto.Mensaje = ex.Message;
                ex = ex.InnerException;
            }
            Dto.Error = true;
        }
    }
}
