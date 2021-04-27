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
            buttonsalir.BackColor = Color.Silver;

        }

        private void buttonsalir_MouseMove(object sender, MouseEventArgs e)
        {
            buttonsalir.BackColor = Color.Red;
        }

        private void grvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                MessageBox.Show("Editar");
                int valorCelda = int.Parse(grvProductos.Rows[grvProductos.CurrentRow.Index].Cells[0].Value.ToString());
                new EditProducto(valorCelda).Show();

            }
            if (e.ColumnIndex == 6)
            {

                MessageBox.Show("Eliminar");

            }
        }

        //private void grvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        //{
        //    try
        //    {
        //        if (e.ColumnIndex >= 0 && this.grvProductos.Columns[e.ColumnIndex].Name == "ColEditar" && e.RowIndex >= 0)
        //        {
        //            e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        //            DataGridViewButtonCell celBotonedit = this.grvProductos.Rows[e.RowIndex].Cells["ColEditar"] as DataGridViewButtonCell;
        //            Icon editar = new Icon(@"iconos\\Eliminar.ico");
        //            e.Graphics.DrawIcon(editar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);


        //            this.grvProductos.Rows[e.RowIndex].Height = editar.Height+5;
        //            this.grvProductos.Columns[e.ColumnIndex].Width = editar.Width +5;
        //            e.Handled = true;

        //        }
        //        if (e.ColumnIndex >= 0 && this.grvProductos.Columns[e.ColumnIndex].Name == "ColEliminar" && e.RowIndex >= 0)
        //        {
        //            e.Paint(e.CellBounds, DataGridViewPaintParts.All);



        //            DataGridViewButtonCell celBotoneli = this.grvProductos.Rows[e.RowIndex].Cells["ColEliminar"] as DataGridViewButtonCell;
        //            Icon eliminar = new Icon(@"iconos\\Eliminar.ico");
        //            e.Graphics.DrawIcon(eliminar, e.CellBounds.Left + 5, e.CellBounds.Top + 5);



        //            this.grvProductos.Rows[e.RowIndex].Height = eliminar.Height + 5;
        //            this.grvProductos.Columns[e.ColumnIndex].Width = eliminar.Width + 5;

        //            e.Handled = true;
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }

        //}
    }
}
