using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd.DAOS;
using BackEnd.MODELOS;

namespace IngSoft.Interfaces
{
    public partial class Añadir_Producto : Form
    {
        public Añadir_Producto()
        {
            InitializeComponent();
        }

      

        private void agregar_Click(object sender, EventArgs e)
        {
            try
            {

                if(txtNombre.Text!="" && txtPrecio.Text!= "" && txtDescripcion.Text!= "" && txtCategoria.Text != "")
                {
                    if (verificar(txtPrecio.Text))
                    {
                        Producto prod = new Producto(txtNombre.Text, Decimal.Parse(txtPrecio.Text), txtDescripcion.Text, txtCategoria.Text);
                        new DAOProducto().registrar(prod);
                        MessageBox.Show("Se registro el producto con exito");
                        txtNombre.Text = "";
                        txtPrecio.Text = "";
                        txtCategoria.Text = "";
                        txtDescripcion.Text = "";
                    }
                   
                }
                else
                {
                    MessageBox.Show("Verifique que todos los espacios esten llenos");
                }


            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Salir_MouseMove(object sender, MouseEventArgs e)
        {
            Salir.BackColor = Color.Red;
        }

        private void Salir_MouseLeave(object sender, EventArgs e)
        {
            Salir.BackColor = Color.Transparent;

        }

        private void agregar_MouseLeave(object sender, EventArgs e)
        {
            agregar.BackColor = Color.Green;

        }

        private void agregar_MouseMove(object sender, MouseEventArgs e)
        {
            Salir.BackColor = Color.Transparent;

        }


        public bool verificar(String precio)
        {

            Regex rex = new Regex("[0-9]*");
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
