using CapaDTO;
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
    public partial class AgregarBarbero : Form
    {
        public AgregarBarbero()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Barbero auxBarbero = new Barbero();




            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }




        }
    }
}
