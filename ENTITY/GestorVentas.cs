using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class GestorVentas
    {
        public List<Producto> Productos { get; set; }
        public List<Factura> Facturas { get; set; }

        public GestorVentas()
        {
            Productos = new List<Producto>();
            Facturas = new List<Factura>();
        }

    }
}
