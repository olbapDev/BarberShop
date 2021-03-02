using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaConexion;
using CapaDTO;

namespace CapaNegocio
{
    public class NegocioCliente
    {
        private ConexionSQL conect;

        public ConexionSQL Conect { get => conect; set => conect = value; }

        public void configurarConexion()
        {
            try
            {
                this.Conect = new ConexionSQL();
                this.Conect.NombreBaseDatos = "Barber";
                this.Conect.NombreTabla = "Cliente";
                this.Conect.CadenaConexion = @"Data Source=DESKTOP-1CIMOES;Initial Catalog=Barber;Integrated Security=True";

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Mensaje Sistema" + ex.Message);
            }
        }//finConfigurarConexion    

        public void agregarCliente(Cliente cliente)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "INSERT INTO " + this.Conect.NombreTabla
                                      + "(rut, nom_cliente, ap_cliente, direccion, telefono)"
                                      + " VALUES ('" + cliente.Rut + "','" + cliente.NomCliente
                                      + "','" + cliente.ApCliente + "','" + cliente.Direccion
                                      + "','" + cliente.Telefono + "');";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }//fin agregar


        public void actualizarCliente(Cliente cliente)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "UPDATE " + this.Conect.NombreTabla
                                      + " SET "
                                      + "nom_cliente = '" + cliente.NomCliente + "',"
                                      + "ap_cliente ='" + cliente.ApCliente + "',"
                                      + "direccion ='" + cliente.Direccion + "',"
                                      + "telefono = '" + cliente.Telefono + "'"
                                      + " WHERE rut = '" + cliente.Rut + "';";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }//fin actualizarPaciente

        public void eliminarCliente(int rut)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "DELETE FROM Cliente" 
                                      + " WHERE rut ='" + rut + "';";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Mensaje Sistema" + ex.Message);
            }
        }//fin elimiarPaciente





        public DataTable listarCliente()
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = " SELECT * FROM Cliente; ";
                this.Conect.EsSelect = true;
                this.Conect.conectar();

                return this.Conect.DbDataSet.Tables["Cliente"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;

        }//fin listar

        public DataTable buscarCliente(int rut)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = " SELECT * FROM " + this.Conect.NombreTabla
                                      + " WHERE rut = '" + rut + "';";
                this.Conect.EsSelect = true;
                this.Conect.conectar();

                return this.Conect.DbDataSet.Tables["Cliente"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;


        }//fin listar

        public DataTable buscarNomCliente(int rut)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = " SELECT nom_cliente FROM " + this.Conect.NombreTabla
                                      + " WHERE rut = '" + rut + "';";
                this.Conect.EsSelect = true;
                this.Conect.conectar();

                return this.Conect.DbDataSet.Tables["Cliente"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;


        }//fin listar


        public Cliente retornaDatosCliente(int rut)
        {
            try
            {
                Cliente auxCliente = new Cliente();
                this.configurarConexion();
                this.Conect.CadenaSQL = "SELECT * FROM Cliente;";
                this.Conect.EsSelect = true;
                this.Conect.conectar();

                DataTable dt = new DataTable();
                dt = this.Conect.DbDataSet.Tables[this.Conect.NombreTabla];

                if (dt.Rows.Count > 0)
                {
                    auxCliente.Rut = (int)dt.Rows[0]["Rut"];
                    auxCliente.NomCliente = (string)dt.Rows[0]["nom_cliente"];
                    auxCliente.ApCliente = (string)dt.Rows[0]["ap_cliente"];
                    auxCliente.Direccion = (string)dt.Rows[0]["Direccion"];
                    auxCliente.Telefono = (int)dt.Rows[0]["Telefono"];

                }
                else
                {
                    MessageBox.Show("Error");
                }

                return auxCliente;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;

        }


        //public DataTable listarPaciente()
        //{
        //    try
        //    {
        //        this.configurarConexion();
        //        this.Conect.CadenaSQL = " SELECT P.rut AS Rut, P.dv AS Digito" +
        //            ", P.nom_paciente AS Nombre, P.ap_paciente AS Apellido" +
        //            ", P.direccion, C.nom_comuna AS Comuna" +
        //            " FROM Paciente AS P," +
        //            " Comuna AS C" +
        //            " WHERE C.id_comuna = P.id_Comuna;";
        //        this.Conect.EsSelect = true;
        //        this.Conect.conectar();
        //        return this.Conect.DbDataSet.Tables["Paciente"];
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Mensaje Sistema" + ex.Message);
        //    }

        //    return null;

        //}//fin ListarPaciente


    }//finclass

}
