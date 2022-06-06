namespace CapaPresentacion.Modulos_Registros
{
    partial class frmRegistroCliente
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
            this.panel_supCliente = new System.Windows.Forms.Panel();
            this.lblclientes_Titulo = new System.Windows.Forms.Label();
            this.ckb_ListarInactivos = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCliente_Eliminar = new System.Windows.Forms.Button();
            this.dp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.ckb_Activar = new System.Windows.Forms.CheckBox();
            this.lblCliente_FechaNacimiento = new System.Windows.Forms.Label();
            this.txb_Telefono = new System.Windows.Forms.TextBox();
            this.lblCliente_Telefono = new System.Windows.Forms.Label();
            this.txb_CorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblCliente_correoElectronico = new System.Windows.Forms.Label();
            this.txb_Cedula = new System.Windows.Forms.TextBox();
            this.lblCliente_Cedula = new System.Windows.Forms.Label();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.lblCliente_Nombre = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_supCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_supCliente
            // 
            this.panel_supCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_supCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_supCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_supCliente.Controls.Add(this.lblclientes_Titulo);
            this.panel_supCliente.Controls.Add(this.ckb_ListarInactivos);
            this.panel_supCliente.Location = new System.Drawing.Point(0, 0);
            this.panel_supCliente.Name = "panel_supCliente";
            this.panel_supCliente.Size = new System.Drawing.Size(1093, 65);
            this.panel_supCliente.TabIndex = 0;
            // 
            // lblclientes_Titulo
            // 
            this.lblclientes_Titulo.AutoSize = true;
            this.lblclientes_Titulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclientes_Titulo.ForeColor = System.Drawing.Color.White;
            this.lblclientes_Titulo.Location = new System.Drawing.Point(0, 9);
            this.lblclientes_Titulo.Name = "lblclientes_Titulo";
            this.lblclientes_Titulo.Size = new System.Drawing.Size(368, 44);
            this.lblclientes_Titulo.TabIndex = 72;
            this.lblclientes_Titulo.Text = "Registro de clientes";
            // 
            // ckb_ListarInactivos
            // 
            this.ckb_ListarInactivos.AutoSize = true;
            this.ckb_ListarInactivos.ForeColor = System.Drawing.Color.White;
            this.ckb_ListarInactivos.Location = new System.Drawing.Point(996, 45);
            this.ckb_ListarInactivos.Name = "ckb_ListarInactivos";
            this.ckb_ListarInactivos.Size = new System.Drawing.Size(96, 17);
            this.ckb_ListarInactivos.TabIndex = 122;
            this.ckb_ListarInactivos.Text = "Listar inactivos";
            this.ckb_ListarInactivos.UseVisualStyleBackColor = true;
            this.ckb_ListarInactivos.CheckedChanged += new System.EventHandler(this.ckb_ListarInactivos_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnCliente_Eliminar);
            this.panel1.Controls.Add(this.dp_FechaNacimiento);
            this.panel1.Controls.Add(this.btn_Modificar);
            this.panel1.Controls.Add(this.btn_Limpiar);
            this.panel1.Controls.Add(this.ckb_Activar);
            this.panel1.Controls.Add(this.lblCliente_FechaNacimiento);
            this.panel1.Controls.Add(this.txb_Telefono);
            this.panel1.Controls.Add(this.lblCliente_Telefono);
            this.panel1.Controls.Add(this.txb_CorreoElectronico);
            this.panel1.Controls.Add(this.lblCliente_correoElectronico);
            this.panel1.Controls.Add(this.txb_Cedula);
            this.panel1.Controls.Add(this.lblCliente_Cedula);
            this.panel1.Controls.Add(this.txb_Nombre);
            this.panel1.Controls.Add(this.lblCliente_Nombre);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.btn_Insertar);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 436);
            this.panel1.TabIndex = 1;
            // 
            // BtnCliente_Eliminar
            // 
            this.BtnCliente_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.BtnCliente_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCliente_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnCliente_Eliminar.ForeColor = System.Drawing.Color.White;
            this.BtnCliente_Eliminar.Location = new System.Drawing.Point(188, 223);
            this.BtnCliente_Eliminar.Name = "BtnCliente_Eliminar";
            this.BtnCliente_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnCliente_Eliminar.TabIndex = 120;
            this.BtnCliente_Eliminar.Text = "Eliminar";
            this.BtnCliente_Eliminar.UseVisualStyleBackColor = false;
            this.BtnCliente_Eliminar.Click += new System.EventHandler(this.BtnCliente_Eliminar_Click);
            // 
            // dp_FechaNacimiento
            // 
            this.dp_FechaNacimiento.Location = new System.Drawing.Point(128, 110);
            this.dp_FechaNacimiento.Name = "dp_FechaNacimiento";
            this.dp_FechaNacimiento.Size = new System.Drawing.Size(135, 20);
            this.dp_FechaNacimiento.TabIndex = 4;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.btn_Modificar.Location = new System.Drawing.Point(188, 194);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 7;
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
            this.btn_Limpiar.Location = new System.Drawing.Point(188, 165);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 6;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // ckb_Activar
            // 
            this.ckb_Activar.AutoSize = true;
            this.ckb_Activar.ForeColor = System.Drawing.Color.White;
            this.ckb_Activar.Location = new System.Drawing.Point(18, 136);
            this.ckb_Activar.Name = "ckb_Activar";
            this.ckb_Activar.Size = new System.Drawing.Size(56, 17);
            this.ckb_Activar.TabIndex = 119;
            this.ckb_Activar.Text = "Artivar";
            this.ckb_Activar.UseVisualStyleBackColor = true;
            // 
            // lblCliente_FechaNacimiento
            // 
            this.lblCliente_FechaNacimiento.AutoSize = true;
            this.lblCliente_FechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblCliente_FechaNacimiento.Location = new System.Drawing.Point(15, 110);
            this.lblCliente_FechaNacimiento.Name = "lblCliente_FechaNacimiento";
            this.lblCliente_FechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lblCliente_FechaNacimiento.TabIndex = 83;
            this.lblCliente_FechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // txb_Telefono
            // 
            this.txb_Telefono.Location = new System.Drawing.Point(128, 84);
            this.txb_Telefono.MaxLength = 20;
            this.txb_Telefono.Name = "txb_Telefono";
            this.txb_Telefono.Size = new System.Drawing.Size(135, 20);
            this.txb_Telefono.TabIndex = 3;
            // 
            // lblCliente_Telefono
            // 
            this.lblCliente_Telefono.AutoSize = true;
            this.lblCliente_Telefono.ForeColor = System.Drawing.Color.White;
            this.lblCliente_Telefono.Location = new System.Drawing.Point(15, 87);
            this.lblCliente_Telefono.Name = "lblCliente_Telefono";
            this.lblCliente_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lblCliente_Telefono.TabIndex = 81;
            this.lblCliente_Telefono.Text = "Teléfono";
            // 
            // txb_CorreoElectronico
            // 
            this.txb_CorreoElectronico.Location = new System.Drawing.Point(128, 58);
            this.txb_CorreoElectronico.MaxLength = 100;
            this.txb_CorreoElectronico.Name = "txb_CorreoElectronico";
            this.txb_CorreoElectronico.Size = new System.Drawing.Size(135, 20);
            this.txb_CorreoElectronico.TabIndex = 2;
            // 
            // lblCliente_correoElectronico
            // 
            this.lblCliente_correoElectronico.AutoSize = true;
            this.lblCliente_correoElectronico.ForeColor = System.Drawing.Color.White;
            this.lblCliente_correoElectronico.Location = new System.Drawing.Point(15, 61);
            this.lblCliente_correoElectronico.Name = "lblCliente_correoElectronico";
            this.lblCliente_correoElectronico.Size = new System.Drawing.Size(93, 13);
            this.lblCliente_correoElectronico.TabIndex = 79;
            this.lblCliente_correoElectronico.Text = "Correo electrónico";
            // 
            // txb_Cedula
            // 
            this.txb_Cedula.Location = new System.Drawing.Point(128, 32);
            this.txb_Cedula.MaxLength = 20;
            this.txb_Cedula.Name = "txb_Cedula";
            this.txb_Cedula.Size = new System.Drawing.Size(135, 20);
            this.txb_Cedula.TabIndex = 1;
            // 
            // lblCliente_Cedula
            // 
            this.lblCliente_Cedula.AutoSize = true;
            this.lblCliente_Cedula.ForeColor = System.Drawing.Color.White;
            this.lblCliente_Cedula.Location = new System.Drawing.Point(15, 35);
            this.lblCliente_Cedula.Name = "lblCliente_Cedula";
            this.lblCliente_Cedula.Size = new System.Drawing.Size(40, 13);
            this.lblCliente_Cedula.TabIndex = 77;
            this.lblCliente_Cedula.Text = "Cédula";
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(128, 6);
            this.txb_Nombre.MaxLength = 50;
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(135, 20);
            this.txb_Nombre.TabIndex = 0;
            // 
            // lblCliente_Nombre
            // 
            this.lblCliente_Nombre.AutoSize = true;
            this.lblCliente_Nombre.ForeColor = System.Drawing.Color.White;
            this.lblCliente_Nombre.Location = new System.Drawing.Point(15, 9);
            this.lblCliente_Nombre.Name = "lblCliente_Nombre";
            this.lblCliente_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lblCliente_Nombre.TabIndex = 75;
            this.lblCliente_Nombre.Text = "Nombre";
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
            this.dgv.Size = new System.Drawing.Size(821, 415);
            this.dgv.TabIndex = 8;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellDoubleClick);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Insertar.ForeColor = System.Drawing.Color.White;
            this.btn_Insertar.Location = new System.Drawing.Point(188, 136);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btn_Insertar.TabIndex = 5;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = false;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1093, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_supCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroCliente";
            this.Text = "frmRegistroCliente";
            this.panel_supCliente.ResumeLayout(false);
            this.panel_supCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_supCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblclientes_Titulo;
        private System.Windows.Forms.Label lblCliente_FechaNacimiento;
        private System.Windows.Forms.TextBox txb_Telefono;
        private System.Windows.Forms.Label lblCliente_Telefono;
        private System.Windows.Forms.TextBox txb_CorreoElectronico;
        private System.Windows.Forms.Label lblCliente_correoElectronico;
        private System.Windows.Forms.TextBox txb_Cedula;
        private System.Windows.Forms.Label lblCliente_Cedula;
        private System.Windows.Forms.TextBox txb_Nombre;
        private System.Windows.Forms.Label lblCliente_Nombre;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.CheckBox ckb_Activar;
        private System.Windows.Forms.CheckBox ckb_ListarInactivos;
        private System.Windows.Forms.DateTimePicker dp_FechaNacimiento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BtnCliente_Eliminar;
    }
}