using Dtos;
using Dtos.Basico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dtos.Basico
{
    public partial class View_TipoEquipo : DtoBase
    {
        public List<View_RestriccionTipoEquipo> Restricciones { get; set; }
    }
}
