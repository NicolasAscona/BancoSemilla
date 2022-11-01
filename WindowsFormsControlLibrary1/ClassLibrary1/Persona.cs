using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Persona 
    {
        public int dni { get; set; }
        public string nombreApellido { get; set; }
        public int telefono { get; set; }
        public string correo { get; set; }
        public int idPersona { get; set; }
        public Direccion direccion { get; set; }
    }
}
