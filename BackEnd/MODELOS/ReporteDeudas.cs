using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
    public class ReporteDeudas
    {

        public int idCompra { get; set; }
        public String  Nombre { get; set; }
        public String  Producto { get; set; }
        public Decimal Cantidad_Venta { get; set; }
        public Decimal Saldo { get; set; }
        public DateTime Fecha { get; set; }
        public String Gerente { get; set; }


        public ReporteDeudas() { }
       

    }
}
