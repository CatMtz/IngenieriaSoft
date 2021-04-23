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


        foreach(ReporteDeudas item in lista)
            {
                total += item.Saldo;
            }

            textBox1.Text = "$"+total;

       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
