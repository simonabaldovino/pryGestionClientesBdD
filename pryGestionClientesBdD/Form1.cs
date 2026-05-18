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
            lblCantClientes.Text = x.CantidadDeudores.ToString();
            lblTotDeuda.Text = x.TotalDeuda.ToString("0.00");
            lblPromDeuda.Text = x.PromedioDeuda.ToString("0.00");
        }
    }
}
