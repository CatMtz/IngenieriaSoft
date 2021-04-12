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

        private void button1_Click(object sender, EventArgs e)
        {
            Producto nuevo = new Producto(txtNombre.Text, Decimal.Parse(txtPrecio.Text), txtDescripcion.Text,txtCategoria.Text);
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
