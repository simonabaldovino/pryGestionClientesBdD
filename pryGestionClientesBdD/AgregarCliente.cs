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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            clsAutomovil auto = new clsAutomovil();
            auto.Listar(cboAuto);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            clsCliente x = new clsCliente();
            x.Nombre = txtNombre.Text;
            x.Limite = Convert.ToDecimal(txtLimite.Text);
            x.idAutomovil = Convert.ToInt32(cboAuto.SelectedValue);
            x.Agregar();

            MessageBox.Show("Datos grabados!");
            txtNombre.Text = "";
            txtLimite.Text = "";
            cboAuto.SelectedIndex = 0;

        }

        private void btnCargarSQL_Click(object sender, EventArgs e)
        {
            clsCliente x = new clsCliente();
            x.Nombre = txtNombre.Text;
            x.Limite = Convert.ToDecimal(txtLimite.Text);
            x.idAutomovil = Convert.ToInt32(cboAuto.SelectedValue);
            x.AgregarRegistro();

            MessageBox.Show("Datos grabados!");
            txtNombre.Text = "";
            txtLimite.Text = "";
            cboAuto.SelectedIndex = 0;

        }
    }
}
