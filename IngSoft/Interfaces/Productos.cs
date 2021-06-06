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
            CenterToScreen();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            grvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvProductos.DataSource = null;
            grvProductos.DataSource = new DAOProducto().getAll();
            grvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grvProductos.ForeColor = Color.Black;
            grvProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            grvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            grvProductos.Columns.Add(btn);
            btn.Text = "Editar";
            btn.Name = "ColEditar";
       
            grvProductos.Columns.Add(btn1);
            btn1.Text = "Eliminar";
            btn1.Name = "ColEliminar";

            btn.UseColumnTextForButtonValue = true;
            btn1.UseColumnTextForButtonValue = true;

        }


       
        // int valorCelda = int.Parse(grvProductos.Rows[grvProductos.CurrentRow.Index].Cells[0].Value.ToString());


        private void buttonsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonsalir_MouseLeave(object sender, EventArgs e)
        {
            buttonsalir.BackColor = Color.Transparent;

        }

        private void buttonsalir_MouseMove(object sender, MouseEventArgs e)
        {
            buttonsalir.BackColor = Color.Red;
        }

        private void grvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int valorCelda = int.Parse(grvProductos.Rows[grvProductos.CurrentRow.Index].Cells[0].Value.ToString());
                new EditProducto(valorCelda).Show();

                actualizar();
                

            }
            if (e.ColumnIndex == 6)
            {
                int valorCelda = int.Parse(grvProductos.Rows[grvProductos.CurrentRow.Index].Cells[0].Value.ToString());
                if(new DAOProducto().Eliminar(valorCelda))
                {
                    MessageBox.Show("Se elimino con exito el producto");
                    actualizar();
                }else
                {
                    MessageBox.Show("Hubo un error al eliminar el producto");
                }

            }
        }
       public void actualizar()
        {
            grvProductos.Columns.Remove("ColEliminar");
            grvProductos.Columns.Remove("ColEditar");
            grvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvProductos.DataSource = null;
            grvProductos.DataSource = new DAOProducto().getAll();
            grvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grvProductos.ForeColor = Color.Black;
            grvProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            grvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            grvProductos.Columns.Add(btn);
            btn.Text = "Editar";
            btn.Name = "ColEditar";

            grvProductos.Columns.Add(btn1);
            btn1.Text = "Eliminar";
            btn1.Name = "ColEliminar";

            btn.UseColumnTextForButtonValue = true;
            btn1.UseColumnTextForButtonValue = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new Añadir_Producto().Show();

        }

        private void btnAgregaar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAgregaar.BackColor = Color.Yellow;
        }

        private void btnAgregaar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregaar.BackColor = Color.Transparent;
        }
    }
       
}
