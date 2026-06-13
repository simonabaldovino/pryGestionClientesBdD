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
    public partial class ClientesFor_Each : Form
    {
        public ClientesFor_Each()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsCliente x = new clsCliente();
            x.ListarForEach(dgvClientes);
        }
    }
}
