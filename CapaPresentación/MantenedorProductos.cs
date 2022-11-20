using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaPresentación
{
    public partial class MantenedorProductos : Form
    {
        public MantenedorProductos()
        {
            InitializeComponent();
        }

        private void dgvListadoProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            MostrarProductos();
        }
        private void MostrarProductos()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand comando = new SqlCommand("Select * from Productos", cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvListadoProductos.DataSource = tabla;
        }

        private void btnAtrasProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
