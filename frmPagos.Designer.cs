namespace AdmSoft
{
    partial class frmPagos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblApartamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeudaTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoApagar = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkFacturasSinVencer = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkFacturasSinVencer);
            this.groupBox1.Controls.Add(this.lblApartamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtApto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblApartamento
            // 
            this.lblApartamento.AutoSize = true;
            this.lblApartamento.Location = new System.Drawing.Point(179, 22);
            this.lblApartamento.Name = "lblApartamento";
            this.lblApartamento.Size = new System.Drawing.Size(13, 13);
            this.lblApartamento.TabIndex = 2;
            this.lblApartamento.Text = "[]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // txtApto
            // 
            this.txtApto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApto.Location = new System.Drawing.Point(61, 22);
            this.txtApto.Name = "txtApto";
            this.txtApto.Size = new System.Drawing.Size(100, 20);
            this.txtApto.TabIndex = 1;
            this.txtApto.TextChanged += new System.EventHandler(this.txtApto_TextChanged);
            this.txtApto.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 287);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.Location = new System.Drawing.Point(3, 16);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(634, 268);
            this.dg.TabIndex = 1;
            this.dg.SelectionChanged += new System.EventHandler(this.dg_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Deuda total:";
            // 
            // txtDeudaTotal
            // 
            this.txtDeudaTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDeudaTotal.Location = new System.Drawing.Point(95, 397);
            this.txtDeudaTotal.Name = "txtDeudaTotal";
            this.txtDeudaTotal.Size = new System.Drawing.Size(100, 20);
            this.txtDeudaTotal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Monto a pagar:";
            // 
            // txtMontoApagar
            // 
            this.txtMontoApagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoApagar.Location = new System.Drawing.Point(95, 428);
            this.txtMontoApagar.Name = "txtMontoApagar";
            this.txtMontoApagar.Size = new System.Drawing.Size(100, 20);
            this.txtMontoApagar.TabIndex = 9;
            // 
            // btnProcesar
            // 
            this.btnProcesar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnProcesar.Location = new System.Drawing.Point(394, 420);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(99, 23);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Text = "Procesar Pago";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(499, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkFacturasSinVencer
            // 
            this.chkFacturasSinVencer.AutoSize = true;
            this.chkFacturasSinVencer.Location = new System.Drawing.Point(61, 48);
            this.chkFacturasSinVencer.Name = "chkFacturasSinVencer";
            this.chkFacturasSinVencer.Size = new System.Drawing.Size(102, 17);
            this.chkFacturasSinVencer.TabIndex = 3;
            this.chkFacturasSinVencer.Text = "Facturas futuras";
            this.chkFacturasSinVencer.UseVisualStyleBackColor = true;
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMontoApagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDeudaTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPagos";
            this.Text = "frmPagos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeudaTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoApagar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblApartamento;
        private System.Windows.Forms.CheckBox chkFacturasSinVencer;
    }
}