using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubirFacturasLuz.Modelos
{
    public class Luz
    {
        public int Id { get; set; }
        public DateTime Periodo { get; set; }
        public decimal Consumo { get; set; }
        public decimal Importe { get; set; }
        public byte[] Factura { get; set; }

    }
}
