using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
    public class Detalleproducto
    {
        public Decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int IdCompra { get; set; }
        public int IdProducto { get; set; }

        public Detalleproducto() { }

        public Detalleproducto(Decimal pre,int cant,int idc,int idp)
        {
            this.Precio = pre;
            this.Cantidad = cant;
            this.IdCompra = idc;
            this.IdProducto = idp;
        }
    }
}
