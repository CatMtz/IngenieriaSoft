using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using BackEnd.MODELOS;

namespace BackEnd.DAOS
{
   public class DaoVenta
    {


        public bool registrar(Venta obj)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "INSERT INTO venta "
                    + "VALUES (default,@IDGerente, @IDCliente, @Descripcion, @CantidadV,@Tipo,@Saldo,now())" + ";";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@IDGerente", obj.Idgerente);
                comando.Parameters.AddWithValue("@IDCliente", obj.IdCliente);
                comando.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                comando.Parameters.AddWithValue("@CantidadV", obj.CantidadV);
                comando.Parameters.AddWithValue("@Tipo", obj.Tipo);
                comando.Parameters.AddWithValue("@Saldo", obj.Saldo);
                int regafectados = comando.ExecuteNonQuery();
                conexion.Close();
                return (regafectados > 0);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo hacer el registro de la venta");
            }

        }
    }
}
