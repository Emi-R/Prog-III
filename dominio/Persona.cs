using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaNac { get; set; }

        [DisplayName("Estado Civil")]
        public int EstadoCivil { get; set; }

        public string Estado { get; set; }

        public string Sexo { get; set; }
    }
}
