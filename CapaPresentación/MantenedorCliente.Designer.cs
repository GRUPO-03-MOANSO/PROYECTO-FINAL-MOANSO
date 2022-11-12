namespace CapaPresentación
{
    partial class MantenedorCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_nuevo_clienteM = new System.Windows.Forms.Button();
            this.btn_mostrar_clienteM = new System.Windows.Forms.Button();
            this.btn_agregar_clienteM = new System.Windows.Forms.Button();
            this.btn_cancelar_clienteM = new System.Windows.Forms.Button();
            this.btn_editar_clienteM = new System.Windows.Forms.Button();
            this.text_idcliente_clienteP = new System.Windows.Forms.TextBox();
            this.text_nombre_clienteP = new System.Windows.Forms.TextBox();
            this.text_apellidos_clienteP = new System.Windows.Forms.TextBox();
            this.text_tipocliente_clienteP = new System.Windows.Forms.TextBox();
            this.text_dni_clienteP = new System.Windows.Forms.TextBox();
            this.cbm_sexo_clienteP = new System.Windows.Forms.ComboBox();
            this.cbm_estado_clienteP = new System.Windows.Forms.ComboBox();
            this.dg_muestra_clientesP = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_muestra_clientesP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(1, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 71);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Subheading", 22.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(242, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 43);
            this.label8.TabIndex = 0;
            this.label8.Text = "Registrar Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Estado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_nuevo_clienteM
            // 
            this.btn_nuevo_clienteM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_nuevo_clienteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_clienteM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nuevo_clienteM.Location = new System.Drawing.Point(26, 433);
            this.btn_nuevo_clienteM.Name = "btn_nuevo_clienteM";
            this.btn_nuevo_clienteM.Size = new System.Drawing.Size(91, 34);
            this.btn_nuevo_clienteM.TabIndex = 10;
            this.btn_nuevo_clienteM.Text = "Nuevo";
            this.btn_nuevo_clienteM.UseVisualStyleBackColor = false;
            this.btn_nuevo_clienteM.Click += new System.EventHandler(this.btn_nuevo_clienteM_Click);
            // 
            // btn_mostrar_clienteM
            // 
            this.btn_mostrar_clienteM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_mostrar_clienteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar_clienteM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_mostrar_clienteM.Location = new System.Drawing.Point(181, 433);
            this.btn_mostrar_clienteM.Name = "btn_mostrar_clienteM";
            this.btn_mostrar_clienteM.Size = new System.Drawing.Size(93, 34);
            this.btn_mostrar_clienteM.TabIndex = 11;
            this.btn_mostrar_clienteM.Text = "Mostrar";
            this.btn_mostrar_clienteM.UseVisualStyleBackColor = false;
            this.btn_mostrar_clienteM.Click += new System.EventHandler(this.btn_mostrar_clienteM_Click);
            // 
            // btn_agregar_clienteM
            // 
            this.btn_agregar_clienteM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregar_clienteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_clienteM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_agregar_clienteM.Location = new System.Drawing.Point(345, 433);
            this.btn_agregar_clienteM.Name = "btn_agregar_clienteM";
            this.btn_agregar_clienteM.Size = new System.Drawing.Size(83, 34);
            this.btn_agregar_clienteM.TabIndex = 12;
            this.btn_agregar_clienteM.Text = "Agregar";
            this.btn_agregar_clienteM.UseVisualStyleBackColor = false;
            this.btn_agregar_clienteM.Click += new System.EventHandler(this.btn_agregar_clienteM_Click);
            // 
            // btn_cancelar_clienteM
            // 
            this.btn_cancelar_clienteM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_cancelar_clienteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar_clienteM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancelar_clienteM.Location = new System.Drawing.Point(492, 433);
            this.btn_cancelar_clienteM.Name = "btn_cancelar_clienteM";
            this.btn_cancelar_clienteM.Size = new System.Drawing.Size(94, 34);
            this.btn_cancelar_clienteM.TabIndex = 13;
            this.btn_cancelar_clienteM.Text = "Cancelar";
            this.btn_cancelar_clienteM.UseVisualStyleBackColor = false;
            this.btn_cancelar_clienteM.Click += new System.EventHandler(this.btn_cancelar_clienteM_Click);
            // 
            // btn_editar_clienteM
            // 
            this.btn_editar_clienteM.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_editar_clienteM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_clienteM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_editar_clienteM.Location = new System.Drawing.Point(635, 433);
            this.btn_editar_clienteM.Name = "btn_editar_clienteM";
            this.btn_editar_clienteM.Size = new System.Drawing.Size(100, 34);
            this.btn_editar_clienteM.TabIndex = 14;
            this.btn_editar_clienteM.Text = "Editar";
            this.btn_editar_clienteM.UseVisualStyleBackColor = false;
            this.btn_editar_clienteM.Click += new System.EventHandler(this.btn_editar_clienteM_Click);
            // 
            // text_idcliente_clienteP
            // 
            this.text_idcliente_clienteP.Location = new System.Drawing.Point(485, 116);
            this.text_idcliente_clienteP.Name = "text_idcliente_clienteP";
            this.text_idcliente_clienteP.Size = new System.Drawing.Size(236, 20);
            this.text_idcliente_clienteP.TabIndex = 15;
            // 
            // text_nombre_clienteP
            // 
            this.text_nombre_clienteP.Location = new System.Drawing.Point(485, 162);
            this.text_nombre_clienteP.Name = "text_nombre_clienteP";
            this.text_nombre_clienteP.Size = new System.Drawing.Size(236, 20);
            this.text_nombre_clienteP.TabIndex = 16;
            // 
            // text_apellidos_clienteP
            // 
            this.text_apellidos_clienteP.Location = new System.Drawing.Point(485, 202);
            this.text_apellidos_clienteP.Name = "text_apellidos_clienteP";
            this.text_apellidos_clienteP.Size = new System.Drawing.Size(236, 20);
            this.text_apellidos_clienteP.TabIndex = 17;
            // 
            // text_tipocliente_clienteP
            // 
            this.text_tipocliente_clienteP.Location = new System.Drawing.Point(485, 253);
            this.text_tipocliente_clienteP.Name = "text_tipocliente_clienteP";
            this.text_tipocliente_clienteP.Size = new System.Drawing.Size(236, 20);
            this.text_tipocliente_clienteP.TabIndex = 18;
            // 
            // text_dni_clienteP
            // 
            this.text_dni_clienteP.Location = new System.Drawing.Point(485, 305);
            this.text_dni_clienteP.Name = "text_dni_clienteP";
            this.text_dni_clienteP.Size = new System.Drawing.Size(236, 20);
            this.text_dni_clienteP.TabIndex = 19;
            // 
            // cbm_sexo_clienteP
            // 
            this.cbm_sexo_clienteP.FormattingEnabled = true;
            this.cbm_sexo_clienteP.Location = new System.Drawing.Point(485, 347);
            this.cbm_sexo_clienteP.Name = "cbm_sexo_clienteP";
            this.cbm_sexo_clienteP.Size = new System.Drawing.Size(236, 21);
            this.cbm_sexo_clienteP.TabIndex = 20;
            // 
            // cbm_estado_clienteP
            // 
            this.cbm_estado_clienteP.FormattingEnabled = true;
            this.cbm_estado_clienteP.Location = new System.Drawing.Point(485, 390);
            this.cbm_estado_clienteP.Name = "cbm_estado_clienteP";
            this.cbm_estado_clienteP.Size = new System.Drawing.Size(236, 21);
            this.cbm_estado_clienteP.TabIndex = 21;
            // 
            // dg_muestra_clientesP
            // 
            this.dg_muestra_clientesP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_muestra_clientesP.Location = new System.Drawing.Point(34, 488);
            this.dg_muestra_clientesP.Name = "dg_muestra_clientesP";
            this.dg_muestra_clientesP.Size = new System.Drawing.Size(687, 150);
            this.dg_muestra_clientesP.TabIndex = 22;
            this.dg_muestra_clientesP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_muestra_clientesP_CellContentClick);
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 661);
            this.Controls.Add(this.dg_muestra_clientesP);
            this.Controls.Add(this.cbm_estado_clienteP);
            this.Controls.Add(this.cbm_sexo_clienteP);
            this.Controls.Add(this.text_dni_clienteP);
            this.Controls.Add(this.text_tipocliente_clienteP);
            this.Controls.Add(this.text_apellidos_clienteP);
            this.Controls.Add(this.text_nombre_clienteP);
            this.Controls.Add(this.text_idcliente_clienteP);
            this.Controls.Add(this.btn_editar_clienteM);
            this.Controls.Add(this.btn_cancelar_clienteM);
            this.Controls.Add(this.btn_agregar_clienteM);
            this.Controls.Add(this.btn_mostrar_clienteM);
            this.Controls.Add(this.btn_nuevo_clienteM);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "MantenedorCliente";
            this.Text = "MantenedorCliente";
            this.Load += new System.EventHandler(this.MantenedorCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_muestra_clientesP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_nuevo_clienteM;
        private System.Windows.Forms.Button btn_mostrar_clienteM;
        private System.Windows.Forms.Button btn_agregar_clienteM;
        private System.Windows.Forms.Button btn_cancelar_clienteM;
        private System.Windows.Forms.Button btn_editar_clienteM;
        private System.Windows.Forms.TextBox text_idcliente_clienteP;
        private System.Windows.Forms.TextBox text_nombre_clienteP;
        private System.Windows.Forms.TextBox text_apellidos_clienteP;
        private System.Windows.Forms.TextBox text_tipocliente_clienteP;
        private System.Windows.Forms.TextBox text_dni_clienteP;
        private System.Windows.Forms.ComboBox cbm_sexo_clienteP;
        private System.Windows.Forms.ComboBox cbm_estado_clienteP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dg_muestra_clientesP;
    }
}