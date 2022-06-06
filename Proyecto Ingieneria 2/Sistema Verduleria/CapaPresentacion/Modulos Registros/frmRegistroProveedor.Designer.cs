namespace CapaPresentacion.Modulos_Registros
{
    partial class frmRegistroProveedor
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
            this.panel_supProveedor = new System.Windows.Forms.Panel();
            this.lblclientes_Titulo = new System.Windows.Forms.Label();
            this.ckb_ListarInactivos = new System.Windows.Forms.CheckBox();
            this.panel_infProveedor = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.dtp_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txb_Codigo = new System.Windows.Forms.TextBox();
            this.lblProveedor_Codigo = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.ckb_Activar = new System.Windows.Forms.CheckBox();
            this.txb_DiasDePago = new System.Windows.Forms.TextBox();
            this.lblProveedor_DiasDePago = new System.Windows.Forms.Label();
            this.txb_Banco = new System.Windows.Forms.TextBox();
            this.lblProveedor_Banco = new System.Windows.Forms.Label();
            this.txb_CuentaBanco = new System.Windows.Forms.TextBox();
            this.lblProveedor_CuentaBanco = new System.Windows.Forms.Label();
            this.txb_Saldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProveedor_fechaIngreso = new System.Windows.Forms.Label();
            this.txb_Telefono = new System.Windows.Forms.TextBox();
            this.lblProveedor_telefono = new System.Windows.Forms.Label();
            this.txb_CorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblProveedor_correoElectronico = new System.Windows.Forms.Label();
            this.txb_Cedula = new System.Windows.Forms.TextBox();
            this.lblProveedor_cedula = new System.Windows.Forms.Label();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.lblProveedor_Nombre = new System.Windows.Forms.Label();
            this.dgv_Proveedor = new System.Windows.Forms.DataGridView();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_supProveedor.SuspendLayout();
            this.panel_infProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_supProveedor
            // 
            this.panel_supProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_supProveedor.Controls.Add(this.lblclientes_Titulo);
            this.panel_supProveedor.Controls.Add(this.ckb_ListarInactivos);
            this.panel_supProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_supProveedor.Location = new System.Drawing.Point(0, 0);
            this.panel_supProveedor.Name = "panel_supProveedor";
            this.panel_supProveedor.Size = new System.Drawing.Size(1095, 65);
            this.panel_supProveedor.TabIndex = 0;
            // 
            // lblclientes_Titulo
            // 
            this.lblclientes_Titulo.AutoSize = true;
            this.lblclientes_Titulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclientes_Titulo.ForeColor = System.Drawing.Color.White;
            this.lblclientes_Titulo.Location = new System.Drawing.Point(0, 9);
            this.lblclientes_Titulo.Name = "lblclientes_Titulo";
            this.lblclientes_Titulo.Size = new System.Drawing.Size(458, 44);
            this.lblclientes_Titulo.TabIndex = 72;
            this.lblclientes_Titulo.Text = "Registro de proveedores";
            // 
            // ckb_ListarInactivos
            // 
            this.ckb_ListarInactivos.AutoSize = true;
            this.ckb_ListarInactivos.ForeColor = System.Drawing.Color.White;
            this.ckb_ListarInactivos.Location = new System.Drawing.Point(996, 45);
            this.ckb_ListarInactivos.Name = "ckb_ListarInactivos";
            this.ckb_ListarInactivos.Size = new System.Drawing.Size(96, 17);
            this.ckb_ListarInactivos.TabIndex = 133;
            this.ckb_ListarInactivos.Text = "Listar inactivos";
            this.ckb_ListarInactivos.UseVisualStyleBackColor = true;
            this.ckb_ListarInactivos.CheckedChanged += new System.EventHandler(this.ckb_ListarInactivos_CheckedChanged);
            // 
            // panel_infProveedor
            // 
            this.panel_infProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_infProveedor.AutoSize = true;
            this.panel_infProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_infProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_infProveedor.Controls.Add(this.btn_Eliminar);
            this.panel_infProveedor.Controls.Add(this.dtp_FechaIngreso);
            this.panel_infProveedor.Controls.Add(this.txb_Codigo);
            this.panel_infProveedor.Controls.Add(this.lblProveedor_Codigo);
            this.panel_infProveedor.Controls.Add(this.btn_Modificar);
            this.panel_infProveedor.Controls.Add(this.btn_Limpiar);
            this.panel_infProveedor.Controls.Add(this.ckb_Activar);
            this.panel_infProveedor.Controls.Add(this.txb_DiasDePago);
            this.panel_infProveedor.Controls.Add(this.lblProveedor_DiasDePago);
            this.panel_infProveedor.Controls.Add(this.txb_Banco);
            this.panel_infProveedor.Controls.Add(this.lblProveedor_Banco);
            this.panel_infProveedor.Controls.Add(this.txb_CuentaBanco);
            this.panel_infProveedor.Controls.Add(this.lblProveedor_CuentaBanco);
            this.panel_infProveedor.Controls.Add(this.txb_Saldo);
            this.panel_infProveedor.Controls.Add(this.label2);
            this.panel_infProveedor.Controls.Add(this.lblProveedor_fechaIngreso);
            this.panel_infProveedor.Controls.Add(this.txb_Telefono);
            this.panel_infProveedor.Controls.Add(this.lblProveedor_telefono);
            this.panel_infProveedor.Controls.Add(this.txb_CorreoElectronico);
            this.panel_infProveedor.Controls.Add(this.lblProveedor_correoElectronico);
            this.panel_infProveedor.Controls.Add(this.txb_Cedula);
            this.panel_infProveedor.Controls.Add(this.lblProveedor_cedula);
            this.panel_infProveedor.Controls.Add(this.txb_Nombre);
            this.panel_infProveedor.Controls.Add(this.lblProveedor_Nombre);
            this.panel_infProveedor.Controls.Add(this.dgv_Proveedor);
            this.panel_infProveedor.Controls.Add(this.btn_Insertar);
            this.panel_infProveedor.Location = new System.Drawing.Point(0, 65);
            this.panel_infProveedor.Name = "panel_infProveedor";
            this.panel_infProveedor.Size = new System.Drawing.Size(1095, 436);
            this.panel_infProveedor.TabIndex = 1;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(188, 353);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 136;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // dtp_FechaIngreso
            // 
            this.dtp_FechaIngreso.Location = new System.Drawing.Point(128, 84);
            this.dtp_FechaIngreso.Name = "dtp_FechaIngreso";
            this.dtp_FechaIngreso.Size = new System.Drawing.Size(135, 20);
            this.dtp_FechaIngreso.TabIndex = 3;
            // 
            // txb_Codigo
            // 
            this.txb_Codigo.Location = new System.Drawing.Point(128, 32);
            this.txb_Codigo.MaxLength = 10;
            this.txb_Codigo.Name = "txb_Codigo";
            this.txb_Codigo.Size = new System.Drawing.Size(135, 20);
            this.txb_Codigo.TabIndex = 1;
            // 
            // lblProveedor_Codigo
            // 
            this.lblProveedor_Codigo.AutoSize = true;
            this.lblProveedor_Codigo.ForeColor = System.Drawing.Color.White;
            this.lblProveedor_Codigo.Location = new System.Drawing.Point(15, 35);
            this.lblProveedor_Codigo.Name = "lblProveedor_Codigo";
            this.lblProveedor_Codigo.Size = new System.Drawing.Size(40, 13);
            this.lblProveedor_Codigo.TabIndex = 135;
            this.lblProveedor_Codigo.Text = "Código";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.btn_Modificar.Location = new System.Drawing.Point(188, 324);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 12;
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
            this.btn_Limpiar.Location = new System.Drawing.Point(188, 295);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 11;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // ckb_Activar
            // 
            this.ckb_Activar.AutoSize = true;
            this.ckb_Activar.ForeColor = System.Drawing.Color.White;
            this.ckb_Activar.Location = new System.Drawing.Point(18, 266);
            this.ckb_Activar.Name = "ckb_Activar";
            this.ckb_Activar.Size = new System.Drawing.Size(56, 17);
            this.ckb_Activar.TabIndex = 130;
            this.ckb_Activar.Text = "Artivar";
            this.ckb_Activar.UseVisualStyleBackColor = true;
            // 
            // txb_DiasDePago
            // 
            this.txb_DiasDePago.Location = new System.Drawing.Point(128, 188);
            this.txb_DiasDePago.MaxLength = 50;
            this.txb_DiasDePago.Name = "txb_DiasDePago";
            this.txb_DiasDePago.Size = new System.Drawing.Size(135, 20);
            this.txb_DiasDePago.TabIndex = 7;
            // 
            // lblProveedor_DiasDePago
            // 
            this.lblProveedor_DiasDePago.AutoSize = true;
            this.lblProveedor_DiasDePago.ForeColor = System.Drawing.Color.White;
            this.lblProveedor_DiasDePago.Location = new System.Drawing.Point(15, 191);
            this.lblProveedor_DiasDePago.Name = "lblProveedor_DiasDePago";
            this.lblProveedor_DiasDePago.Size = new System.Drawing.Size(72, 13);
            this.lblProveedor_DiasDePago.TabIndex = 92;
            this.lblProveedor_DiasDePago.Text = "Días de pago";
            // 
            // txb_Banco
            // 
            this.txb_Banco.Location = new System.Drawing.Point(128, 162);
            this.txb_Banco.MaxLength = 50;
            this.txb_Banco.Name = "txb_Banco";
            this.txb_Banco.Size = new System.Drawing.Size(135, 20);
            this.txb_Banco.TabIndex = 6;
            // 
            // lblProveedor_Banco
            // 
            this.lblProveedor_Banco.AutoSize = true;
            this.lblProveedor_Banco.ForeColor = System.Drawing.Color.White;
            this.lblProveedor_Banco.Location = new System.Drawing.Point(15, 165);
            this.lblProveedor_Banco.Name = "lblProveedor_Banco";
            this.lblProveedor_Banco.Size = new System.Drawing.Size(38, 13);
            this.lblProveedor_Banco.TabIndex = 90;
            this.lblProveedor_Banco.Text = "Banco";
            // 
            // txb_CuentaBanco
            // 
            this.txb_CuentaBanco.Location = new System.Drawing.Point(128, 136);
            this.txb_CuentaBanco.MaxLength = 50;
            this.txb_CuentaBanco.Name = "txb_CuentaBanco";
            this.txb_CuentaBanco.Size = new System.Drawing.Size(135, 20);
            this.txb_CuentaBanco.TabIndex = 5;
            // 
            // lblProveedor_CuentaBanco
            // 
            this.lblProveedor_CuentaBanco.AutoSize = true;
            this.lblProveedor_CuentaBanco.ForeColor = System.Drawing.Color.White;
            this.lblProveedor_CuentaBanco.Location = new System.Drawing.Point(15, 139);
            this.lblProveedor_CuentaBanco.Name = "lblProveedor_CuentaBanco";
            this.lblProveedor_CuentaBanco.Size = new System.Drawing.Size(89, 13);
            this.lblProveedor_CuentaBanco.TabIndex = 88;
            this.lblProveedor_CuentaBanco.Text = "Cuenta de banco";
            // 
            // txb_Saldo
            // 
            this.txb_Saldo.Location = new System.Drawing.Point(128, 110);
            this.txb_Saldo.Name = "txb_Saldo";
            this.txb_Saldo.Size = new System.Drawing.Size(135, 20);
            this.txb_Saldo.TabIndex = 4;
            this.txb_Saldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Saldo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Saldo";
            // 
            // lblProveedor_fechaIngreso
            // 
            this.lblProveedor_fechaIngreso.AutoSize = true;
            this.lblProveedor_fechaIngreso.ForeColor = System.Drawing.Color.White;
            this.lblProveedor_fechaIngreso.Location = new System.Drawing.Point(15, 90);
            this.lblProveedor_fechaIngreso.Name = "lblProveedor_fechaIngreso";
            this.lblProveedor_fechaIngreso.Size = new System.Drawing.Size(74, 13);
            this.lblProveedor_fechaIngreso.TabIndex = 84;
            this.lblProveedor_fechaIngreso.Text = "Fecha ingreso";
            // 
            // txb_Telefono
            // 
            this.txb_Telefono.Location = new System.Drawing.Point(128, 214);
            this.txb_Telefono.MaxLength = 20;
            this.txb_Telefono.Name = "txb_Telefono";
            this.txb_Telefono.Size = new System.Drawing.Size(135, 20);
            this.txb_Telefono.TabIndex = 8;
            // 
            // lblProveedor_telefono
            // 
            this.lblProveedor_telefono.AutoSize = true;
            this.lblProveedor_telefono.ForeColor = System.Drawing.Color.White;
            this.lblProveedor_telefono.Location = new System.Drawing.Point(15, 217);
            this.lblProveedor_telefono.Name = "lblProveedor_telefono";
            this.lblProveedor_telefono.Size = new System.Drawing.Size(49, 13);
            this.lblProveedor_telefono.TabIndex = 82;
            this.lblProveedor_telefono.Text = "Teléfono";
            // 
            // txb_CorreoElectronico
            // 
            this.txb_CorreoElectronico.Location = new System.Drawing.Point(128, 240);
            this.txb_CorreoElectronico.MaxLength = 100;
            this.txb_CorreoElectronico.Name = "txb_CorreoElectronico";
            this.txb_CorreoElectronico.Size = new System.Drawing.Size(135, 20);
            this.txb_CorreoElectronico.TabIndex = 9;
            // 
            // lblProveedor_correoElectronico
            // 
            this.lblProveedor_correoElectronico.AutoSize = true;
            this.lblProveedor_correoElectronico.ForeColor = System.Drawing.Color.White;
            this.lblProveedor_correoElectronico.Location = new System.Drawing.Point(15, 243);
            this.lblProveedor_correoElectronico.Name = "lblProveedor_correoElectronico";
            this.lblProveedor_correoElectronico.Size = new System.Drawing.Size(93, 13);
            this.lblProveedor_correoElectronico.TabIndex = 80;
            this.lblProveedor_correoElectronico.Text = "Correo electrónico";
            // 
            // txb_Cedula
            // 
            this.txb_Cedula.Location = new System.Drawing.Point(128, 6);
            this.txb_Cedula.MaxLength = 20;
            this.txb_Cedula.Name = "txb_Cedula";
            this.txb_Cedula.Size = new System.Drawing.Size(135, 20);
            this.txb_Cedula.TabIndex = 0;
            // 
            // lblProveedor_cedula
            // 
            this.lblProveedor_cedula.AutoSize = true;
            this.lblProveedor_cedula.ForeColor = System.Drawing.Color.White;
            this.lblProveedor_cedula.Location = new System.Drawing.Point(15, 9);
            this.lblProveedor_cedula.Name = "lblProveedor_cedula";
            this.lblProveedor_cedula.Size = new System.Drawing.Size(40, 13);
            this.lblProveedor_cedula.TabIndex = 78;
            this.lblProveedor_cedula.Text = "Cédula";
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(128, 58);
            this.txb_Nombre.MaxLength = 100;
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(135, 20);
            this.txb_Nombre.TabIndex = 2;
            // 
            // lblProveedor_Nombre
            // 
            this.lblProveedor_Nombre.AutoSize = true;
            this.lblProveedor_Nombre.ForeColor = System.Drawing.Color.White;
            this.lblProveedor_Nombre.Location = new System.Drawing.Point(15, 61);
            this.lblProveedor_Nombre.Name = "lblProveedor_Nombre";
            this.lblProveedor_Nombre.Size = new System.Drawing.Size(68, 13);
            this.lblProveedor_Nombre.TabIndex = 76;
            this.lblProveedor_Nombre.Text = "Razón social";
            // 
            // dgv_Proveedor
            // 
            this.dgv_Proveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Proveedor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Proveedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Proveedor.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Proveedor.Location = new System.Drawing.Point(269, 6);
            this.dgv_Proveedor.Name = "dgv_Proveedor";
            this.dgv_Proveedor.Size = new System.Drawing.Size(821, 426);
            this.dgv_Proveedor.TabIndex = 13;
            this.dgv_Proveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Proveedor_CellDoubleClick);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Insertar.ForeColor = System.Drawing.Color.White;
            this.btn_Insertar.Location = new System.Drawing.Point(188, 266);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btn_Insertar.TabIndex = 10;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = false;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRegistroProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1095, 501);
            this.Controls.Add(this.panel_infProveedor);
            this.Controls.Add(this.panel_supProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroProveedor";
            this.Text = "frmModuloProveedor";
            this.panel_supProveedor.ResumeLayout(false);
            this.panel_supProveedor.PerformLayout();
            this.panel_infProveedor.ResumeLayout(false);
            this.panel_infProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_supProveedor;
        private System.Windows.Forms.Panel panel_infProveedor;
        private System.Windows.Forms.Label lblclientes_Titulo;
        private System.Windows.Forms.Label lblProveedor_fechaIngreso;
        private System.Windows.Forms.TextBox txb_Telefono;
        private System.Windows.Forms.Label lblProveedor_telefono;
        private System.Windows.Forms.TextBox txb_CorreoElectronico;
        private System.Windows.Forms.Label lblProveedor_correoElectronico;
        private System.Windows.Forms.TextBox txb_Cedula;
        private System.Windows.Forms.Label lblProveedor_cedula;
        private System.Windows.Forms.TextBox txb_Nombre;
        private System.Windows.Forms.Label lblProveedor_Nombre;
        private System.Windows.Forms.DataGridView dgv_Proveedor;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.TextBox txb_DiasDePago;
        private System.Windows.Forms.Label lblProveedor_DiasDePago;
        private System.Windows.Forms.TextBox txb_Banco;
        private System.Windows.Forms.Label lblProveedor_Banco;
        private System.Windows.Forms.TextBox txb_CuentaBanco;
        private System.Windows.Forms.Label lblProveedor_CuentaBanco;
        private System.Windows.Forms.TextBox txb_Saldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckb_ListarInactivos;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.CheckBox ckb_Activar;
        private System.Windows.Forms.TextBox txb_Codigo;
        private System.Windows.Forms.Label lblProveedor_Codigo;
        private System.Windows.Forms.DateTimePicker dtp_FechaIngreso;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}