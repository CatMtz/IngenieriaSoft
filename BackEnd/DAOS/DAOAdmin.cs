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
  public  class DAOAdmin
    {
        //Verificar Gerente registrado (LOGIN)
        public Admin VerificarGerente(string username, string contraseña)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "select * from gerente where UserName= @Username and password=@Password" + ";";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                MySqlDataReader lector = comando.ExecuteReader();
                Admin obtenerdatosCliente;
                if (lector.Read())
                {
                    obtenerdatosCliente = new Admin();
                    obtenerdatosCliente.IdGerente = lector.GetInt32("idGerente");
                    obtenerdatosCliente.Nombre = lector.GetString("Nombre");
                    obtenerdatosCliente.Apellidos = lector.GetString("Apellidos");
                    obtenerdatosCliente.UserName = lector.GetString("Username");
                    obtenerdatosCliente.password = lector.GetString("password");


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

        public Admin Datos(int id)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "select Nombre,Apellidos from gerente where idgerente="+id + ";";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                MySqlDataReader lector = comando.ExecuteReader();
                Admin obtenerdatosCliente;
                if (lector.Read())
                {
                    obtenerdatosCliente = new Admin();
                    obtenerdatosCliente.Nombre = lector.GetString("Nombre");
                    obtenerdatosCliente.Apellidos = lector.GetString("Apellidos");
                  


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

    }
}
