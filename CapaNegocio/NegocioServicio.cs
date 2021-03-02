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
    public class NegocioServicio
    {
        private ConexionSQL conect;

        public ConexionSQL Conect { get => conect; set => conect = value; }

        public void configurarConexion()
        {
            try
            {
                this.Conect = new ConexionSQL();
                this.Conect.NombreBaseDatos = "Barber";
                this.Conect.NombreTabla = "Servicio";
                this.Conect.CadenaConexion = @"Data Source=DESKTOP-1CIMOES;Initial Catalog=Barber;Integrated Security=True";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//finConfigurarConexion    

        public void agregarServicio(Servicio servicio)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "INSERT INTO " + this.Conect.NombreTabla
                                      + "(id_servicio, nom_servicio, descripcion, precioBase, tipo_servicio)"
                                      + " VALUES ('" + servicio.IdServicio + "','" + servicio.NomServicio
                                      + "','" + servicio.Descripcion + "','" + servicio.PrecioBase
                                      + "','" + servicio.TipoServicio + "');";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }//fin agregar


        public void actualizarServicio(Servicio servicio)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "UPDATE " + this.Conect.NombreTabla
                                      + " SET "
                                      + "nom_servicio = '" + servicio.NomServicio + "','"
                                      + "descripcion ='" + servicio.Descripcion + "','"
                                      + "precioBase ='" + servicio.PrecioBase + "','"
                                      + "tipo_servicio = '" + servicio.TipoServicio + "'"
                                      + " WHERE id_servicio = '" + servicio.IdServicio + ";";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }//fin actualizarPaciente

        public void eliminarServicio(int idServicio)
        {
            try
            {
                this.configurarConexion();
                this.Conect.CadenaSQL = "DELETE * FROM " + this.Conect.NombreTabla
                                      + " WHERE id_servicio = '" + idServicio
                                      + "';";
                this.Conect.EsSelect = false;
                this.Conect.conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
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
