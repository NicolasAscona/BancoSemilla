using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ventas : historicoVentas
    {
        public float ganancias { get; set; }

        public int idVentas { get; set; }

        public string formaPago{ get; set; }
        public float recargo { get; set; }
        descripcionArticulo descripcion { get; set; }


    }
}
