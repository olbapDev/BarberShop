using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class NegocioBarbero
    {
        private ConexionSQL conect;

        public ConexionSQL Conect { get => conect; set => conect = value; }

        public void configurarConexion()
        {
            try
            {
                this.Conect = new ConexionSQL();
                this.Conect.NombreBaseDatos = "Barber";
                this.Conect.NombreTabla = "Barbero";
                this.Conect.CadenaConexion = @"Data Source=DESKTOP-1CIMOES;Initial Catalog=Barber;Integrated Security=True";

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Mensaje Sistema" + ex.Message);
            }
        }//finConfigurarConexion    

        public void agregarBarbero(Barbero barbero)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "INSERT INTO " + this.Conect.NombreTabla
                                      + "(id_barbero, nom_barbero)"
                                      + " VALUES ('" + barbero.IdBarbero + "','" + barbero.NomBarbero
                                      + "');";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }//fin agregar


        public void actualizarBarbero(Barbero barbero)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "UPDATE " + this.Conect.NombreTabla
                                      + " SET "
                                      + "nom_barbero = '" + barbero.NomBarbero
                                      + "WHERE id_barbero = '" + barbero.IdBarbero
                                      + "';";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }//fin actualizarPaciente

        public void eliminarBarbero(int idBarbero)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "DELETE * FROM " + this.Conect.NombreTabla
                                      + " WHERE id_barbero = '" + idBarbero + "';";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin elimiarPaciente





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



    }
}
