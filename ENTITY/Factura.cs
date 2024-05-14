using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Factura
    {
        public string NumeroFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public List<ItemVenta> ItemsVenta { get; set; }

        public Factura()
        {
            ItemsVenta = new List<ItemVenta>();
        }

    }
