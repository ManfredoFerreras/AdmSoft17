namespace AdmSoft
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminitraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generaciónDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generaciónIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cobrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.cuadreDeOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminitraciónToolStripMenuItem,
            this.operaciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminitraciónToolStripMenuItem
            // 
            this.adminitraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartamentosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.adminitraciónToolStripMenuItem.Name = "adminitraciónToolStripMenuItem";
            this.adminitraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.adminitraciónToolStripMenuItem.Text = "Administración";
            this.adminitraciónToolStripMenuItem.Click += new System.EventHandler(this.adminitraciónToolStripMenuItem_Click);
            // 
            // apartamentosToolStripMenuItem
            // 
            this.apartamentosToolStripMenuItem.Name = "apartamentosToolStripMenuItem";
            this.apartamentosToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.apartamentosToolStripMenuItem.Text = "Apartamentos";
            this.apartamentosToolStripMenuItem.Click += new System.EventHandler(this.apartamentosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // operaciónToolStripMenuItem
            // 
            this.operaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generaciónDeFacturasToolStripMenuItem,
            this.generaciónIndividualToolStripMenuItem,
            this.toolStripMenuItem3,
            this.cobrosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.reportesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.cuadreDeOperacionesToolStripMenuItem});
            this.operaciónToolStripMenuItem.Name = "operaciónToolStripMenuItem";
            this.operaciónToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.operaciónToolStripMenuItem.Text = "Operación";
            // 
            // generaciónDeFacturasToolStripMenuItem
            // 
            this.generaciónDeFacturasToolStripMenuItem.Name = "generaciónDeFacturasToolStripMenuItem";
            this.generaciónDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.generaciónDeFacturasToolStripMenuItem.Text = "Generación de Facturas";
            this.generaciónDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.generaciónDeFacturasToolStripMenuItem_Click);
            // 
            // generaciónIndividualToolStripMenuItem
            // 
            this.generaciónIndividualToolStripMenuItem.Name = "generaciónIndividualToolStripMenuItem";
            this.generaciónIndividualToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.generaciónIndividualToolStripMenuItem.Text = "Generación individual";
            this.generaciónIndividualToolStripMenuItem.Click += new System.EventHandler(this.generaciónIndividualToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(194, 6);
            // 
            // cobrosToolStripMenuItem
            // 
            this.cobrosToolStripMenuItem.Name = "cobrosToolStripMenuItem";
            this.cobrosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cobrosToolStripMenuItem.Text = "Cobros";
            this.cobrosToolStripMenuItem.Click += new System.EventHandler(this.cobrosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(194, 6);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recibosToolStripMenuItem,
            this.deudaToolStripMenuItem,
            this.pagosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.reportesToolStripMenuItem.Text = "Consultas";
            // 
            // recibosToolStripMenuItem
            // 
            this.recibosToolStripMenuItem.Name = "recibosToolStripMenuItem";
            this.recibosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recibosToolStripMenuItem.Text = "Recibos";
            this.recibosToolStripMenuItem.Click += new System.EventHandler(this.recibosToolStripMenuItem_Click);
            // 
            // deudaToolStripMenuItem
            // 
            this.deudaToolStripMenuItem.Name = "deudaToolStripMenuItem";
            this.deudaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deudaToolStripMenuItem.Text = "Deuda";
            this.deudaToolStripMenuItem.Click += new System.EventHandler(this.deudaToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pagosToolStripMenuItem.Text = "Pagos";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(194, 6);
            // 
            // cuadreDeOperacionesToolStripMenuItem
            // 
            this.cuadreDeOperacionesToolStripMenuItem.Name = "cuadreDeOperacionesToolStripMenuItem";
            this.cuadreDeOperacionesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cuadreDeOperacionesToolStripMenuItem.Text = "Cuadre de Operaciones";
            this.cuadreDeOperacionesToolStripMenuItem.Click += new System.EventHandler(this.cuadreDeOperacionesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 563);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Adminitracion de pagos de condominios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminitraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generaciónDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generaciónIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem recibosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cuadreDeOperacionesToolStripMenuItem;
    }
}

