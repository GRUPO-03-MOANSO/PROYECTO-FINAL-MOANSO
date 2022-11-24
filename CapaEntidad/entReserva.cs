using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entReserva
    {
        public int idReserva { get; set; }

        public DateTime fecha{ get; set; }

        public int idCliente { get; set; }
        
        public int idProducto{ get; set; }

    }
}
