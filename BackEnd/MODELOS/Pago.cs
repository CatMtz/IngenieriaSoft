using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.MODELOS;
using BackEnd.DAOS;


namespace BackEnd.MODELOS
{
    public class Pago
    {

        public String  Producto { get; set; }
        public int idPago { get; set; }
        public int idCompra { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Cantidad { get; set; }
        public Decimal Resta { get; set; }
        public String Gerente { get; set; }

        public Pago() { }

        public Pago(String prod, int idpag, int idcom, DateTime fec, Decimal cant, Decimal res, String geren)
        {
            this.Producto = prod;
            this.idPago = idpag;
            this.idCompra = idcom;
            this.Fecha = fec;
            this.Cantidad = cant;
            this.Resta = res;
            this.Gerente = geren;
        }
        public Pago(int idcom, Decimal cant)
        {
            this.idCompra = idcom;
            this.Cantidad = cant;
        }



    }
}
