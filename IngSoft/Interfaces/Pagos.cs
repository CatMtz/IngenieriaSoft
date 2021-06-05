using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd.MODELOS;
using BackEnd.DAOS;

namespace IngSoft.Interfaces
{
    public partial class Pagos : Form
    {
        int idcliente = 0;
       
        public Pagos()
        {
            InitializeComponent();
        }
        public Pagos(int idcl)
        {
            InitializeComponent();
            CenterToScreen();
            idcliente = idcl;
        }
       

        private void Pagos_Load(object sender, EventArgs e)
        {
            List<Pago> datospago = new DAOPago().getAll(idcliente);
            Decimal total = 0;
            int i = 0;
            grvPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvPagos.DataSource = null;
            if (datospago.Count > 0)
            {
                foreach(Pago dato in datospago)
                {
                    if (dato.Saldo <= 0)
                    {
                        datospago[i].Producto="PAGADO";
                    }
                    i++;
                }

                grvPagos.DataSource = datospago;
                grvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                grvPagos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                grvPagos.ForeColor = Color.Black;
                grvPagos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
                grvPagos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                grvPagos.Columns[9].Visible = false;

                

                foreach(Pago pago in datospago)
                {
                    total += pago.Saldo;
                   
                }
                txtDeudatotal.Text = "$"+total;
                
            }else
            {

            }
            Cliente datos = new DAOCliente().getOne(idcliente);
            txtNombre.Text = datos.Nombre;
            txtDireccion.Text = datos.Direccion;
            txtTelefono.Text = datos.Telefono;
            




        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            try
            {
                Pago pag = new Pago();
                int valorCelda = int.Parse(grvPagos.Rows[grvPagos.CurrentRow.Index].Cells[0].Value.ToString());
                if (txtCantidad.Text != null)
                {
                    if (verificarPrecio(txtCantidad.Text))
                    {
                        pag = new Pago(valorCelda, Decimal.Parse(txtCantidad.Text));
                    }
                }
                if ((int.Parse(grvPagos.Rows[grvPagos.CurrentRow.Index].Cells[6].Value.ToString()) == 0))
                {
                    MessageBox.Show("No puede abonarse por que ya se liquidó la cuenta");
                }
                else if (pag.CantidadPago != 0)
                {
                    if (new DAOPago().registrar(pag))
                    {
                        MessageBox.Show("El pago se realizo con exito");
                        txtCantidad.Text = "";
                        actualizartabla();
                    }
                    else
                    {
                        MessageBox.Show("No pudo realizarse el pago");
                    }
                }
                else
                {
                    MessageBox.Show("No puede abonarse 0 pesos");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }



        public void actualizartabla()
        {
            List<Pago> datospago = new DAOPago().getAll(idcliente);
            Decimal total = 0;
            grvPagos.DataSource = datospago;
            grvPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grvPagos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grvPagos.ForeColor = Color.Black;
            grvPagos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            grvPagos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            grvPagos.Columns[9].Visible = false;



            foreach (Pago pago in datospago)
            {
                total += pago.Saldo;

            }
            txtDeudatotal.Text = "$" + total;
         }

        private void btnAbonar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAbonar.BackColor = Color.Yellow;
        }

        private void btnAbonar_MouseLeave(object sender, EventArgs e)
        {
            btnAbonar.BackColor = Color.Transparent;
        }

        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalir.BackColor = Color.Red;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Transparent;

        }


        public bool verificarPrecio(String precio)
        {

            Regex rex = new Regex("^[0-9]*$");
            if (rex.IsMatch(precio))
            {
                return true;
            }
            else
            {
                MessageBox.Show("La celda precio solo debe contener numeros");
                return false;
            }
        }

    }
}
