using CapaNegocio;
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
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
            this.habilitar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();

        }

        public void modificar()
        {
            this.btnBuscar.Enabled = false;
            this.btnEliminar.Enabled = true;
        }
        
        public void habilitar()
        {
            this.txtRut.Text = "";
            this.btnBuscar.Enabled = true;
            this.btnEliminar.Enabled = false;
        }
       


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(this.txtRut.Text))
                {
                    MessageBox.Show("Falta rut para eliminar");
                }

                NegocioCliente auxNegocio = new NegocioCliente();

                DGVCliente.DataSource = auxNegocio.buscarCliente(int.Parse(this.txtRut.Text));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.modificar();
        }//fin btn buscar

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {

                NegocioCliente auxNegocio = new NegocioCliente();
                auxNegocio.eliminarCliente(int.Parse(this.txtRut.Text));

                MessageBox.Show("Datos eliminados correctamente");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            this.habilitar();

        }//fin btn eliminar
    }
}
