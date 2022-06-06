namespace CapaPresentacion.Modulos_Registros
{
    partial class frmRegistroFamilia
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
            this.components = new System.ComponentModel.Container();
            this.panel_supFamilia = new System.Windows.Forms.Panel();
            this.ckb_ListarInactivos = new System.Windows.Forms.CheckBox();
            this.lblFamilia_Titulo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_infFamilia = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.txb_Descripcion = new System.Windows.Forms.RichTextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.ckb_Activar = new System.Windows.Forms.CheckBox();
            this.lblFamilia_Descripcion = new System.Windows.Forms.Label();
            this.txb_Tipo = new System.Windows.Forms.TextBox();
            this.lblFamilia_Tipo = new System.Windows.Forms.Label();
            this.txb_Codigo = new System.Windows.Forms.TextBox();
            this.lblFamilia_Codigo = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_supFamilia.SuspendLayout();
            this.panel_infFamilia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_supFamilia
            // 
            this.panel_supFamilia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_supFamilia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_supFamilia.Controls.Add(this.ckb_ListarInactivos);
            this.panel_supFamilia.Controls.Add(this.lblFamilia_Titulo);
            this.panel_supFamilia.Controls.Add(this.flowLayoutPanel1);
            this.panel_supFamilia.Location = new System.Drawing.Point(0, 0);
            this.panel_supFamilia.Name = "panel_supFamilia";
            this.panel_supFamilia.Size = new System.Drawing.Size(1095, 65);
            this.panel_supFamilia.TabIndex = 0;
            // 
            // ckb_ListarInactivos
            // 
            this.ckb_ListarInactivos.AutoSize = true;
            this.ckb_ListarInactivos.ForeColor = System.Drawing.Color.White;
            this.ckb_ListarInactivos.Location = new System.Drawing.Point(996, 45);
            this.ckb_ListarInactivos.Name = "ckb_ListarInactivos";
            this.ckb_ListarInactivos.Size = new System.Drawing.Size(96, 17);
            this.ckb_ListarInactivos.TabIndex = 129;
            this.ckb_ListarInactivos.Text = "Listar inactivos";
            this.ckb_ListarInactivos.UseVisualStyleBackColor = true;
            this.ckb_ListarInactivos.CheckedChanged += new System.EventHandler(this.ckb_ListarInactivos_CheckedChanged);
            // 
            // lblFamilia_Titulo
            // 
            this.lblFamilia_Titulo.AutoSize = true;
            this.lblFamilia_Titulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilia_Titulo.ForeColor = System.Drawing.Color.White;
            this.lblFamilia_Titulo.Location = new System.Drawing.Point(0, 9);
            this.lblFamilia_Titulo.Name = "lblFamilia_Titulo";
            this.lblFamilia_Titulo.Size = new System.Drawing.Size(349, 44);
            this.lblFamilia_Titulo.TabIndex = 75;
            this.lblFamilia_Titulo.Text = "Registro de familia";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(79, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel_infFamilia
            // 
            this.panel_infFamilia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_infFamilia.AutoSize = true;
            this.panel_infFamilia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_infFamilia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_infFamilia.Controls.Add(this.btn_Eliminar);
            this.panel_infFamilia.Controls.Add(this.txb_Descripcion);
            this.panel_infFamilia.Controls.Add(this.btn_Modificar);
            this.panel_infFamilia.Controls.Add(this.btn_Limpiar);
            this.panel_infFamilia.Controls.Add(this.ckb_Activar);
            this.panel_infFamilia.Controls.Add(this.lblFamilia_Descripcion);
            this.panel_infFamilia.Controls.Add(this.txb_Tipo);
            this.panel_infFamilia.Controls.Add(this.lblFamilia_Tipo);
            this.panel_infFamilia.Controls.Add(this.txb_Codigo);
            this.panel_infFamilia.Controls.Add(this.lblFamilia_Codigo);
            this.panel_infFamilia.Controls.Add(this.dgv);
            this.panel_infFamilia.Controls.Add(this.btn_Insertar);
            this.panel_infFamilia.Location = new System.Drawing.Point(0, 65);
            this.panel_infFamilia.Name = "panel_infFamilia";
            this.panel_infFamilia.Size = new System.Drawing.Size(1095, 436);
            this.panel_infFamilia.TabIndex = 1;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(188, 192);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 127;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // txb_Descripcion
            // 
            this.txb_Descripcion.Location = new System.Drawing.Point(128, 59);
            this.txb_Descripcion.MaxLength = 100;
            this.txb_Descripcion.Name = "txb_Descripcion";
            this.txb_Descripcion.Size = new System.Drawing.Size(135, 40);
            this.txb_Descripcion.TabIndex = 2;
            this.txb_Descripcion.Text = "";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.btn_Modificar.Location = new System.Drawing.Point(188, 163);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 5;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.Location = new System.Drawing.Point(188, 134);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 4;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // ckb_Activar
            // 
            this.ckb_Activar.AutoSize = true;
            this.ckb_Activar.ForeColor = System.Drawing.Color.White;
            this.ckb_Activar.Location = new System.Drawing.Point(29, 105);
            this.ckb_Activar.Name = "ckb_Activar";
            this.ckb_Activar.Size = new System.Drawing.Size(56, 17);
            this.ckb_Activar.TabIndex = 126;
            this.ckb_Activar.Text = "Artivar";
            this.ckb_Activar.UseVisualStyleBackColor = true;
            // 
            // lblFamilia_Descripcion
            // 
            this.lblFamilia_Descripcion.AutoSize = true;
            this.lblFamilia_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lblFamilia_Descripcion.Location = new System.Drawing.Point(26, 62);
            this.lblFamilia_Descripcion.Name = "lblFamilia_Descripcion";
            this.lblFamilia_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lblFamilia_Descripcion.TabIndex = 123;
            this.lblFamilia_Descripcion.Text = "Descripción";
            // 
            // txb_Tipo
            // 
            this.txb_Tipo.Location = new System.Drawing.Point(128, 33);
            this.txb_Tipo.MaxLength = 50;
            this.txb_Tipo.Name = "txb_Tipo";
            this.txb_Tipo.Size = new System.Drawing.Size(135, 20);
            this.txb_Tipo.TabIndex = 1;
            // 
            // lblFamilia_Tipo
            // 
            this.lblFamilia_Tipo.AutoSize = true;
            this.lblFamilia_Tipo.ForeColor = System.Drawing.Color.White;
            this.lblFamilia_Tipo.Location = new System.Drawing.Point(26, 36);
            this.lblFamilia_Tipo.Name = "lblFamilia_Tipo";
            this.lblFamilia_Tipo.Size = new System.Drawing.Size(28, 13);
            this.lblFamilia_Tipo.TabIndex = 119;
            this.lblFamilia_Tipo.Text = "Tipo";
            // 
            // txb_Codigo
            // 
            this.txb_Codigo.Location = new System.Drawing.Point(128, 7);
            this.txb_Codigo.MaxLength = 10;
            this.txb_Codigo.Name = "txb_Codigo";
            this.txb_Codigo.Size = new System.Drawing.Size(135, 20);
            this.txb_Codigo.TabIndex = 0;
            // 
            // lblFamilia_Codigo
            // 
            this.lblFamilia_Codigo.AutoSize = true;
            this.lblFamilia_Codigo.ForeColor = System.Drawing.Color.White;
            this.lblFamilia_Codigo.Location = new System.Drawing.Point(26, 10);
            this.lblFamilia_Codigo.Name = "lblFamilia_Codigo";
            this.lblFamilia_Codigo.Size = new System.Drawing.Size(40, 13);
            this.lblFamilia_Codigo.TabIndex = 117;
            this.lblFamilia_Codigo.Text = "Código";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.Location = new System.Drawing.Point(269, 6);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(821, 426);
            this.dgv.TabIndex = 6;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Insertar.ForeColor = System.Drawing.Color.White;
            this.btn_Insertar.Location = new System.Drawing.Point(188, 105);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btn_Insertar.TabIndex = 3;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = false;
            this.btn_Insertar.Click += new System.EventHandler(this.btnFamilia_Insertar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRegistroFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1095, 501);
            this.Controls.Add(this.panel_infFamilia);
            this.Controls.Add(this.panel_supFamilia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroFamilia";
            this.Text = "frmRegistroFamilia";
            this.panel_supFamilia.ResumeLayout(false);
            this.panel_supFamilia.PerformLayout();
            this.panel_infFamilia.ResumeLayout(false);
            this.panel_infFamilia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_supFamilia;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_infFamilia;
        private System.Windows.Forms.Label lblFamilia_Descripcion;
        private System.Windows.Forms.TextBox txb_Tipo;
        private System.Windows.Forms.Label lblFamilia_Tipo;
        private System.Windows.Forms.TextBox txb_Codigo;
        private System.Windows.Forms.Label lblFamilia_Codigo;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Label lblFamilia_Titulo;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.CheckBox ckb_Activar;
        private System.Windows.Forms.CheckBox ckb_ListarInactivos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RichTextBox txb_Descripcion;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}