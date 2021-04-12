using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public String Nombre { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }
        public Decimal DeudaTotal { get; set; }

        public Cliente() { }
        public Cliente(String nom, String tel, String dir)
        {
            this.Nombre = nom;
            this.Telefono = tel;
            this.Direccion = dir;
        }
    }
}
