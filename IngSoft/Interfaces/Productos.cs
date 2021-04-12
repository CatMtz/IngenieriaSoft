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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            grvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvProductos.DataSource = null;
            grvProductos.DataSource = new DAOProducto().getAll();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int valorCelda = int.Parse(grvProductos.Rows[grvProductos.CurrentRow.Index].Cells[0].Value.ToString());
            new EditProducto(valorCelda).Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int valorCelda = int.Parse(grvProductos.Rows[grvProductos.CurrentRow.Index].Cells[0].Value.ToString());


        }

        private void menuproductos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
