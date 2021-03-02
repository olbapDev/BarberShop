using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class Menuadm : Form
    {
        public Menuadm()
        {
            InitializeComponent();
        }

        private void mantenedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarCliente pAgregar = new AgregarCliente();
            pAgregar.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarCliente pModificar = new ModificarCliente();
            pModificar.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AgregarBarbero pAgregar = new AgregarBarbero();
            pAgregar.ShowDialog();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCliente pEliminar = new EliminarCliente();
            pEliminar.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarCliente pListar = new ListarCliente();
            pListar.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AgregarServicio pAgregar = new AgregarServicio();
            pAgregar.ShowDialog();
        }
    }
}
