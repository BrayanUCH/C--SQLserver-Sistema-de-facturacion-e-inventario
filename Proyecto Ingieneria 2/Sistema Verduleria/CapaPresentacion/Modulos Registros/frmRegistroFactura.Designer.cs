
namespace CapaPresentacion.Modulos_Registros
{
    partial class frmRegistroFactura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckb_numeroFactura = new System.Windows.Forms.CheckBox();
            this.ckb_fecha = new System.Windows.Forms.CheckBox();
            this.txb_filtradoFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.txb_filtradoFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_detalleFactura = new System.Windows.Forms.DataGridView();
            this.dgv_facturas = new System.Windows.Forms.DataGridView();
            this.panel_supCliente = new System.Windows.Forms.Panel();
            this.lblclientes_Titulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalleFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facturas)).BeginInit();
            this.panel_supCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.ckb_numeroFactura);
            this.panel1.Controls.Add(this.ckb_fecha);
            this.panel1.Controls.Add(this.txb_filtradoFactura);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Limpiar);
            this.panel1.Controls.Add(this.txb_filtradoFecha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_detalleFactura);
            this.panel1.Controls.Add(this.dgv_facturas);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 436);
            this.panel1.TabIndex = 3;
            // 
            // ckb_numeroFactura
            // 
            this.ckb_numeroFactura.AutoSize = true;
            this.ckb_numeroFactura.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ckb_numeroFactura.Location = new System.Drawing.Point(483, 74);
            this.ckb_numeroFactura.Name = "ckb_numeroFactura";
            this.ckb_numeroFactura.Size = new System.Drawing.Size(15, 14);
            this.ckb_numeroFactura.TabIndex = 10;
            this.ckb_numeroFactura.UseVisualStyleBackColor = true;
            this.ckb_numeroFactura.CheckedChanged += new System.EventHandler(this.ckb_numeroFactura_CheckedChanged);
            // 
            // ckb_fecha
            // 
            this.ckb_fecha.AutoSize = true;
            this.ckb_fecha.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ckb_fecha.Location = new System.Drawing.Point(483, 44);
            this.ckb_fecha.Name = "ckb_fecha";
            this.ckb_fecha.Size = new System.Drawing.Size(15, 14);
            this.ckb_fecha.TabIndex = 9;
            this.ckb_fecha.UseVisualStyleBackColor = true;
            this.ckb_fecha.CheckedChanged += new System.EventHandler(this.ckb_fecha_CheckedChanged);
            // 
            // txb_filtradoFactura
            // 
            this.txb_filtradoFactura.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txb_filtradoFactura.Location = new System.Drawing.Point(245, 69);
            this.txb_filtradoFactura.Name = "txb_filtradoFactura";
            this.txb_filtradoFactura.Size = new System.Drawing.Size(232, 24);
            this.txb_filtradoFactura.TabIndex = 8;
            this.txb_filtradoFactura.TextChanged += new System.EventHandler(this.txb_filtradoFactura_TextChanged);
            this.txb_filtradoFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_filtradoFactura_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(14, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Filtrado por numero de factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filtrado por fecha";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Limpiar.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpiar.Location = new System.Drawing.Point(954, 7);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(129, 33);
            this.btn_Limpiar.TabIndex = 5;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // txb_filtradoFecha
            // 
            this.txb_filtradoFecha.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txb_filtradoFecha.Location = new System.Drawing.Point(245, 39);
            this.txb_filtradoFecha.Name = "txb_filtradoFecha";
            this.txb_filtradoFecha.Size = new System.Drawing.Size(232, 24);
            this.txb_filtradoFecha.TabIndex = 4;
            this.txb_filtradoFecha.TextChanged += new System.EventHandler(this.txb_filtradoFecha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(498, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Información de las facturas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Facturas";
            // 
            // dgv_detalleFactura
            // 
            this.dgv_detalleFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_detalleFactura.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_detalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalleFactura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_detalleFactura.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_detalleFactura.Location = new System.Drawing.Point(504, 43);
            this.dgv_detalleFactura.Name = "dgv_detalleFactura";
            this.dgv_detalleFactura.Size = new System.Drawing.Size(585, 390);
            this.dgv_detalleFactura.TabIndex = 1;
            // 
            // dgv_facturas
            // 
            this.dgv_facturas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_facturas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_facturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_facturas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_facturas.Location = new System.Drawing.Point(8, 99);
            this.dgv_facturas.Name = "dgv_facturas";
            this.dgv_facturas.Size = new System.Drawing.Size(490, 334);
            this.dgv_facturas.TabIndex = 0;
            this.dgv_facturas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_facturas_CellDoubleClick);
            // 
            // panel_supCliente
            // 
            this.panel_supCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_supCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_supCliente.Controls.Add(this.lblclientes_Titulo);
            this.panel_supCliente.Location = new System.Drawing.Point(0, 0);
            this.panel_supCliente.Name = "panel_supCliente";
            this.panel_supCliente.Size = new System.Drawing.Size(1095, 65);
            this.panel_supCliente.TabIndex = 2;
            // 
            // lblclientes_Titulo
            // 
            this.lblclientes_Titulo.AutoSize = true;
            this.lblclientes_Titulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclientes_Titulo.ForeColor = System.Drawing.Color.White;
            this.lblclientes_Titulo.Location = new System.Drawing.Point(0, 9);
            this.lblclientes_Titulo.Name = "lblclientes_Titulo";
            this.lblclientes_Titulo.Size = new System.Drawing.Size(370, 44);
            this.lblclientes_Titulo.TabIndex = 72;
            this.lblclientes_Titulo.Text = "Historial de facturas";
            // 
            // frmRegistroFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1095, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_supCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroFactura";
            this.Text = "frmFactura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalleFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facturas)).EndInit();
            this.panel_supCliente.ResumeLayout(false);
            this.panel_supCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_supCliente;
        private System.Windows.Forms.Label lblclientes_Titulo;
        private System.Windows.Forms.DataGridView dgv_detalleFactura;
        private System.Windows.Forms.DataGridView dgv_facturas;
        private System.Windows.Forms.TextBox txb_filtradoFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.CheckBox ckb_numeroFactura;
        private System.Windows.Forms.CheckBox ckb_fecha;
        private System.Windows.Forms.TextBox txb_filtradoFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}