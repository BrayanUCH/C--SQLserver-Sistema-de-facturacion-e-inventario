namespace CapaPresentacion.Modulos_Registros
{
    partial class frmRegistroCustasXPagar
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
            this.panel_supCuentasXPagar = new System.Windows.Forms.Panel();
            this.lblCuentaXPagar_Titulo = new System.Windows.Forms.Label();
            this.ckb_ListarInactivos = new System.Windows.Forms.CheckBox();
            this.panel_infCuentasXPagar = new System.Windows.Forms.Panel();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.txb_Descripcion = new System.Windows.Forms.RichTextBox();
            this.txb_FechaPago = new System.Windows.Forms.TextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.ckb_Activar = new System.Windows.Forms.CheckBox();
            this.cbx_ProveedorID = new System.Windows.Forms.ComboBox();
            this.txb_Monto = new System.Windows.Forms.TextBox();
            this.lblCuentasXPagar_Monto = new System.Windows.Forms.Label();
            this.lblCuentasXPagar_ProvedorID = new System.Windows.Forms.Label();
            this.aaa = new System.Windows.Forms.Label();
            this.lblCuentasXPagar_Descripcion = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_supCuentasXPagar.SuspendLayout();
            this.panel_infCuentasXPagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_supCuentasXPagar
            // 
            this.panel_supCuentasXPagar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_supCuentasXPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_supCuentasXPagar.Controls.Add(this.lblCuentaXPagar_Titulo);
            this.panel_supCuentasXPagar.Controls.Add(this.ckb_ListarInactivos);
            this.panel_supCuentasXPagar.Location = new System.Drawing.Point(0, 0);
            this.panel_supCuentasXPagar.Name = "panel_supCuentasXPagar";
            this.panel_supCuentasXPagar.Size = new System.Drawing.Size(934, 65);
            this.panel_supCuentasXPagar.TabIndex = 0;
            // 
            // lblCuentaXPagar_Titulo
            // 
            this.lblCuentaXPagar_Titulo.AutoSize = true;
            this.lblCuentaXPagar_Titulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaXPagar_Titulo.ForeColor = System.Drawing.Color.White;
            this.lblCuentaXPagar_Titulo.Location = new System.Drawing.Point(0, 9);
            this.lblCuentaXPagar_Titulo.Name = "lblCuentaXPagar_Titulo";
            this.lblCuentaXPagar_Titulo.Size = new System.Drawing.Size(560, 44);
            this.lblCuentaXPagar_Titulo.TabIndex = 74;
            this.lblCuentaXPagar_Titulo.Text = "Registro de cuentas por pagar";
            // 
            // ckb_ListarInactivos
            // 
            this.ckb_ListarInactivos.AutoSize = true;
            this.ckb_ListarInactivos.ForeColor = System.Drawing.Color.White;
            this.ckb_ListarInactivos.Location = new System.Drawing.Point(996, 45);
            this.ckb_ListarInactivos.Name = "ckb_ListarInactivos";
            this.ckb_ListarInactivos.Size = new System.Drawing.Size(96, 17);
            this.ckb_ListarInactivos.TabIndex = 126;
            this.ckb_ListarInactivos.Text = "Listar inactivos";
            this.ckb_ListarInactivos.UseVisualStyleBackColor = true;
            this.ckb_ListarInactivos.CheckedChanged += new System.EventHandler(this.ckb_ListarInactivos_CheckedChanged);
            // 
            // panel_infCuentasXPagar
            // 
            this.panel_infCuentasXPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_infCuentasXPagar.AutoSize = true;
            this.panel_infCuentasXPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_infCuentasXPagar.Controls.Add(this.Btn_Eliminar);
            this.panel_infCuentasXPagar.Controls.Add(this.txb_Descripcion);
            this.panel_infCuentasXPagar.Controls.Add(this.txb_FechaPago);
            this.panel_infCuentasXPagar.Controls.Add(this.btn_Modificar);
            this.panel_infCuentasXPagar.Controls.Add(this.btn_Limpiar);
            this.panel_infCuentasXPagar.Controls.Add(this.ckb_Activar);
            this.panel_infCuentasXPagar.Controls.Add(this.cbx_ProveedorID);
            this.panel_infCuentasXPagar.Controls.Add(this.txb_Monto);
            this.panel_infCuentasXPagar.Controls.Add(this.lblCuentasXPagar_Monto);
            this.panel_infCuentasXPagar.Controls.Add(this.lblCuentasXPagar_ProvedorID);
            this.panel_infCuentasXPagar.Controls.Add(this.aaa);
            this.panel_infCuentasXPagar.Controls.Add(this.lblCuentasXPagar_Descripcion);
            this.panel_infCuentasXPagar.Controls.Add(this.dgv);
            this.panel_infCuentasXPagar.Controls.Add(this.btn_Insertar);
            this.panel_infCuentasXPagar.Location = new System.Drawing.Point(0, 65);
            this.panel_infCuentasXPagar.Name = "panel_infCuentasXPagar";
            this.panel_infCuentasXPagar.Size = new System.Drawing.Size(935, 436);
            this.panel_infCuentasXPagar.TabIndex = 1;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Location = new System.Drawing.Point(188, 218);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Eliminar.TabIndex = 124;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // txb_Descripcion
            // 
            this.txb_Descripcion.Location = new System.Drawing.Point(127, 33);
            this.txb_Descripcion.MaxLength = 100;
            this.txb_Descripcion.Name = "txb_Descripcion";
            this.txb_Descripcion.Size = new System.Drawing.Size(136, 40);
            this.txb_Descripcion.TabIndex = 1;
            this.txb_Descripcion.Text = "";
            // 
            // txb_FechaPago
            // 
            this.txb_FechaPago.Location = new System.Drawing.Point(127, 79);
            this.txb_FechaPago.MaxLength = 50;
            this.txb_FechaPago.Name = "txb_FechaPago";
            this.txb_FechaPago.Size = new System.Drawing.Size(136, 20);
            this.txb_FechaPago.TabIndex = 2;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.btn_Modificar.Location = new System.Drawing.Point(188, 189);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 6;
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
            this.btn_Limpiar.Location = new System.Drawing.Point(188, 160);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 5;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // ckb_Activar
            // 
            this.ckb_Activar.AutoSize = true;
            this.ckb_Activar.ForeColor = System.Drawing.Color.White;
            this.ckb_Activar.Location = new System.Drawing.Point(28, 131);
            this.ckb_Activar.Name = "ckb_Activar";
            this.ckb_Activar.Size = new System.Drawing.Size(56, 17);
            this.ckb_Activar.TabIndex = 123;
            this.ckb_Activar.Text = "Artivar";
            this.ckb_Activar.UseVisualStyleBackColor = true;
            // 
            // cbx_ProveedorID
            // 
            this.cbx_ProveedorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ProveedorID.FormattingEnabled = true;
            this.cbx_ProveedorID.Location = new System.Drawing.Point(128, 6);
            this.cbx_ProveedorID.Name = "cbx_ProveedorID";
            this.cbx_ProveedorID.Size = new System.Drawing.Size(135, 21);
            this.cbx_ProveedorID.TabIndex = 0;
            // 
            // txb_Monto
            // 
            this.txb_Monto.Location = new System.Drawing.Point(127, 105);
            this.txb_Monto.Name = "txb_Monto";
            this.txb_Monto.Size = new System.Drawing.Size(135, 20);
            this.txb_Monto.TabIndex = 3;
            this.txb_Monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Monto_KeyPress);
            // 
            // lblCuentasXPagar_Monto
            // 
            this.lblCuentasXPagar_Monto.AutoSize = true;
            this.lblCuentasXPagar_Monto.ForeColor = System.Drawing.Color.White;
            this.lblCuentasXPagar_Monto.Location = new System.Drawing.Point(25, 108);
            this.lblCuentasXPagar_Monto.Name = "lblCuentasXPagar_Monto";
            this.lblCuentasXPagar_Monto.Size = new System.Drawing.Size(37, 13);
            this.lblCuentasXPagar_Monto.TabIndex = 109;
            this.lblCuentasXPagar_Monto.Text = "Monto";
            // 
            // lblCuentasXPagar_ProvedorID
            // 
            this.lblCuentasXPagar_ProvedorID.AutoSize = true;
            this.lblCuentasXPagar_ProvedorID.ForeColor = System.Drawing.Color.White;
            this.lblCuentasXPagar_ProvedorID.Location = new System.Drawing.Point(26, 9);
            this.lblCuentasXPagar_ProvedorID.Name = "lblCuentasXPagar_ProvedorID";
            this.lblCuentasXPagar_ProvedorID.Size = new System.Drawing.Size(70, 13);
            this.lblCuentasXPagar_ProvedorID.TabIndex = 107;
            this.lblCuentasXPagar_ProvedorID.Text = "Proveedor ID";
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.ForeColor = System.Drawing.Color.White;
            this.aaa.Location = new System.Drawing.Point(25, 82);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(72, 13);
            this.aaa.TabIndex = 105;
            this.aaa.Text = "Días de pago";
            // 
            // lblCuentasXPagar_Descripcion
            // 
            this.lblCuentasXPagar_Descripcion.AutoSize = true;
            this.lblCuentasXPagar_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lblCuentasXPagar_Descripcion.Location = new System.Drawing.Point(26, 36);
            this.lblCuentasXPagar_Descripcion.Name = "lblCuentasXPagar_Descripcion";
            this.lblCuentasXPagar_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lblCuentasXPagar_Descripcion.TabIndex = 103;
            this.lblCuentasXPagar_Descripcion.Text = "Descripción";
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
            this.dgv.Size = new System.Drawing.Size(660, 426);
            this.dgv.TabIndex = 7;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Insertar.ForeColor = System.Drawing.Color.White;
            this.btn_Insertar.Location = new System.Drawing.Point(189, 131);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(74, 23);
            this.btn_Insertar.TabIndex = 4;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = false;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRegistroCustasXPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(934, 501);
            this.Controls.Add(this.panel_infCuentasXPagar);
            this.Controls.Add(this.panel_supCuentasXPagar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroCustasXPagar";
            this.Text = "CUENTAS POR PAGAR ";
            this.panel_supCuentasXPagar.ResumeLayout(false);
            this.panel_supCuentasXPagar.PerformLayout();
            this.panel_infCuentasXPagar.ResumeLayout(false);
            this.panel_infCuentasXPagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_supCuentasXPagar;
        private System.Windows.Forms.Panel panel_infCuentasXPagar;
        private System.Windows.Forms.Label lblCuentaXPagar_Titulo;
        private System.Windows.Forms.TextBox txb_Monto;
        private System.Windows.Forms.Label lblCuentasXPagar_Monto;
        private System.Windows.Forms.Label lblCuentasXPagar_ProvedorID;
        private System.Windows.Forms.Label lblCuentasXPagar_Descripcion;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.ComboBox cbx_ProveedorID;
        private System.Windows.Forms.CheckBox ckb_ListarInactivos;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.CheckBox ckb_Activar;
        private System.Windows.Forms.TextBox txb_FechaPago;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RichTextBox txb_Descripcion;
        private System.Windows.Forms.Button Btn_Eliminar;
    }
}