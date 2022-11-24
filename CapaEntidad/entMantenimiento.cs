using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entMantenimiento
    {

        public int idMantenimiento { get; set; }

        public DateTime fecha { get; set; }

        public string descripcion { get; set; }

        public string precio { get; set; }

        public int idCliente { get; set; }

        public int idEmpleado { get; set; }
    }
}
