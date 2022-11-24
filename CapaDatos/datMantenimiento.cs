using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
namespace CapaDatos
{
    public class datMantenimiento
    {
        #region sigleton
        
        private static readonly datMantenimiento _instancia = new datMantenimiento();
        
        public static datMantenimiento Instancia
        {
            get
            {
                return datMantenimiento._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Mantenimiento
        public List<entMantenimiento> ListarMantenimiento()
        {
            SqlCommand cmd = null;
            List<entMantenimiento> lista = new List<entMantenimiento>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarMantenimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMantenimiento Cli = new entMantenimiento();
                    Cli.idMantenimiento = Convert.ToInt32(dr["idMantenimiento"]);
                    Cli.fecha = Convert.ToDateTime(dr["fecha"]); ;
                    Cli.descripcion = dr["descripcion"].ToString();
                    Cli.precio = dr["precio"].ToString();
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    lista.Add(Cli);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;

        }
        //InsertarMantenimiento
        public Boolean InsertarMantenimiento(entMantenimiento Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMantenimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMantenimiento", Cli.idMantenimiento);
                cmd.Parameters.AddWithValue("@fecha", Cli.fecha);
                cmd.Parameters.AddWithValue("@descripcion", Cli.descripcion);
                cmd.Parameters.AddWithValue("@precio", Cli.precio);
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cmd.Parameters.AddWithValue("@idEmpleado", Cli.idEmpleado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        //////////////////////////////////EditarMantenimiento
        public Boolean EditarMantenimiento(entMantenimiento Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarMantenimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMantenimiento", Cli.idMantenimiento);
                cmd.Parameters.AddWithValue("@fecha", Cli.fecha);
                cmd.Parameters.AddWithValue("@descripcion", Cli.descripcion);
                cmd.Parameters.AddWithValue("@precio", Cli.precio);
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cmd.Parameters.AddWithValue("@idEmpleado", Cli.idEmpleado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        #endregion metodos
    }
}
