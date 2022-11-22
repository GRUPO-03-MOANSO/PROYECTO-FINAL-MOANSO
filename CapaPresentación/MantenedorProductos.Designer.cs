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
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtrasProductos
            // 
            this.btnAtrasProductos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAtrasProductos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAtrasProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAtrasProductos.Location = new System.Drawing.Point(563, 421);
            this.btnAtrasProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtrasProductos.Name = "btnAtrasProductos";
            this.btnAtrasProductos.Size = new System.Drawing.Size(169, 70);
            this.btnAtrasProductos.TabIndex = 15;
            this.btnAtrasProductos.Text = "Regresar";
            this.btnAtrasProductos.UseVisualStyleBackColor = false;
            this.btnAtrasProductos.Click += new System.EventHandler(this.btnAtrasProductos_Click);
            // 
            // dgvListadoProductos
            // 
            this.dgvListadoProductos.AllowUserToOrderColumns = true;
            this.dgvListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProductos.Location = new System.Drawing.Point(16, 138);
            this.dgvListadoProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListadoProductos.Name = "dgvListadoProductos";
            this.dgvListadoProductos.RowHeadersWidth = 51;
            this.dgvListadoProductos.Size = new System.Drawing.Size(505, 554);
            this.dgvListadoProductos.TabIndex = 14;
            this.dgvListadoProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoProductos_CellContentClick);
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMostrarProductos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMostrarProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMostrarProductos.Location = new System.Drawing.Point(563, 261);
            this.btnMostrarProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(169, 66);
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
            this.panel1.Location = new System.Drawing.Point(-73, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 113);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Subheading", 22.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(256, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 53);
            this.label4.TabIndex = 0;
            this.label4.Text = "Listado de Productos";
            // 
            // MantenedorProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 706);
            this.Controls.Add(this.btnAtrasProductos);
            this.Controls.Add(this.dgvListadoProductos);
            this.Controls.Add(this.btnMostrarProductos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MantenedorProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenedorProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtrasProductos;
        private System.Windows.Forms.DataGridView dgvListadoProductos;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}