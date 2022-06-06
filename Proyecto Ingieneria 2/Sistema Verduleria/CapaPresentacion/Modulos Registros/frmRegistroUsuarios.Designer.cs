namespace CapaPresentacion.Modulos_Registros
{
    partial class frmRegistroUsuarios
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
            this.panel_supUsuarios = new System.Windows.Forms.Panel();
            this.ckb_ListarInactivos = new System.Windows.Forms.CheckBox();
            this.lblUsuarios_Titulo = new System.Windows.Forms.Label();
            this.panel_infUsuarios = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.ckb_Activar = new System.Windows.Forms.CheckBox();
            this.txb_Contraseña = new System.Windows.Forms.TextBox();
            this.lblUsuario_Contraseña = new System.Windows.Forms.Label();
            this.txb_CorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblUsuario_correoElectronico = new System.Windows.Forms.Label();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.lblUsuario_Nombre = new System.Windows.Forms.Label();
            this.txb_Usuario = new System.Windows.Forms.TextBox();
            this.lblUsuario_Usuario = new System.Windows.Forms.Label();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_supUsuarios.SuspendLayout();
            this.panel_infUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_supUsuarios
            // 
            this.panel_supUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_supUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_supUsuarios.Controls.Add(this.ckb_ListarInactivos);
            this.panel_supUsuarios.Controls.Add(this.lblUsuarios_Titulo);
            this.panel_supUsuarios.Location = new System.Drawing.Point(0, 0);
            this.panel_supUsuarios.Name = "panel_supUsuarios";
            this.panel_supUsuarios.Size = new System.Drawing.Size(1095, 65);
            this.panel_supUsuarios.TabIndex = 0;
            // 
            // ckb_ListarInactivos
            // 
            this.ckb_ListarInactivos.AutoSize = true;
            this.ckb_ListarInactivos.ForeColor = System.Drawing.Color.White;
            this.ckb_ListarInactivos.Location = new System.Drawing.Point(996, 45);
            this.ckb_ListarInactivos.Name = "ckb_ListarInactivos";
            this.ckb_ListarInactivos.Size = new System.Drawing.Size(96, 17);
            this.ckb_ListarInactivos.TabIndex = 139;
            this.ckb_ListarInactivos.Text = "Listar inactivos";
            this.ckb_ListarInactivos.UseVisualStyleBackColor = true;
            this.ckb_ListarInactivos.CheckedChanged += new System.EventHandler(this.ckb_ListarInactivos_CheckedChanged);
            // 
            // lblUsuarios_Titulo
            // 
            this.lblUsuarios_Titulo.AutoSize = true;
            this.lblUsuarios_Titulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios_Titulo.ForeColor = System.Drawing.Color.White;
            this.lblUsuarios_Titulo.Location = new System.Drawing.Point(0, 9);
            this.lblUsuarios_Titulo.Name = "lblUsuarios_Titulo";
            this.lblUsuarios_Titulo.Size = new System.Drawing.Size(374, 44);
            this.lblUsuarios_Titulo.TabIndex = 73;
            this.lblUsuarios_Titulo.Text = "Registro de usuarios";
            this.lblUsuarios_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_infUsuarios
            // 
            this.panel_infUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_infUsuarios.AutoSize = true;
            this.panel_infUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_infUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_infUsuarios.Controls.Add(this.btn_Eliminar);
            this.panel_infUsuarios.Controls.Add(this.btn_Modificar);
            this.panel_infUsuarios.Controls.Add(this.btn_Limpiar);
            this.panel_infUsuarios.Controls.Add(this.ckb_Activar);
            this.panel_infUsuarios.Controls.Add(this.txb_Contraseña);
            this.panel_infUsuarios.Controls.Add(this.lblUsuario_Contraseña);
            this.panel_infUsuarios.Controls.Add(this.txb_CorreoElectronico);
            this.panel_infUsuarios.Controls.Add(this.lblUsuario_correoElectronico);
            this.panel_infUsuarios.Controls.Add(this.txb_Nombre);
            this.panel_infUsuarios.Controls.Add(this.lblUsuario_Nombre);
            this.panel_infUsuarios.Controls.Add(this.txb_Usuario);
            this.panel_infUsuarios.Controls.Add(this.lblUsuario_Usuario);
            this.panel_infUsuarios.Controls.Add(this.dgv_Usuarios);
            this.panel_infUsuarios.Controls.Add(this.btn_Insertar);
            this.panel_infUsuarios.Location = new System.Drawing.Point(0, 65);
            this.panel_infUsuarios.Name = "panel_infUsuarios";
            this.panel_infUsuarios.Size = new System.Drawing.Size(1095, 436);
            this.panel_infUsuarios.TabIndex = 1;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(188, 197);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 137;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.btn_Modificar.Location = new System.Drawing.Point(188, 168);
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
            this.btn_Limpiar.Location = new System.Drawing.Point(188, 139);
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
            this.ckb_Activar.Location = new System.Drawing.Point(29, 110);
            this.ckb_Activar.Name = "ckb_Activar";
            this.ckb_Activar.Size = new System.Drawing.Size(56, 17);
            this.ckb_Activar.TabIndex = 136;
            this.ckb_Activar.Text = "Artivar";
            this.ckb_Activar.UseVisualStyleBackColor = true;
            // 
            // txb_Contraseña
            // 
            this.txb_Contraseña.Location = new System.Drawing.Point(128, 58);
            this.txb_Contraseña.MaxLength = 8;
            this.txb_Contraseña.Name = "txb_Contraseña";
            this.txb_Contraseña.Size = new System.Drawing.Size(135, 20);
            this.txb_Contraseña.TabIndex = 2;
            // 
            // lblUsuario_Contraseña
            // 
            this.lblUsuario_Contraseña.AutoSize = true;
            this.lblUsuario_Contraseña.ForeColor = System.Drawing.Color.White;
            this.lblUsuario_Contraseña.Location = new System.Drawing.Point(26, 61);
            this.lblUsuario_Contraseña.Name = "lblUsuario_Contraseña";
            this.lblUsuario_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.lblUsuario_Contraseña.TabIndex = 95;
            this.lblUsuario_Contraseña.Text = "Contraseña";
            // 
            // txb_CorreoElectronico
            // 
            this.txb_CorreoElectronico.Location = new System.Drawing.Point(128, 84);
            this.txb_CorreoElectronico.MaxLength = 100;
            this.txb_CorreoElectronico.Name = "txb_CorreoElectronico";
            this.txb_CorreoElectronico.Size = new System.Drawing.Size(135, 20);
            this.txb_CorreoElectronico.TabIndex = 3;
            // 
            // lblUsuario_correoElectronico
            // 
            this.lblUsuario_correoElectronico.AutoSize = true;
            this.lblUsuario_correoElectronico.ForeColor = System.Drawing.Color.White;
            this.lblUsuario_correoElectronico.Location = new System.Drawing.Point(26, 87);
            this.lblUsuario_correoElectronico.Name = "lblUsuario_correoElectronico";
            this.lblUsuario_correoElectronico.Size = new System.Drawing.Size(93, 13);
            this.lblUsuario_correoElectronico.TabIndex = 93;
            this.lblUsuario_correoElectronico.Text = "Correo electrónico";
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(128, 32);
            this.txb_Nombre.MaxLength = 50;
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(135, 20);
            this.txb_Nombre.TabIndex = 1;
            // 
            // lblUsuario_Nombre
            // 
            this.lblUsuario_Nombre.AutoSize = true;
            this.lblUsuario_Nombre.ForeColor = System.Drawing.Color.White;
            this.lblUsuario_Nombre.Location = new System.Drawing.Point(26, 35);
            this.lblUsuario_Nombre.Name = "lblUsuario_Nombre";
            this.lblUsuario_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lblUsuario_Nombre.TabIndex = 91;
            this.lblUsuario_Nombre.Text = "Nombre";
            // 
            // txb_Usuario
            // 
            this.txb_Usuario.Location = new System.Drawing.Point(128, 6);
            this.txb_Usuario.MaxLength = 10;
            this.txb_Usuario.Name = "txb_Usuario";
            this.txb_Usuario.Size = new System.Drawing.Size(135, 20);
            this.txb_Usuario.TabIndex = 0;
            // 
            // lblUsuario_Usuario
            // 
            this.lblUsuario_Usuario.AutoSize = true;
            this.lblUsuario_Usuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario_Usuario.Location = new System.Drawing.Point(26, 9);
            this.lblUsuario_Usuario.Name = "lblUsuario_Usuario";
            this.lblUsuario_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario_Usuario.TabIndex = 89;
            this.lblUsuario_Usuario.Text = "Usuario";
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Usuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Usuarios.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Usuarios.Location = new System.Drawing.Point(269, 6);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.Size = new System.Drawing.Size(821, 426);
            this.dgv_Usuarios.TabIndex = 7;
            this.dgv_Usuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Insertar.ForeColor = System.Drawing.Color.White;
            this.btn_Insertar.Location = new System.Drawing.Point(188, 110);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btn_Insertar.TabIndex = 4;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = false;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1095, 501);
            this.Controls.Add(this.panel_infUsuarios);
            this.Controls.Add(this.panel_supUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroUsuarios";
            this.Text = "frmRegistroUsuarios";
            this.panel_supUsuarios.ResumeLayout(false);
            this.panel_supUsuarios.PerformLayout();
            this.panel_infUsuarios.ResumeLayout(false);
            this.panel_infUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_supUsuarios;
        private System.Windows.Forms.Panel panel_infUsuarios;
        private System.Windows.Forms.TextBox txb_Contraseña;
        private System.Windows.Forms.Label lblUsuario_Contraseña;
        private System.Windows.Forms.TextBox txb_CorreoElectronico;
        private System.Windows.Forms.Label lblUsuario_correoElectronico;
        private System.Windows.Forms.TextBox txb_Nombre;
        private System.Windows.Forms.Label lblUsuario_Nombre;
        private System.Windows.Forms.TextBox txb_Usuario;
        private System.Windows.Forms.Label lblUsuario_Usuario;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.Label lblUsuarios_Titulo;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.CheckBox ckb_Activar;
        private System.Windows.Forms.CheckBox ckb_ListarInactivos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}