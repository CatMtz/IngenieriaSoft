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
    public partial class AñadirCliente : Form
    {
        public AñadirCliente()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text != null && txtApellidos.Text != null &&
                txtDireccion.Text != null && txtTelefono.Text != null)
            {
                if (verificarTel(txtTelefono.Text))
                {
                    Cliente cli = new Cliente(txtNombre.Text + " " + txtApellidos.Text, txtTelefono.Text, txtDireccion.Text);
                    new DAOCliente().registrar(cli);
                    MessageBox.Show("Registro exitoso");
                    txtNombre.Text = "";
                    txtApellidos.Text = "";
                    txtDireccion.Text = "";
                    txtTelefono.Text = "";
                }
                else
                {
                }
            }else
            {
                MessageBox.Show("Uno o varios espacios estan vacios, verifiquelos");

            }
        }

        public bool verificarTel(String tel)
        {

            Regex rex = new Regex("[0-9]{10,10}");
            if (rex.IsMatch(tel))
            {
                return true;
            }else
            {
                MessageBox.Show("El número de telefono es incorrecto, debe contener 10 digitos");
                return false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
