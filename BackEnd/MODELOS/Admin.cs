using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.MODELOS
{
  public  class Admin
    {
        public int IdGerente { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String UserName { get; set; }
        public String password { get; set; }

        public Admin() { }
      
    }
}
