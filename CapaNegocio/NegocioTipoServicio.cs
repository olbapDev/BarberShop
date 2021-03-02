using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaConexion;
using CapaDTO;

namespace CapaNegocio
{
    public class NegocioTipoServicio
    {
        private ConexionSQL conect;

        public ConexionSQL Conect { get => conect; set => conect = value; }

        public void configurarConexion()
        {
            try
            {
                this.Conect = new ConexionSQL();
                this.Conect.NombreBaseDatos = "Barber";
                this.Conect.NombreTabla = "Tipo_Servicio";
                this.Conect.CadenaConexion = @"Data Source=DESKTOP-1CIMOES;Initial Catalog=Barber;Integrated Security=True";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//finConfigurarConexion    

        public void agregarTipo(Tipo tipo)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "INSERT INTO " + this.Conect.NombreTabla
                                      + "(tipo_servicio, nom_servicio, descripcion)"
                                      + " VALUES ('" + tipo.IdTipo + "','" + tipo.NomTipo
                                      + "','" + tipo.Descripcion + "');";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }//fin agregarTipo


        public void actualizarTipo(Tipo tipo)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "UPDATE " + this.Conect.NombreTabla
                                      + " SET "
                                      + "nom_servicio = '" + tipo.NomTipo + "','"
                                      + "descripcion ='" + tipo.Descripcion + "' "
                                      + " WHERE tipo_servicio = '" + tipo.IdTipo + ";";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }//fin actualizarTipo

        public void eliminarTipo(int idTipo)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "DELETE  FROM " + this.Conect.NombreTabla
                                      + " WHERE tipo_servicio = '" + idTipo + "';";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin eliminar tipo






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
