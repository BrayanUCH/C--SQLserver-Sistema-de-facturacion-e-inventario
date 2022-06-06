namespace CapaPresentacion.Modulos_Registros
{
    partial class frmRegistroUnidadesMedida
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
            this.panel_supUnidadesMedida = new System.Windows.Forms.Panel();
            this.ckb_ListarInactivos = new System.Windows.Forms.CheckBox();
            this.lblUnidadesMedida_Titulo = new System.Windows.Forms.Label();
            this.panel_infUnidadesMedida = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.txb_Descripcion = new System.Windows.Forms.RichTextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.ckb_Activar = new System.Windows.Forms.CheckBox();
            this.txb_Abreviatura = new System.Windows.Forms.TextBox();
            this.lblUnidadesMedida_Abreviatura = new System.Windows.Forms.Label();
            this.lblUnidadesMedida_Descripcion = new System.Windows.Forms.Label();
            this.dgv_UnidadesMedida = new System.Windows.Forms.DataGridView();
            this.btnUnidadesMedida_Insertar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_supUnidadesMedida.SuspendLayout();
            this.panel_infUnidadesMedida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UnidadesMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_supUnidadesMedida
            // 
            this.panel_supUnidadesMedida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_supUnidadesMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_supUnidadesMedida.Controls.Add(this.ckb_ListarInactivos);
            this.panel_supUnidadesMedida.Controls.Add(this.lblUnidadesMedida_Titulo);
            this.panel_supUnidadesMedida.Location = new System.Drawing.Point(0, 0);
            this.panel_supUnidadesMedida.Name = "panel_supUnidadesMedida";
            this.panel_supUnidadesMedida.Size = new System.Drawing.Size(1095, 65);
            this.panel_supUnidadesMedida.TabIndex = 0;
            // 
            // ckb_ListarInactivos
            // 
            this.ckb_ListarInactivos.AutoSize = true;
            this.ckb_ListarInactivos.ForeColor = System.Drawing.Color.White;
            this.ckb_ListarInactivos.Location = new System.Drawing.Point(996, 45);
            this.ckb_ListarInactivos.Name = "ckb_ListarInactivos";
            this.ckb_ListarInactivos.Size = new System.Drawing.Size(96, 17);
            this.ckb_ListarInactivos.TabIndex = 136;
            this.ckb_ListarInactivos.Text = "Listar inactivos";
            this.ckb_ListarInactivos.UseVisualStyleBackColor = true;
            this.ckb_ListarInactivos.CheckedChanged += new System.EventHandler(this.ckb_ListarInactivos_CheckedChanged);
            // 
            // lblUnidadesMedida_Titulo
            // 
            this.lblUnidadesMedida_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnidadesMedida_Titulo.AutoSize = true;
            this.lblUnidadesMedida_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.lblUnidadesMedida_Titulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadesMedida_Titulo.ForeColor = System.Drawing.Color.White;
            this.lblUnidadesMedida_Titulo.Location = new System.Drawing.Point(0, 9);
            this.lblUnidadesMedida_Titulo.Name = "lblUnidadesMedida_Titulo";
            this.lblUnidadesMedida_Titulo.Size = new System.Drawing.Size(602, 44);
            this.lblUnidadesMedida_Titulo.TabIndex = 74;
            this.lblUnidadesMedida_Titulo.Text = "Registro de unidades de medida";
            // 
            // panel_infUnidadesMedida
            // 
            this.panel_infUnidadesMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_infUnidadesMedida.AutoSize = true;
            this.panel_infUnidadesMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_infUnidadesMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_infUnidadesMedida.Controls.Add(this.btn_Eliminar);
            this.panel_infUnidadesMedida.Controls.Add(this.txb_Descripcion);
            this.panel_infUnidadesMedida.Controls.Add(this.btn_Modificar);
            this.panel_infUnidadesMedida.Controls.Add(this.btn_Limpiar);
            this.panel_infUnidadesMedida.Controls.Add(this.ckb_Activar);
            this.panel_infUnidadesMedida.Controls.Add(this.txb_Abreviatura);
            this.panel_infUnidadesMedida.Controls.Add(this.lblUnidadesMedida_Abreviatura);
            this.panel_infUnidadesMedida.Controls.Add(this.lblUnidadesMedida_Descripcion);
            this.panel_infUnidadesMedida.Controls.Add(this.dgv_UnidadesMedida);
            this.panel_infUnidadesMedida.Controls.Add(this.btnUnidadesMedida_Insertar);
            this.panel_infUnidadesMedida.Location = new System.Drawing.Point(0, 65);
            this.panel_infUnidadesMedida.Name = "panel_infUnidadesMedida";
            this.panel_infUnidadesMedida.Size = new System.Drawing.Size(1095, 436);
            this.panel_infUnidadesMedida.TabIndex = 1;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(188, 165);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 135;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // txb_Descripcion
            // 
            this.txb_Descripcion.Location = new System.Drawing.Point(128, 6);
            this.txb_Descripcion.MaxLength = 50;
            this.txb_Descripcion.Name = "txb_Descripcion";
            this.txb_Descripcion.Size = new System.Drawing.Size(135, 40);
            this.txb_Descripcion.TabIndex = 134;
            this.txb_Descripcion.Text = "";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.btn_Modificar.Location = new System.Drawing.Point(188, 136);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 4;
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
            this.btn_Limpiar.Location = new System.Drawing.Point(188, 107);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 3;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // ckb_Activar
            // 
            this.ckb_Activar.AutoSize = true;
            this.ckb_Activar.ForeColor = System.Drawing.Color.White;
            this.ckb_Activar.Location = new System.Drawing.Point(29, 78);
            this.ckb_Activar.Name = "ckb_Activar";
            this.ckb_Activar.Size = new System.Drawing.Size(56, 17);
            this.ckb_Activar.TabIndex = 133;
            this.ckb_Activar.Text = "Artivar";
            this.ckb_Activar.UseVisualStyleBackColor = true;
            // 
            // txb_Abreviatura
            // 
            this.txb_Abreviatura.Location = new System.Drawing.Point(128, 52);
            this.txb_Abreviatura.MaxLength = 3;
            this.txb_Abreviatura.Name = "txb_Abreviatura";
            this.txb_Abreviatura.Size = new System.Drawing.Size(135, 20);
            this.txb_Abreviatura.TabIndex = 1;
            // 
            // lblUnidadesMedida_Abreviatura
            // 
            this.lblUnidadesMedida_Abreviatura.AutoSize = true;
            this.lblUnidadesMedida_Abreviatura.ForeColor = System.Drawing.Color.White;
            this.lblUnidadesMedida_Abreviatura.Location = new System.Drawing.Point(26, 55);
            this.lblUnidadesMedida_Abreviatura.Name = "lblUnidadesMedida_Abreviatura";
            this.lblUnidadesMedida_Abreviatura.Size = new System.Drawing.Size(61, 13);
            this.lblUnidadesMedida_Abreviatura.TabIndex = 105;
            this.lblUnidadesMedida_Abreviatura.Text = "Abreviatura";
            // 
            // lblUnidadesMedida_Descripcion
            // 
            this.lblUnidadesMedida_Descripcion.AutoSize = true;
            this.lblUnidadesMedida_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lblUnidadesMedida_Descripcion.Location = new System.Drawing.Point(26, 9);
            this.lblUnidadesMedida_Descripcion.Name = "lblUnidadesMedida_Descripcion";
            this.lblUnidadesMedida_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lblUnidadesMedida_Descripcion.TabIndex = 103;
            this.lblUnidadesMedida_Descripcion.Text = "Descripción";
            // 
            // dgv_UnidadesMedida
            // 
            this.dgv_UnidadesMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_UnidadesMedida.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_UnidadesMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UnidadesMedida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_UnidadesMedida.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_UnidadesMedida.Location = new System.Drawing.Point(269, 6);
            this.dgv_UnidadesMedida.Name = "dgv_UnidadesMedida";
            this.dgv_UnidadesMedida.Size = new System.Drawing.Size(821, 426);
            this.dgv_UnidadesMedida.TabIndex = 5;
            this.dgv_UnidadesMedida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // btnUnidadesMedida_Insertar
            // 
            this.btnUnidadesMedida_Insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btnUnidadesMedida_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnidadesMedida_Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnUnidadesMedida_Insertar.ForeColor = System.Drawing.Color.White;
            this.btnUnidadesMedida_Insertar.Location = new System.Drawing.Point(188, 78);
            this.btnUnidadesMedida_Insertar.Name = "btnUnidadesMedida_Insertar";
            this.btnUnidadesMedida_Insertar.Size = new System.Drawing.Size(75, 23);
            this.btnUnidadesMedida_Insertar.TabIndex = 2;
            this.btnUnidadesMedida_Insertar.Text = "Insertar";
            this.btnUnidadesMedida_Insertar.UseVisualStyleBackColor = false;
            this.btnUnidadesMedida_Insertar.Click += new System.EventHandler(this.btnUnidadesMedida_Insertar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRegistroUnidadesMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1095, 501);
            this.Controls.Add(this.panel_infUnidadesMedida);
            this.Controls.Add(this.panel_supUnidadesMedida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroUnidadesMedida";
            this.Text = "frmUnidadesMedida";
            this.panel_supUnidadesMedida.ResumeLayout(false);
            this.panel_supUnidadesMedida.PerformLayout();
            this.panel_infUnidadesMedida.ResumeLayout(false);
            this.panel_infUnidadesMedida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UnidadesMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_supUnidadesMedida;
        private System.Windows.Forms.Panel panel_infUnidadesMedida;
        private System.Windows.Forms.TextBox txb_Abreviatura;
        private System.Windows.Forms.Label lblUnidadesMedida_Abreviatura;
        private System.Windows.Forms.Label lblUnidadesMedida_Descripcion;
        private System.Windows.Forms.DataGridView dgv_UnidadesMedida;
        private System.Windows.Forms.Button btnUnidadesMedida_Insertar;
        private System.Windows.Forms.Label lblUnidadesMedida_Titulo;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.CheckBox ckb_Activar;
        private System.Windows.Forms.CheckBox ckb_ListarInactivos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RichTextBox txb_Descripcion;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}