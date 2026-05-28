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
    public partial class BusquedaClientes : Form
    {
        public BusquedaClientes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 iDCliente = Convert.ToInt32(txtCodigo.Text);
            clsCliente x = new clsCliente();
            x.Buscar(iDCliente);

            if (x.iDCliente != 0)
            {
                lblNombre.Text = x.Nombre;
                lblDeuda.Text = x.Deuda.ToString();
                lblLimite.Text = x.Limite.ToString();
               
            }
            else
            {
                lblNombre.Text = "";
                lblDeuda.Text = "";
                lblLimite.Text = "";
                MessageBox.Show("No se encontró el cliente");
            }
        }   
    }
}
