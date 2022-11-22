using CapaDatos;
using CapaEntidad;
using CapaLogica;
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
            listarCliente();
        }
        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void btn_editar_clienteM_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.idCliente = int.Parse(txtidCliente.Text.Trim());
                c.razonSocial = txtRazonSocial.Text.Trim();
                c.idTipoCliente = int.Parse(txtidTipoCliente.Text.Trim());
                c.fecRegCliente = dtPickerRegCliente.Value;
                c.idCiudad = int.Parse(txtidCiudad.Text.Trim());
                c.estCliente = cbkEstadoCliente.Checked;
                logCliente.Instancia.EditaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarCliente();
        }
        private void btn_cancelar_clienteM_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btn_agregar_clienteM_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.razonSocial = txtRazonSocial.Text.Trim();
                c.idTipoCliente = int.Parse(txtidTipoCliente.Text.Trim());
                c.fecRegCliente = dtPickerRegCliente.Value;
                c.idCiudad = int.Parse(txtidCiudad.Text.Trim());
                c.estCliente = cbkEstadoCliente.Checked;
                logCliente.Instancia.InsertaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarCliente();

        }
        private void btn_mostrar_clienteM_Click(object sender, EventArgs e) {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand comando = new SqlCommand("Select * from Cliente", cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvCliente.DataSource = tabla;
        }
        private void btn_nuevo_clienteM_Click(object sender, EventArgs e) {
            txtidCliente.Text = "";
            txtRazonSocial.Text = "";
            txtidTipoCliente.Text = "";
            txtidCiudad.Text = "";
        }
        private void LimpiarVariables()
        {
            txtidCliente.Text = "";
            txtRazonSocial.Text = "";
            txtidTipoCliente.Text = "";
            txtidCiudad.Text = "";
        }
        private void MantenedorCliente_Load(object sender, EventArgs e) { }
        private void dg_muestra_clientesP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
 
        private void dg_muestra_clientesP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex];
            txtidCliente.Text = filaActual.Cells[0].Value.ToString();
            txtRazonSocial.Text = filaActual.Cells[1].Value.ToString();
            txtidTipoCliente.Text = filaActual.Cells[2].Value.ToString();
            txtidCiudad.Text = filaActual.Cells[3].Value.ToString();
            txtidCiudad.Text = filaActual.Cells[4].Value.ToString();
            cbkEstadoCliente.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);



        }
    }
}
