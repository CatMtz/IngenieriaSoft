using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd.MODELOS;
using BackEnd.DAOS;

namespace IngSoft.Interfaces
{
    public partial class NuevaVenta : Form
    {
        int idgerent = 0;
        List<Producto> listaProductos = new DAOProducto().getAll();
        List<String> prod = new List<String>();
        List<Decimal> precios = new List<Decimal>();
        List<Cliente> listaClientes = new DAOCliente().getAllClientes();
        List<String> cli = new List<String>();
        List<Venta> ventas = new List<Venta>();
        List<Detalleproducto> detalles = new List<Detalleproducto>();

        public NuevaVenta(int id)
        {
            InitializeComponent();
            idgerent = id;
            CenterToScreen();
        }
     
        private void NuevaVenta_Load(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = 0;
            try
            {
              
                foreach (Cliente item in listaClientes)
                {
                    cli.Add(item.Nombre);
                }
                cmbCliente.DataSource = cli;
                
            }
            catch (Exception ex)
            {

                throw;
            }

            try
            {
              
                foreach (Producto item in listaProductos)
                {
                    prod.Add(item.Nombre) ;
                    precios.Add(item.Precio);
                }
                cmbProducto.DataSource = prod;
              
            }
            catch (Exception ex)
            {

                throw;
            }

        }

      

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecio.Text = "";
            txtPrecio.Text = "" + precios[cmbProducto.SelectedIndex];
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
          

            try
            {
                Venta ven = new Venta(idgerent, cmbCliente.SelectedIndex + 1, cmbProducto.Text,
                                    (Decimal.Parse(txtPrecio.Text)), cmbTipo.Text,
                                    (Decimal.Parse(txtPrecio.Text) * nupCantidad.Value));
                Detalleproducto det = new Detalleproducto(Decimal.Parse(txtPrecio.Text),
                                 int.Parse(nupCantidad.Value + ""), 1000, listaProductos[cmbProducto.SelectedIndex].IdProducto);
                ventas.Add(ven);
                detalles.Add(det);
                grvProductos.DataSource = null;
                grvProductos.DataSource = ventas;
                grvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                grvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                grvProductos.ForeColor = Color.Black;
                grvProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
                grvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Transparent;
        }

        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalir.BackColor = Color.Red;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                if (ventas.Count > 0 )
                {
                    foreach (Venta vent in ventas)
                    {
                        if (new DaoVenta().registrar(vent))
                        {

                            MessageBox.Show("Venta guardada con exito");
                        }
                        else
                        {
                            MessageBox.Show("La venta no se realizo con exito");
                        }
                    }
                    foreach (Detalleproducto det in detalles)
                    {
                        new DAOProducto().RegistroDetalle(det);
                    }

                }

               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
