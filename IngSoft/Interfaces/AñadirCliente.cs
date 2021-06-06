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
                if (verificarCadena(txtNombre.Text+" "+txtApellidos.Text) && verificarDireccion(txtDireccion.Text))
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
                } else
                {
                    MessageBox.Show("Los espacios, a excepción de telefono deben incluir solo letras (Maximo 30 carcateres)");
                }

            } else
            {
                MessageBox.Show("Uno o varios espacios estan vacios, verifiquelos");

            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAñadir_MouseMove(object sender, MouseEventArgs e)
        {
            btnAñadir.BackColor = Color.Yellow;
        }

        private void btnAñadir_MouseLeave(object sender, EventArgs e)
        {
            btnAñadir.BackColor = Color.Transparent;
        }

        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalir.BackColor = Color.Yellow;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Transparent;
        }

        public bool verificarTel(String tel)
        {

            Regex rex = new Regex("[0-9]{10,10}");
            if (rex.IsMatch(tel))
            {
                return true;
            }
            else
            {
                MessageBox.Show("El número de telefono es incorrecto, debe contener 10 digitos");
                return false;
            }

        }

        public bool verificarCadena(String Nombre)
        {
            Regex rex = new Regex("^[a-zA-Z\\s]{1,30}$");
            if (rex.IsMatch(Nombre))
            {
                return true;
            }else
            {
                MessageBox.Show("El nombre solo debe tener letras (Maximo 30 caracteres)");
                return false;
            }

        }
        public bool verificarDireccion(String Direc)
        {
            Regex rex = new Regex("^[0-9a-zA-Z\\s]{1,40}$");
            if (rex.IsMatch(Direc.Trim()))
            {
                return true;
            }
            else
            {
                MessageBox.Show("La dirección debe tener maximo 30 caracteres");
                return false;
            }

        }
        //5 de mayo
        //20 de noviembre
        //prolongacion hidalgo
        //201 escuadron
    }
}
