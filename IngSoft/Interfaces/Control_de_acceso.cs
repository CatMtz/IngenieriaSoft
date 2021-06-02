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
    public partial class Control_de_acceso : Form
    {
        public Control_de_acceso()
        {
            InitializeComponent();
            CenterToScreen();
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
          Admin verif= new DAOAdmin().VerificarGerente(txtUsuario.Text, txtContrasenia.Text);
            if (verif != null)
            {
                new Principal(verif.IdGerente).Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrecto");
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_MouseMove(object sender, MouseEventArgs e)
        {
            btnIniciar.BackColor = Color.Yellow;
        }

        private void btnIniciar_MouseLeave(object sender, EventArgs e)
        {
            btnIniciar.BackColor = Color.Transparent;
        }
    }
}
