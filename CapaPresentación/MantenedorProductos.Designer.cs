namespace CapaPresentación
{
    partial class MantenedorProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAtrasProductos = new System.Windows.Forms.Button();
            this.dgvListadoProductos = new System.Windows.Forms.DataGridView();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStockProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtIdP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtrasProductos
            // 
            this.btnAtrasProductos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAtrasProductos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAtrasProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAtrasProductos.Location = new System.Drawing.Point(881, 470);
            this.btnAtrasProductos.Name = "btnAtrasProductos";
            this.btnAtrasProductos.Size = new System.Drawing.Size(127, 57);
            this.btnAtrasProductos.TabIndex = 15;
            this.btnAtrasProductos.Text = "Regresar";
            this.btnAtrasProductos.UseVisualStyleBackColor = false;
            this.btnAtrasProductos.Click += new System.EventHandler(this.btnAtrasProductos_Click);
            // 
            // dgvListadoProductos
            // 
            this.dgvListadoProductos.AllowUserToOrderColumns = true;
            this.dgvListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProductos.Location = new System.Drawing.Point(12, 112);
            this.dgvListadoProductos.Name = "dgvListadoProductos";
            this.dgvListadoProductos.RowHeadersWidth = 51;
            this.dgvListadoProductos.Size = new System.Drawing.Size(434, 450);
            this.dgvListadoProductos.TabIndex = 14;
            this.dgvListadoProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoProductos_CellClick);
            this.dgvListadoProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoProductos_CellContentClick);
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMostrarProductos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMostrarProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMostrarProductos.Location = new System.Drawing.Point(482, 471);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(127, 54);
            this.btnMostrarProductos.TabIndex = 13;
            this.btnMostrarProductos.Text = "Mostrar";
            this.btnMostrarProductos.UseVisualStyleBackColor = false;
            this.btnMostrarProductos.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(-55, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 92);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Subheading", 22.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(192, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 43);
            this.label4.TabIndex = 0;
            this.label4.Text = "Listado de Productos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(615, 471);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(127, 57);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(748, 471);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(127, 57);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre Producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(711, 190);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 19;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(711, 277);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProducto.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Precio Producto";
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Location = new System.Drawing.Point(515, 277);
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(100, 20);
            this.txtStockProducto.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Stock Producto";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(515, 190);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProducto.TabIndex = 25;
            // 
            // txtIdP
            // 
            this.txtIdP.AutoSize = true;
            this.txtIdP.Location = new System.Drawing.Point(512, 162);
            this.txtIdP.Name = "txtIdP";
            this.txtIdP.Size = new System.Drawing.Size(62, 13);
            this.txtIdP.TabIndex = 24;
            this.txtIdP.Text = "Id Producto";
            // 
            // MantenedorProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 591);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.txtIdP);
            this.Controls.Add(this.txtStockProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAtrasProductos);
            this.Controls.Add(this.dgvListadoProductos);
            this.Controls.Add(this.btnMostrarProductos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenedorProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenedorProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtrasProductos;
        private System.Windows.Forms.DataGridView dgvListadoProductos;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStockProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label txtIdP;
    }
}