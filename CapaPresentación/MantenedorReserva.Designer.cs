namespace CapaPresentación
{
    partial class MantenedorReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorReserva));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_muestra_clientesP = new System.Windows.Forms.DataGridView();
            this.btn_cancelar_clienteM = new System.Windows.Forms.Button();
            this.btn_editar_clienteM = new System.Windows.Forms.Button();
            this.btn_agregar_clienteM = new System.Windows.Forms.Button();
            this.btn_mostrar_clienteM = new System.Windows.Forms.Button();
            this.btn_nuevo_clienteM = new System.Windows.Forms.Button();
            this.txtIDreserva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_muestra_clientesP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(747, 373);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 22);
            this.dateTimePicker1.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(544, 373);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Fecha";
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Location = new System.Drawing.Point(747, 298);
            this.txtIDcliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.Size = new System.Drawing.Size(313, 22);
            this.txtIDcliente.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "ID cliente";
            // 
            // txtIDproducto
            // 
            this.txtIDproducto.Location = new System.Drawing.Point(747, 226);
            this.txtIDproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDproducto.Name = "txtIDproducto";
            this.txtIDproducto.Size = new System.Drawing.Size(313, 22);
            this.txtIDproducto.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "ID producto";
            // 
            // dg_muestra_clientesP
            // 
            this.dg_muestra_clientesP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_muestra_clientesP.Location = new System.Drawing.Point(248, 628);
            this.dg_muestra_clientesP.Margin = new System.Windows.Forms.Padding(4);
            this.dg_muestra_clientesP.Name = "dg_muestra_clientesP";
            this.dg_muestra_clientesP.Size = new System.Drawing.Size(916, 185);
            this.dg_muestra_clientesP.TabIndex = 52;
            // 
            // btn_cancelar_clienteM
            // 
            this.btn_cancelar_clienteM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_cancelar_clienteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar_clienteM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancelar_clienteM.Location = new System.Drawing.Point(1039, 529);
            this.btn_cancelar_clienteM.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar_clienteM.Name = "btn_cancelar_clienteM";
            this.btn_cancelar_clienteM.Size = new System.Drawing.Size(125, 42);
            this.btn_cancelar_clienteM.TabIndex = 51;
            this.btn_cancelar_clienteM.Text = "Cancelar";
            this.btn_cancelar_clienteM.UseVisualStyleBackColor = false;
            // 
            // btn_editar_clienteM
            // 
            this.btn_editar_clienteM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_editar_clienteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_clienteM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_editar_clienteM.Location = new System.Drawing.Point(817, 529);
            this.btn_editar_clienteM.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar_clienteM.Name = "btn_editar_clienteM";
            this.btn_editar_clienteM.Size = new System.Drawing.Size(133, 42);
            this.btn_editar_clienteM.TabIndex = 50;
            this.btn_editar_clienteM.Text = "Editar";
            this.btn_editar_clienteM.UseVisualStyleBackColor = false;
            // 
            // btn_agregar_clienteM
            // 
            this.btn_agregar_clienteM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregar_clienteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_clienteM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_agregar_clienteM.Location = new System.Drawing.Point(622, 529);
            this.btn_agregar_clienteM.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregar_clienteM.Name = "btn_agregar_clienteM";
            this.btn_agregar_clienteM.Size = new System.Drawing.Size(111, 42);
            this.btn_agregar_clienteM.TabIndex = 49;
            this.btn_agregar_clienteM.Text = "Agregar";
            this.btn_agregar_clienteM.UseVisualStyleBackColor = false;
            // 
            // btn_mostrar_clienteM
            // 
            this.btn_mostrar_clienteM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_mostrar_clienteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar_clienteM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_mostrar_clienteM.Location = new System.Drawing.Point(435, 529);
            this.btn_mostrar_clienteM.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mostrar_clienteM.Name = "btn_mostrar_clienteM";
            this.btn_mostrar_clienteM.Size = new System.Drawing.Size(124, 42);
            this.btn_mostrar_clienteM.TabIndex = 48;
            this.btn_mostrar_clienteM.Text = "Mostrar";
            this.btn_mostrar_clienteM.UseVisualStyleBackColor = false;
            // 
            // btn_nuevo_clienteM
            // 
            this.btn_nuevo_clienteM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_nuevo_clienteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_clienteM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nuevo_clienteM.Location = new System.Drawing.Point(248, 529);
            this.btn_nuevo_clienteM.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nuevo_clienteM.Name = "btn_nuevo_clienteM";
            this.btn_nuevo_clienteM.Size = new System.Drawing.Size(121, 42);
            this.btn_nuevo_clienteM.TabIndex = 47;
            this.btn_nuevo_clienteM.Text = "Nuevo";
            this.btn_nuevo_clienteM.UseVisualStyleBackColor = false;
            // 
            // txtIDreserva
            // 
            this.txtIDreserva.Location = new System.Drawing.Point(747, 158);
            this.txtIDreserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDreserva.Name = "txtIDreserva";
            this.txtIDreserva.Size = new System.Drawing.Size(313, 22);
            this.txtIDreserva.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID reserva";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 145);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(7, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 92);
            this.panel1.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Subheading", 22.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(597, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 43);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reserva";
            // 
            // MantenedorReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 842);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIDcliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDproducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_muestra_clientesP);
            this.Controls.Add(this.btn_cancelar_clienteM);
            this.Controls.Add(this.btn_editar_clienteM);
            this.Controls.Add(this.btn_agregar_clienteM);
            this.Controls.Add(this.btn_mostrar_clienteM);
            this.Controls.Add(this.btn_nuevo_clienteM);
            this.Controls.Add(this.txtIDreserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MantenedorReserva";
            this.Text = "MantenedorReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dg_muestra_clientesP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDcliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_muestra_clientesP;
        private System.Windows.Forms.Button btn_cancelar_clienteM;
        private System.Windows.Forms.Button btn_editar_clienteM;
        private System.Windows.Forms.Button btn_agregar_clienteM;
        private System.Windows.Forms.Button btn_mostrar_clienteM;
        private System.Windows.Forms.Button btn_nuevo_clienteM;
        private System.Windows.Forms.TextBox txtIDreserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}