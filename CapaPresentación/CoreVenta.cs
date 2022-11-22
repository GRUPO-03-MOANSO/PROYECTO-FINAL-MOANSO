using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CapaPresentación {
    public partial class CoreVenta : Form {
        public CoreVenta()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)  { }

        private void mostrar()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand comando = new SqlCommand("Select * from Ventiña", cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            panel_venta_p.DataSource = tabla;
        }
        private void Inserta()
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                string cm = "Insert Ventiña Values('" +  txt_s_productoP.Text + "','" + txt_tipo_pagoP.Text + "','" +
                   txt_cantidad_P.Text + "','" + txt_fecha_reg_venP.Text + "')"; 
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand(cm, cn);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            //this.Close();
            Dispose();

        }
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                Inserta();
                mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos" + ex);
            }
        }
        private void CoreVenta_Load(object sender, EventArgs e)
        {
        }
        private void btn_mostrar_ventasP_Click(object sender, EventArgs e)
        {
            mostrar();
        }
        private void btn_limpiar_registro_Click(object sender, EventArgs e)
        {
            txt_s_productoP.Text = "";
            txt_tipo_pagoP.Text = "";
            txt_idventas_P.Text = "";
            txt_cantidad_P.Text = "";
            txt_fecha_reg_venP.Text = "";
        }

        private void txt_s_productoP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
