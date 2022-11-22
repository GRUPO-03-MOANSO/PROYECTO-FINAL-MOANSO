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
using CapaEntidad;
using CapaLogica;
namespace CapaPresentación {
    public partial class MantenedorProveedores : Form    {
        public MantenedorProveedores()  {
            InitializeComponent();
        }
        public void listaProveedor()
        {
            dgv_proveedores.DataSource = logProveedor.Instancia.ListaProveedor();
        }
        private void MantenedorProveedores_Load(object sender, EventArgs e)
        {

        }
        private void btn_ingresar_proovedorP_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor Pro = new entProveedor();
                Pro.NomProveedor = txt_nombre.Text.Trim();
                Pro.TipoProducto = cbx_tipo.Text.Trim();
                logProveedor.Instancia.InsertaProveedor(Pro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listaProveedor();
        }
        private void btn_mostrar_proovedorP_Click(object sender, EventArgs e)
        {
            listaProveedor();
        }
        private void btn_cerrar_proovedorP_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dgv_proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgv_proveedores.Rows[e.RowIndex];
            txt_idproveedor.Text = filaActual.Cells[0].Value.ToString();
            txt_nombre.Text = filaActual.Cells[1].Value.ToString();
            cbx_tipo.Text = filaActual.Cells[2].Value.ToString();
        }

        private void txt_idproveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor Pro = new entProveedor();
                Pro.idProveedor = int.Parse(txt_idproveedor.Text.Trim());
                Pro.NomProveedor = txt_nombre.Text.Trim();
                Pro.TipoProducto = cbx_tipo.Text.Trim();
                logProveedor.Instancia.EditaProveedor(Pro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listaProveedor();
        }
    }
}
