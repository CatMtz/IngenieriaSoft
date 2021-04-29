using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
    public class ReporteVentaMes
    {
        public int idCompra { get; set; }
        public String NombreProducto { get; set; }
        public Int64 Cantidad { get; set; }
        public Decimal TotalProducto { get; set; }
        public String Gerente { get; set; }

        public ReporteVentaMes() { }

    }
}
