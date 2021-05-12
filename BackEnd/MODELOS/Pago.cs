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
       
        public int idCompra { get; set; }

        public String Producto { get; set; }
        public Decimal Cantidad_Venta { get; set; }
        public int Cantidadproductos { get; set; }
        public Decimal Total { get; set; }
        public Decimal Total_pagos { get; set; }
        public Decimal Saldo { get; set; }
        public DateTime Fecha { get; set; }
      
        public String Gerente { get; set; }
        public Decimal CantidadPago { get; set; }

        public Pago() { }

        public Pago(int idcom,String prod, Decimal cantV,
            int cant,Decimal tot,Decimal res,DateTime fec, String geren)
        {
            this.idCompra = idcom;
            this.Producto = prod;
            this.Cantidad_Venta = cantV;
            this.Cantidadproductos = cant;
            this.Total = tot;
            this.Saldo = res;
            this.Fecha = fec;
            this.Gerente = geren;
        }
        public Pago(int idcom, Decimal cant)
        {
            this.idCompra = idcom;
            this.CantidadPago = cant;
        }



    }
}
