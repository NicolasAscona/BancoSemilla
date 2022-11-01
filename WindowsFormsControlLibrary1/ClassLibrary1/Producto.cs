using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Producto : descripcionArticulo
    {
        public int precio { get; set; }
        public int idProduct { get; set; }
       
        public int cantidadTotal { get; set; }

        
    }
}
