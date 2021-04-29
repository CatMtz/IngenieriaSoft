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
            grvVenta.DataSource = new DAOReporte().getAllReporteVentaMes(dtpFecha.);



            grvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grvVenta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grvVenta.ForeColor = Color.Black;
            grvVenta.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            grvVenta.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
    }
}
