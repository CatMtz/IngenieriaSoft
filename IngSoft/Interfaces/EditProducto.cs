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
    public partial class EditProducto : Form
    {
        int id = 0;
     
        public EditProducto(int idprod)
        {
           
            InitializeComponent();
            id = idprod;
            CenterToScreen();
        }

        private void EditProducto_Load(object sender, EventArgs e)
        {
            List<Producto> lista = new DAOProducto().getOne(id);
            txtNombre.Text = lista[0].Nombre;
            txtPrecio.Text = ""+ lista[0].Precio;
            txtCategoria.Text = lista[0].Categoria;
            txtDescripcion.Text = lista[0].Descripcion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
         
            if (txtNombre.Text != "" && txtPrecio.Text != "" && txtDescripcion.Text != "" && txtCategoria.Text != "")
            {
                if (verificarNombre(txtNombre.Text) && verificarCategoria(txtCategoria.Text)
                && verificarDescripcion(txtDescripcion.Text) && verificarPrecio(txtPrecio.Text))
                {
                    Producto nuevo = new Producto(txtNombre.Text, Decimal.Parse(txtPrecio.Text), txtDescripcion.Text, txtCategoria.Text);
                    if (new DAOProducto().editar(nuevo, id))
                    {
                        MessageBox.Show("Actualización exitosa");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error");
                    }
                }
            }
        }

        private void btnEditar_MouseMove(object sender, MouseEventArgs e)
        {
            btnEditar.BackColor = Color.Yellow;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.BackColor = Color.Transparent;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Transparent;

        }


        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalir.BackColor = Color.Red;
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
        public bool verificarNombre(String Nombre)
        {
            Regex rex = new Regex("[a-zA-Z]{1,35}");
            if (rex.IsMatch(Nombre))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El nombre solo debe tener letras");
                return false;
            }
        }
        public bool verificarCategoria(String Categoria)
        {
            Regex rex = new Regex("[a-zA-Z]{1,15}");
            if (rex.IsMatch(Categoria))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Categoria solo letras (Maximo 15 caracteres)");
                return false;
            }
        }
        public bool verificarDescripcion(String Descripcion)
        {
            Regex rex = new Regex("[a-zA-Z]{1,50}");
            if (rex.IsMatch(Descripcion))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Descripcion solo letras (Maximo 50 caracteres)");
                return false;
            }
        }
    }

}
