using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaDatos;
using System.Data.SqlClient;

namespace CapaPresentación
{
    public partial class MantenedorMantenimiento : Form
    {
        public MantenedorMantenimiento()
        {
            InitializeComponent();
            listarMantenimiento();
            LLenarComboxCliente();  
            LLenarComboxEmpleado();
        }

        public void listarMantenimiento()
        {
            dvgMantenimiento.DataSource = logMantenimiento.Instancia.ListarMantenimiento();
        }

        private void LLenarComboxCliente()
        {
            cmbIDcliente.DataSource = logCliente.Instancia.ListarCliente();

            cmbIDcliente.DisplayMember = "idCliente";
            cmbIDcliente.ValueMember = "idCliente";
        }

        private void LLenarComboxEmpleado()
        {
            cmbIDempleado.DataSource = logEmpleado.Instancia.ListaEmpleados();

            cmbIDempleado.DisplayMember = "idEmpleado";
            cmbIDempleado.ValueMember = "idEmpleado";
        }
        private void btn_nuevo_clienteM_Click(object sender, EventArgs e)
        {
            txtIDmantenimiento.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text ="";
            cmbIDcliente.ResetText();
            cmbIDempleado.ResetText();  
        }

        private void btn_agregar_clienteM_Click(object sender, EventArgs e)
        {
            try
            {
                entMantenimiento c = new entMantenimiento();
                c.idMantenimiento = int.Parse(txtIDmantenimiento.Text.Trim());
                c.fecha = dtFecha.Value;
                c.descripcion = txtDescripcion.Text.Trim();
                c.precio = txtPrecio.Text.Trim();
                c.idCliente = int.Parse(Convert.ToString(cmbIDcliente.SelectedValue));
                c.idEmpleado = int.Parse(Convert.ToString(cmbIDempleado.SelectedValue));
                logMantenimiento.Instancia.InsertarMantenimiento(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarMantenimiento();
        }

        private void btn_mostrar_clienteM_Click(object sender, EventArgs e)
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlCommand comando = new SqlCommand("Select * from Mantenimiento", cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dvgMantenimiento.DataSource = tabla;
        }

        private void btn_editar_clienteM_Click(object sender, EventArgs e)
        {
            try
            {
                entMantenimiento c = new entMantenimiento();
                c.idMantenimiento = int.Parse(txtIDmantenimiento.Text.Trim());
                c.fecha = dtFecha.Value;
                c.descripcion = txtDescripcion.Text.Trim();
                c.precio = txtPrecio.Text.Trim();
                c.idCliente = int.Parse(Convert.ToString(cmbIDcliente.SelectedValue));
                c.idEmpleado = int.Parse(Convert.ToString(cmbIDempleado.SelectedValue));
                logMantenimiento.Instancia.EditarMantenimiento(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listarMantenimiento();
        }

        private void btn_cancelar_clienteM_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
    
}
