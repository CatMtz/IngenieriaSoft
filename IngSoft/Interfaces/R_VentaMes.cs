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
    public partial class R_VentaMes : Form
    {
        public R_VentaMes()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void R_VentaMes_Load(object sender, EventArgs e)
        {

            grvVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvVenta.DataSource = null;
            
            grvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grvVenta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grvVenta.ForeColor = Color.Black;
            grvVenta.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            grvVenta.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void ButtonSalir_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonSalir.BackColor = Color.Red;
        }

        private void ButtonSalir_MouseLeave(object sender, EventArgs e)
        {
            ButtonSalir.BackColor = Color.Transparent;

        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decimal total = 0;
            int fec =int.Parse(DTPFecha.Value.Month.ToString());
            List<ReporteVentaMes> list= new DAOReporte().getAllReporteVentaMes(fec);
            if (list.Count > 0)
            {
                
                grvVenta.DataSource = null;
                grvVenta.DataSource = list;

                foreach (ReporteVentaMes item in list)
                {
                    total += item.TotalProducto;
                }
                txtTotal.Text = "$" + total;


            }
            else
            {
                grvVenta.DataSource = null;
            }
           
        }
    }
}
