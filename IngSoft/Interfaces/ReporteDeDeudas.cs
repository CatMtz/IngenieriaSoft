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
using System.Data;
using BackEnd.MODELOS;

namespace IngSoft.Interfaces
{
    public partial class ReporteDeDeudas : Form
    {
        public ReporteDeDeudas()
        {
            InitializeComponent();
        }

        private void ReporteDeDeudas_Load(object sender, EventArgs e)
        {
            Decimal total=0;
            List<ReporteDeudas> lista = new DAOReporte().getAllReporteDeudas();
            grvdeudas.DataSource = null;
            grvdeudas.DataSource = lista;
            grvdeudas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grvdeudas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grvdeudas.ForeColor = Color.Black;
            grvdeudas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            grvdeudas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            foreach (ReporteDeudas item in lista)
            {
                total += item.Saldo;
            }

            textBox1.Text = "$"+total;

       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Transparent;
        }

        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalir.BackColor = Color.Red;

        }
    }
}
