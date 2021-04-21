using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.MODELOS;
using BackEnd.DAOS;

namespace BackEnd.MODELOS
{
    public class Venta
    {
        public int IdCompra { get; set; }
        public int Idgerente { get; set; }
        public int IdCliente { get; set; }
        public String Descripcion { get; set; }
        public Decimal CantidadV { get; set; }
        public String Tipo { get; set; }
        public Decimal Saldo { get; set; }

        public Venta() { }

        public Venta(int idg,int idc,String desc, Decimal can,String tip,Decimal sal)
        {
            this.Idgerente = idg;
            this.IdCliente = idc;
            this.Descripcion = desc;
            this.CantidadV = can;
            this.Tipo = tip;
            this.Saldo = sal;
        }

    }
}
