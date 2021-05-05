using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd.MODELOS;
using BackEnd.DAOS;

namespace IngSoft.Interfaces
{
    public partial class Reporte_de_Productos_Vendidos : Form
    {
        
        public Reporte_de_Productos_Vendidos()
        {
            InitializeComponent();
        }

    

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            String fec = dtpFecha.Value.Year.ToString() +"-"+ dtpFecha.Value.Month.ToString() + "-" + dtpFecha.Value.Day.ToString();
            try
            {
                Decimal total = 0;
                List<ReporteProductosVendidos> lista = new DAOReporte().getAllReporteProductos(fec);
                if (lista.Count > 0)
                {
                    grvReporte.DataSource = null;
                    grvReporte.DataSource = lista;
                    foreach (ReporteProductosVendidos item in lista)
                    {
                        total += item.Total;
                    }
                    txtTotal.Text = "$" + total;
                }
                else
                {
                    MessageBox.Show("Error al verificar el reporte");
                }

            }
            catch (Exception ex)
            {

                throw;
            }
          
          

        }

        private void buttonsalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Transparent;

        }

        private void buttonsalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalir.BackColor = Color.Red;

        }

        private void Reporte_de_Productos_Vendidos_Load(object sender, EventArgs e)
        {

        }
    }
}
