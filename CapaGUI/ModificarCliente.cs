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
    public partial class ModificarCliente : Form
    {
        public ModificarCliente()
        {
            InitializeComponent();
            this.iniciar();
            this.limpiar();
        }
        private void ModificarCliente_Load(object sender, EventArgs e)
        {

        }

        public void iniciar()
        {
            this.btnModificar.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtDireccion.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtApellido.Enabled = false;
            this.txtRut.Enabled = true;
            this.btnSalir.Enabled = true;
            this.btnBuscar.Enabled = true;

        }

        public void limpiar()
        {
            this.txtNombre.Text = "";
            this.txtRut.Text = "";
            this.txtApellido.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";

        }
        public void buscar()
        {
            this.txtRut.Enabled = false;
            this.txtNombre.Enabled = true;
            this.txtDireccion.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.txtApellido.Enabled = true;
            this.btnSalir.Enabled = false;
        }

        public void habilitar()
        {
            this.btnBuscar.Enabled = false;
            this.btnModificar.Enabled = true;
            
        }




        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                Cliente auxCliente = new Cliente();
                NegocioCliente auxNegocio = new NegocioCliente();
                auxNegocio.buscarCliente(int.Parse(this.txtRut.Text));
                auxCliente = auxNegocio.retornaDatosCliente(int.Parse(this.txtRut.Text));
                this.buscar();
                this.txtNombre.Text = auxCliente.NomCliente;
                this.txtApellido.Text = auxCliente.ApCliente;
                this.txtDireccion.Text = auxCliente.Direccion;
                this.txtTelefono.Text = auxCliente.Telefono.ToString();
                this.habilitar();
             
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }//fin btn buscar

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            { 
                NegocioCliente auxNegocio = new NegocioCliente();
                Cliente auxCliente = new Cliente();
                auxCliente.Rut = int.Parse(this.txtRut.Text);
                auxCliente.NomCliente = this.txtNombre.Text;
                auxCliente.ApCliente = this.txtApellido.Text;
                auxCliente.Direccion = this.txtDireccion.Text;
                auxCliente.Telefono = int.Parse(this.txtTelefono.Text);

                try
                {
                    auxNegocio.actualizarCliente(auxCliente);
                    MessageBox.Show("Datos Actualizados Exitosamente.");
                    this.limpiar();
                    this.iniciar();
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



        }//Fin MOdificar

    }//FinClass

}
