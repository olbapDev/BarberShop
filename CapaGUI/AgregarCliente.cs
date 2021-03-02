using CapaDTO;
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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        public void limpiarComponentes()
        {
            this.txtRut.Clear();
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtDireccion.Clear();
            this.txtTelefono.Clear();
            

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
                if (String.IsNullOrEmpty(this.txtRut.Text))
                {
                    MessageBox.Show("Falta Rut");
                }
                if (String.IsNullOrEmpty(this.txtNombre.Text))
                {
                    MessageBox.Show("Falta Nombre");
                }
                if (String.IsNullOrEmpty(this.txtApellido.Text))
                {
                    MessageBox.Show("Falta Apellido");
                }
                if (String.IsNullOrEmpty(this.txtDireccion.Text))
                {
                    MessageBox.Show("Falta Direccion");
                }
                if (String.IsNullOrEmpty(this.txtTelefono.Text))
                {
                    MessageBox.Show("Falta Telefono");
                }
                try
                {

                    Cliente auxCliente = new Cliente();
                    NegocioCliente auxNegocio = new NegocioCliente();

                    auxCliente.Rut = int.Parse(this.txtRut.Text);
                    auxCliente.NomCliente = this.txtNombre.Text;
                    auxCliente.ApCliente = this.txtApellido.Text;
                    auxCliente.Direccion = this.txtDireccion.Text;
                    auxCliente.Telefono = int.Parse(this.txtTelefono.Text);

                    auxNegocio.agregarCliente(auxCliente);
                    MessageBox.Show("Datos Guardados Exitosamente");
                    this.limpiarComponentes();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }//fin btn guardar
    }//fin class

}
