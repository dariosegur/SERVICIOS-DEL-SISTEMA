using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.PrestamoRecepcion
{
    public class Usuario:DtoBase
    {
        public bool Existe { get; set; }
        public bool Activo { get; set; }
        public Multa[] Multas { get; set; }
        public Anotacion[] Anotaciones { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Documento { get; set; }
        public string FacultadId { get; set; }
        public Equipo[] Equipos { get; set; }
        public long UsuarioId { get; set; }
        public string BarCode { get; set; }

    }
}
