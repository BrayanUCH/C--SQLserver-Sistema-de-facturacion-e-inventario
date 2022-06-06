namespace CapaPresentacion.Modulos
{
    partial class frmInventario
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
            this.panel_inventario = new System.Windows.Forms.Panel();
            this.menuStripInventario = new System.Windows.Forms.MenuStrip();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioDelLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioDeLaBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_inventario
            // 
            this.panel_inventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_inventario.AutoSize = true;
            this.panel_inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(39)))));
            this.panel_inventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_inventario.ForeColor = System.Drawing.Color.Black;
            this.panel_inventario.Location = new System.Drawing.Point(0, 24);
            this.panel_inventario.Name = "panel_inventario";
            this.panel_inventario.Size = new System.Drawing.Size(934, 409);
            this.panel_inventario.TabIndex = 1;
            // 
            // menuStripInventario
            // 
            this.menuStripInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.menuStripInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStripInventario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStripInventario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem});
            this.menuStripInventario.Location = new System.Drawing.Point(0, 0);
            this.menuStripInventario.Name = "menuStripInventario";
            this.menuStripInventario.Size = new System.Drawing.Size(934, 24);
            this.menuStripInventario.TabIndex = 2;
            this.menuStripInventario.Text = "menuStrip1";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioDelLocalToolStripMenuItem,
            this.inventarioDeLaBodegaToolStripMenuItem});
            this.articulosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.articulosToolStripMenuItem.Text = "Inventario";
            // 
            // inventarioDelLocalToolStripMenuItem
            // 
            this.inventarioDelLocalToolStripMenuItem.Name = "inventarioDelLocalToolStripMenuItem";
            this.inventarioDelLocalToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.inventarioDelLocalToolStripMenuItem.Text = "Inventario del local";
            this.inventarioDelLocalToolStripMenuItem.Click += new System.EventHandler(this.inventarioDelLocalToolStripMenuItem_Click);
            // 
            // inventarioDeLaBodegaToolStripMenuItem
            // 
            this.inventarioDeLaBodegaToolStripMenuItem.Name = "inventarioDeLaBodegaToolStripMenuItem";
            this.inventarioDeLaBodegaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.inventarioDeLaBodegaToolStripMenuItem.Text = "Inventario de la bodega";
            this.inventarioDeLaBodegaToolStripMenuItem.Click += new System.EventHandler(this.inventarioDeLaBodegaToolStripMenuItem_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(115)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(934, 434);
            this.Controls.Add(this.menuStripInventario);
            this.Controls.Add(this.panel_inventario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventario";
            this.Text = "INVENTARIO";
            this.menuStripInventario.ResumeLayout(false);
            this.menuStripInventario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_inventario;
        private System.Windows.Forms.MenuStrip menuStripInventario;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioDelLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioDeLaBodegaToolStripMenuItem;
    }
}