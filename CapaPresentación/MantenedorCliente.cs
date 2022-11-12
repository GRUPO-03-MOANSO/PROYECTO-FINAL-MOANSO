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
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void editar_Cliente(int id)
        {
            SqlCommand cmd = null;
            try
            {
                string cm = "Update Clientes set Nombres='" + text_nombre_clienteP.Text
                   + "',Apellidos='" + text_apellidos_clienteP.Text + "',Tipo_Cliente='" +
                   text_tipocliente_clienteP.Text + "',DNI='" + text_dni_clienteP.Text + "',Sexo=" +
                   cbm_sexo_clienteP.GetItemText(cbm_sexo_clienteP.SelectedIndex).ToString() + ",Estado='" +
                   cbm_estado_clienteP.GetItemText(cbm_estado_clienteP.SelectedIndex).ToString() + "' where id=" + id;
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand(cm, cn);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cmd.Connection.Close(); }
        }
        private void btn_editar_clienteM_Click(object sender, EventArgs e)
        {
            int id = int.Parse(text_idcliente_clienteP.Text);
            editar_Cliente(id);
        }
        private void btn_cancelar_clienteM_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_agregar_clienteM_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            try
            {
                string cm = "Insert Clientes Values('" + text_nombre_clienteP.Text
                   + "','" + text_apellidos_clienteP.Text + "','" + text_tipocliente_clienteP.Text +
                   "','" + text_dni_clienteP.Text + "'," + cbm_sexo_clienteP.GetItemText(cbm_sexo_clienteP.SelectedIndex).ToString() 
                   + ",'" + cbm_estado_clienteP.GetItemText(cbm_estado_clienteP.SelectedIndex).ToString() + "')";
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand(cm, cn);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
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
        private void btn_mostrar_clienteM_Click(object sender, EventArgs e) {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand comando = new SqlCommand("Select * from Clientes", cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dg_muestra_clientesP.DataSource = tabla;
        }
        private void btn_nuevo_clienteM_Click(object sender, EventArgs e) {
            text_nombre_clienteP.Text = "";
            text_apellidos_clienteP.Text = "";
            text_tipocliente_clienteP.Text = "";
            text_dni_clienteP.Text = "";
            cbm_sexo_clienteP.SelectedIndex = 0;
            cbm_estado_clienteP.SelectedIndex = 0;
        }
        private void MantenedorCliente_Load(object sender, EventArgs e) { }
        private void dg_muestra_clientesP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Fila = dg_muestra_clientesP.Rows[e.RowIndex];
            text_idcliente_clienteP.Text = Fila.Cells[0].Value.ToString();
            text_nombre_clienteP.Text = Fila.Cells[1].Value.ToString();
            text_apellidos_clienteP.Text = Fila.Cells[2].Value.ToString();
            text_tipocliente_clienteP.Text = Fila.Cells[3].Value.ToString();
            text_dni_clienteP.Text = Fila.Cells[4].Value.ToString();
        }
    }
}
