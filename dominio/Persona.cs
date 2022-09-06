using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Persona
    {
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string dni { get; set; }
        public DateTime fechaNac { get; set; }
        public int estadoCivil { get; set; }
        public bool sexo { get; set; }
    }
}
