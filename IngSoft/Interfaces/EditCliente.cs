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

            if (txtNombre.Text != "" && txtDireccion.Text != "" && txttelefono.Text != "")
            {

                if (verificarCadena(txtNombre.Text) && verificarDireccion(txtDireccion.Text)
                && verificarTel(txttelefono.Text))
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


            }
        }
        private void buttonsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ButtonEditar_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonEditar.BackColor = Color.Yellow;
        }

        private void ButtonEditar_MouseLeave(object sender, EventArgs e)
        {
            ButtonEditar.BackColor = Color.Transparent;
        }

        private void buttonsalir_MouseMove(object sender, MouseEventArgs e)
        {
            buttonsalir.BackColor = Color.Red;
        }

        private void buttonsalir_MouseLeave(object sender, EventArgs e)
        {
            buttonsalir.BackColor = Color.Transparent;
        }




        public bool verificarTel(String tel)
        {

            Regex rex = new Regex("^[0-9]{10,10}$");
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
            }
            else
            {
                MessageBox.Show("El nombre solo debe tener letras (Maximo 30 caracteres)");

                return false;
            }
        }
        
        public bool verificarDireccion(String Direc)
        {
            Regex rex = new Regex("^[a-zA-Z\\s]{1,40}$");
            if (rex.IsMatch(Direc))
            {
                return true;
            }
            else
            {
                MessageBox.Show("La dirección debe tener maximo 40 caracteres");

                return false;
            }

        }
    }
}
