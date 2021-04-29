using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.MODELOS;
using System.Data;


namespace BackEnd.DAOS
{
    public class DAOReporte
    {


        public List<ReporteDeudas> getAllReporteDeudas()
        {
            try
            {
                List<ReporteDeudas> lista = new List<ReporteDeudas>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("select v.idCompra, c.nombre,v.descripcion,v.Cantidad_Venta," +
                        "v.saldo,v.fecha,concat(g.Nombre,' ',g.Apellidos) as Gerente " +
                        "from cliente c join venta v on c.idcliente = v.idcliente " +
                        "join gerente g on v.idGerente = g.IdGerente ; " + ";");
                DataTable dt = dat.Tables[0];
                ReporteDeudas datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new ReporteDeudas();
                    datos.idCompra = (int)r.ItemArray[0];
                    datos.Nombre = (String)r.ItemArray[1];
                    datos.Producto = (String)r.ItemArray[2];
                    datos.Cantidad_Venta = (Decimal)r.ItemArray[3];
                    datos.Saldo = (Decimal)r.ItemArray[4];
                    datos.Fecha = (DateTime)r.ItemArray[5];
                    datos.Gerente = (String)r.ItemArray[6];


                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del reporte");
            }

        }
        public List<ReporteProductosVendidos> getAllReporteProductos(String fecha)
        {
            try
            {
                List<ReporteProductosVendidos> lista = new List<ReporteProductosVendidos>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("call R_Ventaprod('"+fecha+"')" + ";");
                DataTable dt = dat.Tables[0];
                ReporteProductosVendidos datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new ReporteProductosVendidos();
                    datos.idCompra = (int)r.ItemArray[0];
                    datos.Descripcion = (String)r.ItemArray[1];
                    datos.Cantidad = (Int64)r.ItemArray[2];
                    datos.Total = (Decimal)r.ItemArray[3];
                    datos.Fecha = (DateTime)r.ItemArray[4];
                  


                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del reporte");
            }

        }

    }

}
