using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class historicoVentas
    {
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
        public int idHistoricoVentas { get; set; }
        public Cliente idCliente { get; set; }

    }
}
