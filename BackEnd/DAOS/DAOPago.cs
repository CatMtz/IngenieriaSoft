using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.MODELOS;
using BackEnd.DAOS;
using System.Data;
using MySql.Data.MySqlClient;

namespace BackEnd.DAOS
{
   public class DAOPago
    {
        public List<Pago> getAll(int id)
        {
            try
            {
                List<Pago> lista = new List<Pago>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("select v.idCompra,v.descripcion,v.Cantidad_Venta,dp.cantidad,(dp.cantidad*dp.Precio) Total," +
                  " sum(p.Cantidad) Total_pagos,v.saldo,v.fecha,concat(g.Nombre,' ',g.Apellidos) as Gerente" +
                  " from venta v join detalleproducto dp on v.idcompra=dp.idcompra" +
                  " join pagos p on v.idCompra=p.idCompra"+
                  " join gerente g on v.idGerente=g.IdGerente" +
                  " join Cliente c on v.idCliente=c.idCliente where c.idcliente='" + id + "' group by v.descripcion;");
                DataTable dt = dat.Tables[0];
                Pago datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new Pago();
                    datos.idCompra = (int)r.ItemArray[0];
                    datos.Producto = (String)r.ItemArray[1];
                    datos.Cantidad_Venta = (Decimal)r.ItemArray[2];
                    datos.Cantidadproductos = (int)r.ItemArray[3];
                    datos.Total = (Decimal)r.ItemArray[4];
                    datos.Total_pagos = (Decimal)r.ItemArray[5];
                    datos.Saldo = (Decimal)r.ItemArray[6];
                    datos.Fecha = (DateTime)r.ItemArray[7];
                    datos.Gerente = (String)r.ItemArray[8];


                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos de los pagos");
            }

        }


        //Registrar Nuevo pago
        public bool registrar(Pago obj)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "INSERT INTO pagos VALUES (default,now(), @idCompra, @Cantidad)"+";";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@idCompra", obj.idCompra);
                comando.Parameters.AddWithValue("@Cantidad", obj.CantidadPago);
                int regafectados = comando.ExecuteNonQuery();
                conexion.Close();
                return (regafectados > 0);

            }
            catch (Exception ex)
            {
                throw;
            }

        }

    }
}
