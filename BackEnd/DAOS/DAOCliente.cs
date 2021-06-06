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
        /// <summary>
        /// Obtencion de todos los clientes registrados
        /// </summary>
        /// <returns></returns>
        public List<Cliente> getAllVentas()
        {
            try
            {
                List<Cliente> lista = new List<Cliente>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT c.*,sum(v.Saldo) as Deuda_Total "+
                    " FROM Cliente c join venta v on c.idcliente=v.idcliente group by c.idcliente order by c.idCliente" + ";");
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
        public List<Cliente> getAllClientes()
        {
            try
            {
                List<Cliente> lista = new List<Cliente>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT * from cliente order by idCliente" + ";");
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
                throw new Exception("Error al obtener datos del Cliente");
            }

        }
        /// <summary>
        /// Obtenemos los datos de un cliente en especificio mediante un id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Cliente getOne(int id)
        {
            try
            {
                Cliente datos = new Cliente();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT * FROM Cliente where idCliente =" + id + ";");
                DataTable dt = dat.Tables[0];
                foreach (DataRow r in dt.Rows)
                {
                    datos.IdCliente = (int)r.ItemArray[0];
                    datos.Nombre = (String)r.ItemArray[1];
                    datos.Telefono = (String)r.ItemArray[2];
                    datos.Direccion = (String)r.ItemArray[3];
                }
                return datos;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Registrar Nuevo Cliente
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool registrar(Cliente obj)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "INSERT INTO Cliente "
                    + "VALUES (default,@Nombre, @Telefono, @Direccion)" + ";";
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

     
        /// <summary>
        /// Se obtienen los datos del cliente ya registrado y un id para poder editarlos
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="id"></param>
        /// <returns></returns>
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


        public bool Eliminar(int id)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "Delete from cliente where idcliente='" + id + "';";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                int regafectados = comando.ExecuteNonQuery();
                conexion.Close();
                return (regafectados > 0);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



    }
}
