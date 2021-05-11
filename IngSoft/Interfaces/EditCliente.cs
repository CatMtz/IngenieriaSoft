using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd.DAOS;
using BackEnd.MODELOS;

namespace IngSoft.Interfaces
{
    public partial class EditCliente : Form
    {
        int id = 0;
        public EditCliente(int idcliente)
        {
            InitializeComponent();
            id = idcliente;
            CenterToScreen();
        }

        private void EditCliente_Load(object sender, EventArgs e)
        {
            Cliente lista=  new DAOCliente().getOne(id);
            txtNombre.Text = lista.Nombre;
            txttelefono.Text = lista.Telefono;
            txtDireccion.Text = lista.Direccion;
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente(txtNombre.Text, txttelefono.Text, txtDireccion.Text);
            if (new DAOCliente().editar(nuevo, id))
            {
             MessageBox.Show("Actualización exitosa");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void buttonsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
