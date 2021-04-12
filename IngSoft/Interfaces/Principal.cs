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

namespace IngSoft.Interfaces
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

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
            string valorCelda = grvClientes.Rows[grvClientes.CurrentRow.Index].Cells[0].Value.ToString();
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
             
            //new EditarProducto().Show();
            //this.Visible = false;
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
    }
}
