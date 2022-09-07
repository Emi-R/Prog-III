using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Persona
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNac { get; set; }
        public int EstadoCivil { get; set; }
        public string Estado { get; set; }
        public string Sexo { get; set; }
    }
}
