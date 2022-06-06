namespace CapaPresentacion.Modulos
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.ibtn_Reportes = new FontAwesome.Sharp.IconButton();
            this.ibtn_CunetasPorPagar = new FontAwesome.Sharp.IconButton();
            this.ibtn_Inventario = new FontAwesome.Sharp.IconButton();
            this.ibtn_Mantenimientos = new FontAwesome.Sharp.IconButton();
            this.ibtn_Facturacion = new FontAwesome.Sharp.IconButton();
            this.ibtn_Sistema = new FontAwesome.Sharp.IconButton();
            this.panel_Img = new System.Windows.Forms.Panel();
            this.pbox_Logo = new System.Windows.Forms.PictureBox();
            this.panel_barra = new System.Windows.Forms.Panel();
            this.btn_cerrarSeccion = new FontAwesome.Sharp.IconButton();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.ibtn_Menu = new FontAwesome.Sharp.IconButton();
            this.panel_escritorio = new System.Windows.Forms.Panel();
            this.fecha = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Menu.SuspendLayout();
            this.panel_Img.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Logo)).BeginInit();
            this.panel_barra.SuspendLayout();
            this.panel_escritorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.panel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Menu.Controls.Add(this.ibtn_Reportes);
            this.panel_Menu.Controls.Add(this.ibtn_CunetasPorPagar);
            this.panel_Menu.Controls.Add(this.ibtn_Inventario);
            this.panel_Menu.Controls.Add(this.ibtn_Mantenimientos);
            this.panel_Menu.Controls.Add(this.ibtn_Facturacion);
            this.panel_Menu.Controls.Add(this.ibtn_Sistema);
            this.panel_Menu.Controls.Add(this.panel_Img);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(220, 591);
            this.panel_Menu.TabIndex = 0;
            // 
            // ibtn_Reportes
            // 
            this.ibtn_Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_Reportes.FlatAppearance.BorderSize = 0;
            this.ibtn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Reportes.ForeColor = System.Drawing.Color.White;
            this.ibtn_Reportes.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.ibtn_Reportes.IconColor = System.Drawing.Color.White;
            this.ibtn_Reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_Reportes.IconSize = 35;
            this.ibtn_Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Reportes.Location = new System.Drawing.Point(0, 325);
            this.ibtn_Reportes.Name = "ibtn_Reportes";
            this.ibtn_Reportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_Reportes.Size = new System.Drawing.Size(218, 45);
            this.ibtn_Reportes.TabIndex = 6;
            this.ibtn_Reportes.Text = "Reportes";
            this.ibtn_Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_Reportes.UseVisualStyleBackColor = true;
            this.ibtn_Reportes.Click += new System.EventHandler(this.ibtn_Reportes_Click);
            // 
            // ibtn_CunetasPorPagar
            // 
            this.ibtn_CunetasPorPagar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_CunetasPorPagar.FlatAppearance.BorderSize = 0;
            this.ibtn_CunetasPorPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_CunetasPorPagar.ForeColor = System.Drawing.Color.White;
            this.ibtn_CunetasPorPagar.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.ibtn_CunetasPorPagar.IconColor = System.Drawing.Color.White;
            this.ibtn_CunetasPorPagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_CunetasPorPagar.IconSize = 35;
            this.ibtn_CunetasPorPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_CunetasPorPagar.Location = new System.Drawing.Point(0, 280);
            this.ibtn_CunetasPorPagar.Name = "ibtn_CunetasPorPagar";
            this.ibtn_CunetasPorPagar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_CunetasPorPagar.Size = new System.Drawing.Size(218, 45);
            this.ibtn_CunetasPorPagar.TabIndex = 5;
            this.ibtn_CunetasPorPagar.Text = "Cuentas por pagar";
            this.ibtn_CunetasPorPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_CunetasPorPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_CunetasPorPagar.UseVisualStyleBackColor = true;
            this.ibtn_CunetasPorPagar.Click += new System.EventHandler(this.ibtn_CunetasPorPagar_Click);
            // 
            // ibtn_Inventario
            // 
            this.ibtn_Inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_Inventario.FlatAppearance.BorderSize = 0;
            this.ibtn_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Inventario.ForeColor = System.Drawing.Color.White;
            this.ibtn_Inventario.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.ibtn_Inventario.IconColor = System.Drawing.Color.White;
            this.ibtn_Inventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_Inventario.IconSize = 35;
            this.ibtn_Inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Inventario.Location = new System.Drawing.Point(0, 235);
            this.ibtn_Inventario.Name = "ibtn_Inventario";
            this.ibtn_Inventario.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_Inventario.Size = new System.Drawing.Size(218, 45);
            this.ibtn_Inventario.TabIndex = 4;
            this.ibtn_Inventario.Text = "Inventario";
            this.ibtn_Inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Inventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_Inventario.UseVisualStyleBackColor = true;
            this.ibtn_Inventario.Click += new System.EventHandler(this.ibtn_Inventario_Click);
            // 
            // ibtn_Mantenimientos
            // 
            this.ibtn_Mantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_Mantenimientos.FlatAppearance.BorderSize = 0;
            this.ibtn_Mantenimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Mantenimientos.ForeColor = System.Drawing.Color.White;
            this.ibtn_Mantenimientos.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.ibtn_Mantenimientos.IconColor = System.Drawing.Color.White;
            this.ibtn_Mantenimientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_Mantenimientos.IconSize = 35;
            this.ibtn_Mantenimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Mantenimientos.Location = new System.Drawing.Point(0, 190);
            this.ibtn_Mantenimientos.Name = "ibtn_Mantenimientos";
            this.ibtn_Mantenimientos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_Mantenimientos.Size = new System.Drawing.Size(218, 45);
            this.ibtn_Mantenimientos.TabIndex = 3;
            this.ibtn_Mantenimientos.Text = "Mantenimiento";
            this.ibtn_Mantenimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Mantenimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_Mantenimientos.UseVisualStyleBackColor = true;
            this.ibtn_Mantenimientos.Click += new System.EventHandler(this.ibtn_Mantenimientos_Click);
            // 
            // ibtn_Facturacion
            // 
            this.ibtn_Facturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_Facturacion.FlatAppearance.BorderSize = 0;
            this.ibtn_Facturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Facturacion.ForeColor = System.Drawing.Color.White;
            this.ibtn_Facturacion.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.ibtn_Facturacion.IconColor = System.Drawing.Color.White;
            this.ibtn_Facturacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_Facturacion.IconSize = 35;
            this.ibtn_Facturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Facturacion.Location = new System.Drawing.Point(0, 145);
            this.ibtn_Facturacion.Name = "ibtn_Facturacion";
            this.ibtn_Facturacion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_Facturacion.Size = new System.Drawing.Size(218, 45);
            this.ibtn_Facturacion.TabIndex = 2;
            this.ibtn_Facturacion.Text = "Facturación";
            this.ibtn_Facturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Facturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_Facturacion.UseVisualStyleBackColor = true;
            this.ibtn_Facturacion.Click += new System.EventHandler(this.ibtn_Facturacion_Click);
            // 
            // ibtn_Sistema
            // 
            this.ibtn_Sistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_Sistema.FlatAppearance.BorderSize = 0;
            this.ibtn_Sistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Sistema.ForeColor = System.Drawing.Color.White;
            this.ibtn_Sistema.IconChar = FontAwesome.Sharp.IconChar.Tv;
            this.ibtn_Sistema.IconColor = System.Drawing.Color.White;
            this.ibtn_Sistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_Sistema.IconSize = 35;
            this.ibtn_Sistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Sistema.Location = new System.Drawing.Point(0, 100);
            this.ibtn_Sistema.Name = "ibtn_Sistema";
            this.ibtn_Sistema.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_Sistema.Size = new System.Drawing.Size(218, 45);
            this.ibtn_Sistema.TabIndex = 1;
            this.ibtn_Sistema.Text = "Sistema";
            this.ibtn_Sistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Sistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_Sistema.UseVisualStyleBackColor = true;
            this.ibtn_Sistema.Click += new System.EventHandler(this.ibtn_Sistema_Click);
            // 
            // panel_Img
            // 
            this.panel_Img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Img.Controls.Add(this.pbox_Logo);
            this.panel_Img.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Img.Location = new System.Drawing.Point(0, 0);
            this.panel_Img.Name = "panel_Img";
            this.panel_Img.Size = new System.Drawing.Size(218, 100);
            this.panel_Img.TabIndex = 0;
            // 
            // pbox_Logo
            // 
            this.pbox_Logo.Image = global::CapaPresentacion.Properties.Resources.Logo_Principal;
            this.pbox_Logo.Location = new System.Drawing.Point(-2, -2);
            this.pbox_Logo.Name = "pbox_Logo";
            this.pbox_Logo.Size = new System.Drawing.Size(215, 97);
            this.pbox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Logo.TabIndex = 0;
            this.pbox_Logo.TabStop = false;
            this.pbox_Logo.Click += new System.EventHandler(this.pbox_Logo_Click);
            // 
            // panel_barra
            // 
            this.panel_barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.panel_barra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_barra.Controls.Add(this.btn_cerrarSeccion);
            this.panel_barra.Controls.Add(this.lbl_Menu);
            this.panel_barra.Controls.Add(this.ibtn_Menu);
            this.panel_barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_barra.Location = new System.Drawing.Point(220, 0);
            this.panel_barra.Name = "panel_barra";
            this.panel_barra.Size = new System.Drawing.Size(1093, 67);
            this.panel_barra.TabIndex = 1;
            // 
            // btn_cerrarSeccion
            // 
            this.btn_cerrarSeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_cerrarSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrarSeccion.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows;
            this.btn_cerrarSeccion.IconColor = System.Drawing.Color.Black;
            this.btn_cerrarSeccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cerrarSeccion.Location = new System.Drawing.Point(1007, 0);
            this.btn_cerrarSeccion.Name = "btn_cerrarSeccion";
            this.btn_cerrarSeccion.Size = new System.Drawing.Size(86, 67);
            this.btn_cerrarSeccion.TabIndex = 4;
            this.btn_cerrarSeccion.UseVisualStyleBackColor = false;
            this.btn_cerrarSeccion.Click += new System.EventHandler(this.btn_cerrarSeccion_Click);
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.ForeColor = System.Drawing.Color.White;
            this.lbl_Menu.Location = new System.Drawing.Point(53, 27);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(34, 13);
            this.lbl_Menu.TabIndex = 1;
            this.lbl_Menu.Text = "Menú";
            // 
            // ibtn_Menu
            // 
            this.ibtn_Menu.FlatAppearance.BorderSize = 0;
            this.ibtn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Menu.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtn_Menu.IconColor = System.Drawing.Color.White;
            this.ibtn_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_Menu.IconSize = 30;
            this.ibtn_Menu.Location = new System.Drawing.Point(6, 16);
            this.ibtn_Menu.Name = "ibtn_Menu";
            this.ibtn_Menu.Size = new System.Drawing.Size(42, 34);
            this.ibtn_Menu.TabIndex = 0;
            this.ibtn_Menu.UseVisualStyleBackColor = true;
            // 
            // panel_escritorio
            // 
            this.panel_escritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_escritorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_escritorio.Controls.Add(this.fecha);
            this.panel_escritorio.Controls.Add(this.hora);
            this.panel_escritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_escritorio.Location = new System.Drawing.Point(220, 67);
            this.panel_escritorio.Name = "panel_escritorio";
            this.panel_escritorio.Size = new System.Drawing.Size(1093, 524);
            this.panel_escritorio.TabIndex = 2;
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F);
            this.fecha.Location = new System.Drawing.Point(237, 258);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(145, 57);
            this.fecha.TabIndex = 1;
            this.fecha.Text = "fecha";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 72.25F);
            this.hora.Location = new System.Drawing.Point(233, 123);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(241, 109);
            this.hora.TabIndex = 0;
            this.hora.Text = "hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1313, 591);
            this.Controls.Add(this.panel_escritorio);
            this.Controls.Add(this.panel_barra);
            this.Controls.Add(this.panel_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1329, 630);
            this.MinimumSize = new System.Drawing.Size(1329, 630);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de venta";
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Img.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Logo)).EndInit();
            this.panel_barra.ResumeLayout(false);
            this.panel_barra.PerformLayout();
            this.panel_escritorio.ResumeLayout(false);
            this.panel_escritorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_Img;
        private System.Windows.Forms.PictureBox pbox_Logo;
        private FontAwesome.Sharp.IconButton ibtn_Reportes;
        private FontAwesome.Sharp.IconButton ibtn_CunetasPorPagar;
        private FontAwesome.Sharp.IconButton ibtn_Mantenimientos;
        private FontAwesome.Sharp.IconButton ibtn_Facturacion;
        private FontAwesome.Sharp.IconButton ibtn_Sistema;
        private System.Windows.Forms.Panel panel_barra;
        private FontAwesome.Sharp.IconButton ibtn_Menu;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Panel panel_escritorio;
        private FontAwesome.Sharp.IconButton ibtn_Inventario;
        private FontAwesome.Sharp.IconButton btn_cerrarSeccion;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Timer timer1;
    }
}