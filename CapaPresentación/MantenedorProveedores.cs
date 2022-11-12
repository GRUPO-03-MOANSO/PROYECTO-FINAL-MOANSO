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
using CapaDatos; 
namespace CapaPresentación {
    public partial class MantenedorProveedores : Form    {
        public MantenedorProveedores()  {
            InitializeComponent();
        }
        private void mostrar() {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand comando = new SqlCommand("Select * from Proveedores", cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgv_proveedores.DataSource = tabla;
        }
        private void Inserta() {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try  {
                string cm = "Insert Proveedores Values('" + tex_nombre_proovedorP.Text
                   + "','" + tex_tipoproducto_proovedorP.Text + "')";
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand(cm, cn);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
            }
            finally { cmd.Connection.Close(); }
        }
        private void MantenedorProveedores_Load(object sender, EventArgs e)
        {

        }
        private void btn_ingresar_proovedorP_Click(object sender, EventArgs e)
        {
            try {
                Inserta();
                mostrar();
                //Registrado miforma = new Registrado();
                //miforma.ShowDialog();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al Ingresar Datos" + ex);
            }
        }
        private void btn_mostrar_proovedorP_Click(object sender, EventArgs e)
        {
            mostrar();
        }
        private void btn_cerrar_proovedorP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
