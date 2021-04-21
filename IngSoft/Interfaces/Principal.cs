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
using IngSoft.Interfaces;

namespace IngSoft.Interfaces
{
    public partial class Principal : Form
    {
        int idGerente = 0;
        public Principal(int idger)
        {
            if (idger > 0)
            {
                InitializeComponent();
                CenterToScreen();
                idGerente = idger;
            }else
            {
                this.Dispose();
              new Control_de_acceso().Visible = true;
            }
        }
     

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            idGerente = 0;
            this.Visible = false;
          new Control_de_acceso().Visible=true;
            this.Dispose();
           
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Admin datos = new DAOAdmin().Datos(idGerente);
            lblGerente.Text = datos.Nombre + " " + datos.Apellidos;

            grvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvClientes.DataSource = null;
            grvClientes.DataSource = new DAOCliente().getAll();
           
        }
        /// <summary>
        /// Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int valorCelda = int.Parse(grvClientes.Rows[grvClientes.CurrentRow.Index].Cells[0].Value.ToString());
            new Pagos(valorCelda).Visible = true;
            this.Visible = false;
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int valorCelda = int.Parse(grvClientes.Rows[grvClientes.CurrentRow.Index].Cells[0].Value.ToString());
            new EditCliente(valorCelda).Show();

        }
        /// <summary>
        /// Producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            new EditarProducto().Show();
            this.Visible = false;
        }

        private void ventaPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new R_VentaMes().Show();
            this.Visible = false;

        }

        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new Productos().Show();
            
        }

        private void Principal_Activated(object sender, EventArgs e)
        {
            grvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvClientes.DataSource = null;
            grvClientes.DataSource = new DAOCliente().getAll();
        }

        private void btnNuevaV_Click(object sender, EventArgs e)
        {
            new NuevaVenta(idGerente).Show();
        }
    }
}
