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
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = txtCodigo.Text;
            lblNombre.Text = "";
            btnBuscar.Enabled = false;

            Int32 iDCliente = Convert.ToInt32(txtCodigo.Text);
            clsCliente x = new clsCliente();
            x.Buscar(iDCliente);

            if (x.iDCliente != 0)
            {
                lblNombre.Text = x.Nombre;
                lblDeuda.Text = x.Deuda.ToString();
                txtLimite.Text = x.Limite.ToString();

            }
            else
            {
                lblNombre.Text = "";
                lblDeuda.Text = "";
                txtLimite.Text = "";
                MessageBox.Show("No se encontró el cliente");
            }
            txtCodigo.Clear();
            btnBuscar.Enabled = false;
            txtLimite.ReadOnly = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;


        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false; 
            }
        }

        private void lblModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            txtLimite.ReadOnly = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsCliente x = new clsCliente();
            Int32 id = Convert.ToInt32(txtCodigo.Text);

            x.Limite = Convert.ToDecimal(txtLimite.Text);
            x.Modificar(id);
            MessageBox.Show("El dato se cambio correctamente");
        }
    }
}
