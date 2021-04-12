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
   public class DAOCliente
    {

        public List<Cliente> getAll()
        {
            try
            {
                List<Cliente> lista = new List<Cliente>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT c.*,v.Saldo as Deuda_Total FROM Cliente c join venta v on c.idcliente=v.idcliente" + ";");
                DataTable dt = dat.Tables[0];
                Cliente datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new Cliente();
                    datos.IdCliente = (int)r.ItemArray[0];
                    datos.Nombre = (String)r.ItemArray[1];
                    datos.Telefono = (String)r.ItemArray[2];
                    datos.Direccion = (String)r.ItemArray[3];
                    datos.DeudaTotal = (Decimal)r.ItemArray[4];


                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del Cliente");
            }

        }

        public List<Cliente> getOne(int id)
        {
            try
            {
                List<Cliente> lista = new List<Cliente>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT * FROM Cliente where idCliente =" + id + ";");
                DataTable dt = dat.Tables[0];
                Cliente datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new Cliente();
                    datos.IdCliente = (int)r.ItemArray[0];
                    datos.Nombre = (String)r.ItemArray[1];
                    datos.Telefono = (String)r.ItemArray[2];
                    datos.Direccion = (String)r.ItemArray[3];
                    


                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //Registrar Nuevo Cliente
        public bool registrar(Cliente obj)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "INSERT INTO Cliente "
                    + "VALUES (default,@Nombre, @Telefono, @Direccion" + ";";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@Nombre", obj.Nombre);
                comando.Parameters.AddWithValue("@Telefono", obj.Telefono);
                comando.Parameters.AddWithValue("@Direccion", obj.Direccion);
                int regafectados = comando.ExecuteNonQuery();
                conexion.Close();
                return (regafectados > 0);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo hacer el registro del Cliente");
            }

        }

        //Verificar Cliente registrado (LOGIN)
        public Cliente VerificarCliente(string username, string contraseña)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "SELECT *  FROM Cliente WHERE Username = @Username AND password = Sha1(@Password)" + ";";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;

                comando.Parameters.AddWithValue("@Username", username);
                comando.Parameters.AddWithValue("@Password", contraseña);
                MySqlDataReader lector = comando.ExecuteReader();
                Cliente obtenerdatosCliente;
                if (lector.Read())
                {
                    obtenerdatosCliente = new Cliente();
                    obtenerdatosCliente.IdCliente = lector.GetInt32("idCliente");
                    obtenerdatosCliente.Nombre = lector.GetString("Nombre");
                    //obtenerdatosCliente.Apellido = lector.GetString("Apellido");
                    //obtenerdatosCliente.Username = lector.GetString("Username");
                   

                    return obtenerdatosCliente;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al autenticar");
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }


        public bool editar(Cliente obj,int id)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "UPDATE `ingsoft`.`cliente`SET "+
                    "`Nombre` = @nombre,`Telefono` = @Telefono,`Direccion` = @Direccion WHERE `IdCliente` =" + id + ";";
                    
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@Nombre", obj.Nombre);
                comando.Parameters.AddWithValue("@Telefono", obj.Telefono);
                comando.Parameters.AddWithValue("@Direccion", obj.Direccion);
                int regafectados = comando.ExecuteNonQuery();
                conexion.Close();
                return (regafectados > 0);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo editar el Cliente");
            }

        }

    }
}
