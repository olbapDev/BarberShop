using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class NegocioPlan
    {
        private ConexionSQL conect;

        public ConexionSQL Conect { get => conect; set => conect = value; }

        public void configurarConexion()
        {
            try
            {
                this.Conect = new ConexionSQL();
                this.Conect.NombreBaseDatos = "Barber";
                this.Conect.NombreTabla = "Plan";
                this.Conect.CadenaConexion = @"Data Source=DESKTOP-1CIMOES;Initial Catalog=Barber;Integrated Security=True";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//finConfigurarConexion    

        public void agregarPlan(Plan plan)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "INSERT INTO " + this.Conect.NombreTabla
                                      + "(id_plan, fecha_plan, estado, valor, rut, id_barbero)"
                                      + " VALUES ('" + plan.IdPlan + "','" + plan.Fecha
                                      + "','" + plan.Estado + "','" + plan.Valor
                                      + "','" + plan.Rut + "','" + plan.IdBarbero + "');";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }//fin agregarPlan


        public void actualizarPlan(Plan plan)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "UPDATE " + this.Conect.NombreTabla
                                      + " SET "
                                      + "fecha_plan = '" + plan.Fecha  + "','"
                                      + "estado ='" + plan.Estado + "','"
                                      + "valor ='" + plan.Valor + "','"
                                      + "id_barbero = '" + plan.IdBarbero + "'"
                                      + " WHERE id_plan = '" + plan.IdPlan + ";";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }//fin actualizarPlan

        public void eliminarPlan(int plan)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "DELETE * FROM " + this.Conect.NombreTabla
                                      + " WHERE id_plan = '" + plan + "';";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Mensaje Sistema" + ex.Message);
            }
        }//fin elimiarPlan


        public DataTable buscarPlan(int rut)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = " SELECT * FROM Plan" 
                                      + " WHERE rut = '"+ rut +"';";
                this.Conect.EsSelect = true;
                this.Conect.conectar();
                return this.Conect.DbDataSet.Tables["Paciente"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje Sistema" + ex.Message);
            }

            return null;

        }//fin ListarPaciente






    }//fin class 

}
