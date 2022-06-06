
namespace CapaPresentacion.Modulos_Registros
{
    partial class frmAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCliente));
            this.dp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblCliente_FechaNacimiento = new System.Windows.Forms.Label();
            this.txb_Telefono = new System.Windows.Forms.TextBox();
            this.lblCliente_Telefono = new System.Windows.Forms.Label();
            this.txb_CorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblCliente_correoElectronico = new System.Windows.Forms.Label();
            this.txb_Cedula = new System.Windows.Forms.TextBox();
            this.lblCliente_Cedula = new System.Windows.Forms.Label();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.lblCliente_Nombre = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl = new System.Windows.Forms.Label();
            this.ibtnCerrar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dp_FechaNacimiento
            // 
            this.dp_FechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dp_FechaNacimiento.Location = new System.Drawing.Point(185, 214);
            this.dp_FechaNacimiento.Name = "dp_FechaNacimiento";
            this.dp_FechaNacimiento.Size = new System.Drawing.Size(192, 23);
            this.dp_FechaNacimiento.TabIndex = 4;
            this.dp_FechaNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            // 
            // lblCliente_FechaNacimiento
            // 
            this.lblCliente_FechaNacimiento.AutoSize = true;
            this.lblCliente_FechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCliente_FechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblCliente_FechaNacimiento.Location = new System.Drawing.Point(18, 219);
            this.lblCliente_FechaNacimiento.Name = "lblCliente_FechaNacimiento";
            this.lblCliente_FechaNacimiento.Size = new System.Drawing.Size(139, 17);
            this.lblCliente_FechaNacimiento.TabIndex = 132;
            this.lblCliente_FechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // txb_Telefono
            // 
            this.txb_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txb_Telefono.Location = new System.Drawing.Point(185, 185);
            this.txb_Telefono.MaxLength = 20;
            this.txb_Telefono.Name = "txb_Telefono";
            this.txb_Telefono.Size = new System.Drawing.Size(192, 23);
            this.txb_Telefono.TabIndex = 3;
            this.txb_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            // 
            // lblCliente_Telefono
            // 
            this.lblCliente_Telefono.AutoSize = true;
            this.lblCliente_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCliente_Telefono.ForeColor = System.Drawing.Color.White;
            this.lblCliente_Telefono.Location = new System.Drawing.Point(18, 188);
            this.lblCliente_Telefono.Name = "lblCliente_Telefono";
            this.lblCliente_Telefono.Size = new System.Drawing.Size(64, 17);
            this.lblCliente_Telefono.TabIndex = 130;
            this.lblCliente_Telefono.Text = "Teléfono";
            // 
            // txb_CorreoElectronico
            // 
            this.txb_CorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txb_CorreoElectronico.Location = new System.Drawing.Point(185, 156);
            this.txb_CorreoElectronico.MaxLength = 100;
            this.txb_CorreoElectronico.Name = "txb_CorreoElectronico";
            this.txb_CorreoElectronico.Size = new System.Drawing.Size(192, 23);
            this.txb_CorreoElectronico.TabIndex = 2;
            this.txb_CorreoElectronico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            // 
            // lblCliente_correoElectronico
            // 
            this.lblCliente_correoElectronico.AutoSize = true;
            this.lblCliente_correoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCliente_correoElectronico.ForeColor = System.Drawing.Color.White;
            this.lblCliente_correoElectronico.Location = new System.Drawing.Point(18, 159);
            this.lblCliente_correoElectronico.Name = "lblCliente_correoElectronico";
            this.lblCliente_correoElectronico.Size = new System.Drawing.Size(124, 17);
            this.lblCliente_correoElectronico.TabIndex = 128;
            this.lblCliente_correoElectronico.Text = "Correo electrónico";
            // 
            // txb_Cedula
            // 
            this.txb_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txb_Cedula.Location = new System.Drawing.Point(185, 127);
            this.txb_Cedula.MaxLength = 20;
            this.txb_Cedula.Name = "txb_Cedula";
            this.txb_Cedula.Size = new System.Drawing.Size(192, 23);
            this.txb_Cedula.TabIndex = 1;
            this.txb_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            // 
            // lblCliente_Cedula
            // 
            this.lblCliente_Cedula.AutoSize = true;
            this.lblCliente_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCliente_Cedula.ForeColor = System.Drawing.Color.White;
            this.lblCliente_Cedula.Location = new System.Drawing.Point(18, 130);
            this.lblCliente_Cedula.Name = "lblCliente_Cedula";
            this.lblCliente_Cedula.Size = new System.Drawing.Size(52, 17);
            this.lblCliente_Cedula.TabIndex = 126;
            this.lblCliente_Cedula.Text = "Cédula";
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txb_Nombre.Location = new System.Drawing.Point(185, 98);
            this.txb_Nombre.MaxLength = 50;
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(192, 23);
            this.txb_Nombre.TabIndex = 0;
            this.txb_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            // 
            // lblCliente_Nombre
            // 
            this.lblCliente_Nombre.AutoSize = true;
            this.lblCliente_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCliente_Nombre.ForeColor = System.Drawing.Color.White;
            this.lblCliente_Nombre.Location = new System.Drawing.Point(18, 101);
            this.lblCliente_Nombre.Name = "lblCliente_Nombre";
            this.lblCliente_Nombre.Size = new System.Drawing.Size(58, 17);
            this.lblCliente_Nombre.TabIndex = 124;
            this.lblCliente_Nombre.Text = "Nombre";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.Location = new System.Drawing.Point(15, 243);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(178, 39);
            this.btn_Limpiar.TabIndex = 6;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Insertar.ForeColor = System.Drawing.Color.White;
            this.btn_Insertar.Location = new System.Drawing.Point(199, 243);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(178, 39);
            this.btn_Insertar.TabIndex = 5;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = false;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(12, 32);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(380, 39);
            this.lbl.TabIndex = 133;
            this.lbl.Text = "Agregar Nuevo Cliente";
            // 
            // ibtnCerrar
            // 
            this.ibtnCerrar.FlatAppearance.BorderSize = 0;
            this.ibtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ibtnCerrar.IconColor = System.Drawing.Color.White;
            this.ibtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCerrar.IconSize = 25;
            this.ibtnCerrar.Location = new System.Drawing.Point(371, 12);
            this.ibtnCerrar.Name = "ibtnCerrar";
            this.ibtnCerrar.Size = new System.Drawing.Size(22, 30);
            this.ibtnCerrar.TabIndex = 134;
            this.ibtnCerrar.UseVisualStyleBackColor = true;
            this.ibtnCerrar.Click += new System.EventHandler(this.ibtnCerrar_Click);
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(401, 313);
            this.Controls.Add(this.ibtnCerrar);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Insertar);
            this.Controls.Add(this.dp_FechaNacimiento);
            this.Controls.Add(this.lblCliente_FechaNacimiento);
            this.Controls.Add(this.txb_Telefono);
            this.Controls.Add(this.lblCliente_Telefono);
            this.Controls.Add(this.txb_CorreoElectronico);
            this.Controls.Add(this.lblCliente_correoElectronico);
            this.Controls.Add(this.txb_Cedula);
            this.Controls.Add(this.lblCliente_Cedula);
            this.Controls.Add(this.txb_Nombre);
            this.Controls.Add(this.lblCliente_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarCliente";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dp_FechaNacimiento;
        private System.Windows.Forms.Label lblCliente_FechaNacimiento;
        private System.Windows.Forms.TextBox txb_Telefono;
        private System.Windows.Forms.Label lblCliente_Telefono;
        private System.Windows.Forms.TextBox txb_CorreoElectronico;
        private System.Windows.Forms.Label lblCliente_correoElectronico;
        private System.Windows.Forms.TextBox txb_Cedula;
        private System.Windows.Forms.Label lblCliente_Cedula;
        private System.Windows.Forms.TextBox txb_Nombre;
        private System.Windows.Forms.Label lblCliente_Nombre;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl;
        private FontAwesome.Sharp.IconButton ibtnCerrar;
    }
}