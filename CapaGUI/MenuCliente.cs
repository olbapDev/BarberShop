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
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void modificarPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cambiarServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarPlan pModificar = new ModificarPlan();
            pModificar.ShowDialog();
        }
    }
}
