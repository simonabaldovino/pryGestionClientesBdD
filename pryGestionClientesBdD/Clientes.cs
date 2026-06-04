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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmListadoClientes();
            formulario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listadoDeClientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
        }

        private void listadoDeClientesOrdenadosPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new BusquedaClientes();
            formulario.Show();
        }

        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new AgregarCliente();
            formulario.Show();
        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmEditarCliente();
            formulario.Show();
        }
    }
}
