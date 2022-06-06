namespace CapaPresentacion
{
    partial class frmLOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLOGIN));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblLOGIN = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ibtnCerrar = new FontAwesome.Sharp.IconButton();
            this.ibtnMinimiza = new FontAwesome.Sharp.IconButton();
            this.lblMensageError = new System.Windows.Forms.Label();
            this.lnk_olvidoContraseña = new System.Windows.Forms.LinkLabel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(653, 291);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.Visible = false;
            this.lineShape3.X1 = 225;
            this.lineShape3.X2 = 590;
            this.lineShape3.Y1 = 145;
            this.lineShape3.Y2 = 145;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.Visible = false;
            this.lineShape1.X1 = 223;
            this.lineShape1.X2 = 588;
            this.lineShape1.Y1 = 105;
            this.lineShape1.Y2 = 105;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(225, 83);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(366, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.Location = new System.Drawing.Point(225, 122);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(366, 20);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // lblLOGIN
            // 
            this.lblLOGIN.AutoSize = true;
            this.lblLOGIN.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOGIN.ForeColor = System.Drawing.Color.White;
            this.lblLOGIN.Location = new System.Drawing.Point(354, 21);
            this.lblLOGIN.Name = "lblLOGIN";
            this.lblLOGIN.Size = new System.Drawing.Size(138, 39);
            this.lblLOGIN.TabIndex = 4;
            this.lblLOGIN.Text = "LOG IN ";
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(225, 192);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(366, 40);
            this.btnAcceder.TabIndex = 2;
            this.btnAcceder.Text = "Log in";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(405, 250);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 16);
            this.linkLabel1.TabIndex = 0;
            // 
            // ibtnCerrar
            // 
            this.ibtnCerrar.FlatAppearance.BorderSize = 0;
            this.ibtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ibtnCerrar.IconColor = System.Drawing.Color.White;
            this.ibtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCerrar.IconSize = 25;
            this.ibtnCerrar.Location = new System.Drawing.Point(624, 0);
            this.ibtnCerrar.Name = "ibtnCerrar";
            this.ibtnCerrar.Size = new System.Drawing.Size(22, 30);
            this.ibtnCerrar.TabIndex = 7;
            this.ibtnCerrar.UseVisualStyleBackColor = true;
            this.ibtnCerrar.Click += new System.EventHandler(this.ibtnCerrar_Click);
            // 
            // ibtnMinimiza
            // 
            this.ibtnMinimiza.FlatAppearance.BorderSize = 0;
            this.ibtnMinimiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMinimiza.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnMinimiza.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.ibtnMinimiza.IconColor = System.Drawing.Color.White;
            this.ibtnMinimiza.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMinimiza.IconSize = 25;
            this.ibtnMinimiza.Location = new System.Drawing.Point(588, 0);
            this.ibtnMinimiza.Name = "ibtnMinimiza";
            this.ibtnMinimiza.Size = new System.Drawing.Size(30, 30);
            this.ibtnMinimiza.TabIndex = 8;
            this.ibtnMinimiza.UseVisualStyleBackColor = true;
            this.ibtnMinimiza.Click += new System.EventHandler(this.ibtnMinimiza_Click);
            // 
            // lblMensageError
            // 
            this.lblMensageError.AutoSize = true;
            this.lblMensageError.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensageError.ForeColor = System.Drawing.Color.Red;
            this.lblMensageError.Location = new System.Drawing.Point(222, 155);
            this.lblMensageError.Name = "lblMensageError";
            this.lblMensageError.Size = new System.Drawing.Size(103, 16);
            this.lblMensageError.TabIndex = 9;
            this.lblMensageError.Text = "Mensage de error";
            this.lblMensageError.Visible = false;
            // 
            // lnk_olvidoContraseña
            // 
            this.lnk_olvidoContraseña.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lnk_olvidoContraseña.AutoSize = true;
            this.lnk_olvidoContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_olvidoContraseña.ForeColor = System.Drawing.Color.White;
            this.lnk_olvidoContraseña.LinkColor = System.Drawing.Color.White;
            this.lnk_olvidoContraseña.Location = new System.Drawing.Point(304, 249);
            this.lnk_olvidoContraseña.Name = "lnk_olvidoContraseña";
            this.lnk_olvidoContraseña.Size = new System.Drawing.Size(199, 17);
            this.lnk_olvidoContraseña.TabIndex = 3;
            this.lnk_olvidoContraseña.TabStop = true;
            this.lnk_olvidoContraseña.Text = "¿Ha olvidado su contraseña?";
            this.lnk_olvidoContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_olvidoContraseña_LinkClicked);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 139;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 73);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(150, 139);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 291);
            this.panel1.TabIndex = 0;
            // 
            // frmLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(653, 291);
            this.Controls.Add(this.lnk_olvidoContraseña);
            this.Controls.Add(this.lblMensageError);
            this.Controls.Add(this.ibtnMinimiza);
            this.Controls.Add(this.ibtnCerrar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.lblLOGIN);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLOGIN";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblLOGIN;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconButton ibtnCerrar;
        private FontAwesome.Sharp.IconButton ibtnMinimiza;
        private System.Windows.Forms.Label lblMensageError;
        private System.Windows.Forms.LinkLabel lnk_olvidoContraseña;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}