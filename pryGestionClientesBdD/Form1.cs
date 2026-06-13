using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionClientesBdD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarDeudores_Click(object sender, EventArgs e)
        {
            clsCliente x = new clsCliente();
            x.ListarDeudores(dgvDeudores);
            lblCantidadClientess.Text = x.CantidadDeudores.ToString();
            lblTotalDeudaa.Text = x.TotalDeuda.ToString("0.00");
            lblPromedioDeudass.Text = x.PromedioDeuda.ToString("0.00");
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            // cuadro de dialogos guardar archivo
            SaveFileDialog xClientes = new SaveFileDialog();

            xClientes.Title = "Seleccionar carpeta y nombre de archivo";
            xClientes.RestoreDirectory = true;
            xClientes.Filter = "Archivo CSV (*.csv)|*.csv|Archivo de Texto (*.txt)|*.txt";  // pipline(| divide un tipo de otro) --> tipos de archivo q quiero q guarden

            if (xClientes.ShowDialog() == DialogResult.OK)
            {
                clsCliente x = new clsCliente();
                x.ReporteCliente(xClientes.FileName);

                MessageBox.Show("El reporte se generó correctamente.");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            prtDocumento.Print();
            MessageBox.Show("Reporte Impreso Correctamente");
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsCliente x = new clsCliente();
            x.Imprimir(e);

            //  Ejemplo de escritura directa
            Font TipoLetra = new Font("Arial", 12);
            e.Graphics.DrawString("Hola", TipoLetra, Brushes.Blue, 200, 200);

        }
    }
}
