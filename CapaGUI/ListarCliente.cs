using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class ListarCliente : Form
    {
        public ListarCliente()
        {
            InitializeComponent();
            limpiar();
        }

        public void limpiar()
        {
            this.txtRut.Clear();
        }




        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(this.txtRut.Text))
                {
                    NegocioCliente auxNegocio = new NegocioCliente();
                    DGVCliente.DataSource = auxNegocio.listarCliente();
                    
                }
                else
                {
                    NegocioCliente auxNegocio = new NegocioCliente();
                    DGVCliente.DataSource = auxNegocio.buscarCliente(int.Parse(this.txtRut.Text));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void DGVCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
