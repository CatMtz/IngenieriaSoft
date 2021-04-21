using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
    public class ReporteProductosVendidos
    {
        public int idCompra { get; set; }
        public String  Descripcion { get; set; }
        public Int64 Cantidad { get; set; }
        public Decimal Total { get; set; }
        public DateTime Fecha { get; set; }

        public ReporteProductosVendidos() { }


    }
}
