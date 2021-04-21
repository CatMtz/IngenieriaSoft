using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BackEnd.MODELOS;
using MySql.Data.MySqlClient;

namespace BackEnd.DAOS
{
  public  class DAOProducto
    {
        public List<Producto> getAll()
        {
            try
            {
                List<Producto> lista = new List<Producto>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT * FROM Producto order by idProducto" + ";");
                DataTable dt = dat.Tables[0];
                Producto datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new Producto();
                    datos.IdProducto = (int)r.ItemArray[0];
                    datos.Nombre = (String)r.ItemArray[1];
                    datos.Precio = (Decimal)r.ItemArray[2];
                    datos.Descripcion = (String)r.ItemArray[3];
                    datos.Categoria = (String)r.ItemArray[4];


                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del Producto");
            }

        }
        public List<Producto> getOne(int id)
        {
            try
            {
                List<Producto> lista = new List<Producto>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT * FROM Producto where idProducto =" + id + ";");
                DataTable dt = dat.Tables[0];
                Producto datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new Producto();
                    datos.IdProducto = (int)r.ItemArray[0];
                    datos.Nombre = (String)r.ItemArray[1];
                    datos.Precio = (Decimal)r.ItemArray[2];
                    datos.Descripcion = (String)r.ItemArray[3];
                    datos.Categoria= (String)r.ItemArray[4];


                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool editar(Producto obj, int id)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "UPDATE `ingsoft`.`producto` SET" +
                    "`Nombre` = @nombre,`Precio` = @Precio,`Descripcion` = @Descripcion, `Categoria` =@Categoria "+
                    " WHERE `idProducto` =" + id + ";";

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@Nombre", obj.Nombre);
                comando.Parameters.AddWithValue("@Precio", obj.Precio);
                comando.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                comando.Parameters.AddWithValue("@Categoria", obj.Categoria);
                int regafectados = comando.ExecuteNonQuery();
                conexion.Close();
                return (regafectados > 0);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo editar el Cliente");
            }

        }


        public bool registrar(Producto obj)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "INSERT INTO Producto "
                    + "VALUES (default,@Nombre, @Precio, @Descripcion, @Categoria" + ";";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@Nombre", obj.Nombre);
                comando.Parameters.AddWithValue("@Precio", obj.Precio);
                comando.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                comando.Parameters.AddWithValue("@Categoria", obj.Categoria);
                int regafectados = comando.ExecuteNonQuery();
                conexion.Close();
                return (regafectados > 0);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo hacer el registro del Producto");
            }

        }

    }
}
