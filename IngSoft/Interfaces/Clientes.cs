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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            grvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grvClientes.DataSource = null;
            grvClientes.DataSource = new DAOCliente().getAllClientes();
            grvClientes.Columns[4].Visible = false;
            grvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grvClientes.ForeColor = Color.Black;
            grvClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            grvClientes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            grvClientes.Columns.Add(btn);
            btn.Text = "Editar";
            btn.Name = "ColEditar";

            grvClientes.Columns.Add(btn1);
            btn1.Text = "Eliminar";
            btn1.Name = "ColEliminar";

            btn.UseColumnTextForButtonValue = true;
            btn1.UseColumnTextForButtonValue = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int valorCelda = int.Parse(grvClientes.Rows[grvClientes.CurrentRow.Index].Cells[0].Value.ToString());
                new EditCliente(valorCelda).Show();

                actualizar();


            }
            if (e.ColumnIndex == 6)
            {
                //int valorCelda = int.Parse(grvClientes.Rows[grvClientes.CurrentRow.Index].Cells[0].Value.ToString());
                //if (new DAOProducto().Eliminar(valorCelda))
                //{
                //    MessageBox.Show("Se elimino con exito el producto");
                //    actualizar();
                //}

            }
        }




        public void actualizar()
        {
            grvClientes.Columns.Remove("ColEliminar");
            grvClientes.Columns.Remove("ColEditar");
            grvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvClientes.DataSource = null;
            grvClientes.DataSource = new DAOCliente().getAllClientes();
            grvClientes.Columns[4].Visible = false;
            grvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grvClientes.ForeColor = Color.Black;
            grvClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            grvClientes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            grvClientes.Columns.Add(btn);
            btn.Text = "Editar";
            btn.Name = "ColEditar";

            grvClientes.Columns.Add(btn1);
            btn1.Text = "Eliminar";
            btn1.Name = "ColEliminar";

            btn.UseColumnTextForButtonValue = true;
            btn1.UseColumnTextForButtonValue = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AñadirCliente().Show();
        }
    }
}
