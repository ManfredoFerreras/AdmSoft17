namespace AdmSoft
{
    partial class CuadreCaja
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.bntNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFechaFind = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.tabCuadre = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtImporteDeposito = new System.Windows.Forms.TextBox();
            this.txtImporteGastos = new System.Windows.Forms.TextBox();
            this.txtImporteTransferencia = new System.Windows.Forms.TextBox();
            this.txtImporteTarjeta = new System.Windows.Forms.TextBox();
            this.txtImporteCheque = new System.Windows.Forms.TextBox();
            this.txtImporteEfectivo = new System.Windows.Forms.TextBox();
            this.txtImportePagos = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textCuadreId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabIngresos = new System.Windows.Forms.TabPage();
            this.splitIngresos = new System.Windows.Forms.SplitContainer();
            this.chkBorrar = new System.Windows.Forms.CheckBox();
            this.chkActulizarIngreso = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtReciboHasta = new System.Windows.Forms.TextBox();
            this.txtReciboDesde = new System.Windows.Forms.TextBox();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.lblFechaCuadre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgIngresos = new System.Windows.Forms.DataGridView();
            this.tabGastos = new System.Windows.Forms.TabPage();
            this.splitGastos = new System.Windows.Forms.SplitContainer();
            this.btnAgregarGasto = new System.Windows.Forms.Button();
            this.lblFechaCuadre2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgGastos = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.txtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.tabCuadre.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitIngresos)).BeginInit();
            this.splitIngresos.Panel1.SuspendLayout();
            this.splitIngresos.Panel2.SuspendLayout();
            this.splitIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngresos)).BeginInit();
            this.tabGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitGastos)).BeginInit();
            this.splitGastos.Panel1.SuspendLayout();
            this.splitGastos.Panel2.SuspendLayout();
            this.splitGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabCuadre);
            this.tabControl1.Controls.Add(this.tabIngresos);
            this.tabControl1.Controls.Add(this.tabGastos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 629);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(817, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cuadre";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtFechaHasta);
            this.splitContainer1.Panel1.Controls.Add(this.bntNuevo);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.txtFechaFind);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dg);
            this.splitContainer1.Size = new System.Drawing.Size(809, 592);
            this.splitContainer1.SplitterDistance = 98;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(87, 57);
            this.txtFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(265, 22);
            this.txtFechaHasta.TabIndex = 4;
            // 
            // bntNuevo
            // 
            this.bntNuevo.Location = new System.Drawing.Point(469, 26);
            this.bntNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntNuevo.Name = "bntNuevo";
            this.bntNuevo.Size = new System.Drawing.Size(100, 28);
            this.bntNuevo.TabIndex = 3;
            this.bntNuevo.Text = "Nuevo";
            this.bntNuevo.UseVisualStyleBackColor = true;
            this.bntNuevo.Click += new System.EventHandler(this.bntNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(361, 25);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFechaFind
            // 
            this.txtFechaFind.Location = new System.Drawing.Point(87, 25);
            this.txtFechaFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaFind.Name = "txtFechaFind";
            this.txtFechaFind.Size = new System.Drawing.Size(265, 22);
            this.txtFechaFind.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg.Location = new System.Drawing.Point(0, 0);
            this.dg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersWidth = 51;
            this.dg.Size = new System.Drawing.Size(809, 489);
            this.dg.TabIndex = 0;
            this.dg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellDoubleClick);
            this.dg.DoubleClick += new System.EventHandler(this.dg_DoubleClick);
            // 
            // tabCuadre
            // 
            this.tabCuadre.Controls.Add(this.groupBox1);
            this.tabCuadre.Location = new System.Drawing.Point(4, 25);
            this.tabCuadre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCuadre.Name = "tabCuadre";
            this.tabCuadre.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCuadre.Size = new System.Drawing.Size(817, 600);
            this.tabCuadre.TabIndex = 3;
            this.tabCuadre.Text = "Registro de cuadre";
            this.tabCuadre.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFechaFin);
            this.groupBox1.Controls.Add(this.txtFechaIni);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtComentario);
            this.groupBox1.Controls.Add(this.txtImporteDeposito);
            this.groupBox1.Controls.Add(this.txtImporteGastos);
            this.groupBox1.Controls.Add(this.txtImporteTransferencia);
            this.groupBox1.Controls.Add(this.txtImporteTarjeta);
            this.groupBox1.Controls.Add(this.txtImporteCheque);
            this.groupBox1.Controls.Add(this.txtImporteEfectivo);
            this.groupBox1.Controls.Add(this.txtImportePagos);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textCuadreId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(744, 518);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(613, 23);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 28);
            this.btnImprimir.TabIndex = 22;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(505, 452);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Guardar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(356, 262);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Comentario:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(356, 210);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Deposito:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 165);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Gastos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 372);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Transferencia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 325);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tarjeta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cheque:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Efectivo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pagos:";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(449, 257);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(263, 138);
            this.txtComentario.TabIndex = 11;
            // 
            // txtImporteDeposito
            // 
            this.txtImporteDeposito.Location = new System.Drawing.Point(449, 207);
            this.txtImporteDeposito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImporteDeposito.Name = "txtImporteDeposito";
            this.txtImporteDeposito.Size = new System.Drawing.Size(132, 22);
            this.txtImporteDeposito.TabIndex = 10;
            // 
            // txtImporteGastos
            // 
            this.txtImporteGastos.Location = new System.Drawing.Point(449, 161);
            this.txtImporteGastos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImporteGastos.Name = "txtImporteGastos";
            this.txtImporteGastos.Size = new System.Drawing.Size(132, 22);
            this.txtImporteGastos.TabIndex = 9;
            // 
            // txtImporteTransferencia
            // 
            this.txtImporteTransferencia.Location = new System.Drawing.Point(141, 372);
            this.txtImporteTransferencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImporteTransferencia.Name = "txtImporteTransferencia";
            this.txtImporteTransferencia.Size = new System.Drawing.Size(132, 22);
            this.txtImporteTransferencia.TabIndex = 8;
            // 
            // txtImporteTarjeta
            // 
            this.txtImporteTarjeta.Location = new System.Drawing.Point(141, 321);
            this.txtImporteTarjeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImporteTarjeta.Name = "txtImporteTarjeta";
            this.txtImporteTarjeta.Size = new System.Drawing.Size(132, 22);
            this.txtImporteTarjeta.TabIndex = 7;
            // 
            // txtImporteCheque
            // 
            this.txtImporteCheque.Location = new System.Drawing.Point(141, 266);
            this.txtImporteCheque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImporteCheque.Name = "txtImporteCheque";
            this.txtImporteCheque.Size = new System.Drawing.Size(132, 22);
            this.txtImporteCheque.TabIndex = 6;
            // 
            // txtImporteEfectivo
            // 
            this.txtImporteEfectivo.Location = new System.Drawing.Point(141, 210);
            this.txtImporteEfectivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImporteEfectivo.Name = "txtImporteEfectivo";
            this.txtImporteEfectivo.Size = new System.Drawing.Size(132, 22);
            this.txtImporteEfectivo.TabIndex = 5;
            // 
            // txtImportePagos
            // 
            this.txtImportePagos.Location = new System.Drawing.Point(141, 161);
            this.txtImportePagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImportePagos.Name = "txtImportePagos";
            this.txtImportePagos.Size = new System.Drawing.Size(132, 22);
            this.txtImportePagos.TabIndex = 4;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(141, 81);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(189, 22);
            this.txtFecha.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha:";
            // 
            // textCuadreId
            // 
            this.textCuadreId.Location = new System.Drawing.Point(141, 54);
            this.textCuadreId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCuadreId.Name = "textCuadreId";
            this.textCuadreId.Size = new System.Drawing.Size(132, 22);
            this.textCuadreId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cuadre Id:";
            // 
            // tabIngresos
            // 
            this.tabIngresos.Controls.Add(this.splitIngresos);
            this.tabIngresos.Location = new System.Drawing.Point(4, 25);
            this.tabIngresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabIngresos.Name = "tabIngresos";
            this.tabIngresos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabIngresos.Size = new System.Drawing.Size(817, 600);
            this.tabIngresos.TabIndex = 1;
            this.tabIngresos.Text = "Ingresos";
            this.tabIngresos.UseVisualStyleBackColor = true;
            // 
            // splitIngresos
            // 
            this.splitIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitIngresos.Location = new System.Drawing.Point(4, 4);
            this.splitIngresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitIngresos.Name = "splitIngresos";
            this.splitIngresos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitIngresos.Panel1
            // 
            this.splitIngresos.Panel1.Controls.Add(this.chkBorrar);
            this.splitIngresos.Panel1.Controls.Add(this.chkActulizarIngreso);
            this.splitIngresos.Panel1.Controls.Add(this.label14);
            this.splitIngresos.Panel1.Controls.Add(this.txtReciboHasta);
            this.splitIngresos.Panel1.Controls.Add(this.txtReciboDesde);
            this.splitIngresos.Panel1.Controls.Add(this.bntBuscar);
            this.splitIngresos.Panel1.Controls.Add(this.lblFechaCuadre);
            this.splitIngresos.Panel1.Controls.Add(this.label2);
            // 
            // splitIngresos.Panel2
            // 
            this.splitIngresos.Panel2.Controls.Add(this.dgIngresos);
            this.splitIngresos.Size = new System.Drawing.Size(809, 592);
            this.splitIngresos.SplitterDistance = 64;
            this.splitIngresos.SplitterWidth = 5;
            this.splitIngresos.TabIndex = 0;
            // 
            // chkBorrar
            // 
            this.chkBorrar.AutoSize = true;
            this.chkBorrar.Location = new System.Drawing.Point(708, 31);
            this.chkBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBorrar.Name = "chkBorrar";
            this.chkBorrar.Size = new System.Drawing.Size(66, 20);
            this.chkBorrar.TabIndex = 7;
            this.chkBorrar.Text = "Borrar";
            this.chkBorrar.UseVisualStyleBackColor = true;
            // 
            // chkActulizarIngreso
            // 
            this.chkActulizarIngreso.AutoSize = true;
            this.chkActulizarIngreso.Location = new System.Drawing.Point(708, 9);
            this.chkActulizarIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkActulizarIngreso.Name = "chkActulizarIngreso";
            this.chkActulizarIngreso.Size = new System.Drawing.Size(73, 20);
            this.chkActulizarIngreso.TabIndex = 6;
            this.chkActulizarIngreso.Text = "Insertar";
            this.chkActulizarIngreso.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(211, 22);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Buscar Recibos:";
            // 
            // txtReciboHasta
            // 
            this.txtReciboHasta.Location = new System.Drawing.Point(509, 18);
            this.txtReciboHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReciboHasta.Name = "txtReciboHasta";
            this.txtReciboHasta.Size = new System.Drawing.Size(132, 22);
            this.txtReciboHasta.TabIndex = 4;
            // 
            // txtReciboDesde
            // 
            this.txtReciboDesde.Location = new System.Drawing.Point(353, 18);
            this.txtReciboDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReciboDesde.Name = "txtReciboDesde";
            this.txtReciboDesde.Size = new System.Drawing.Size(132, 22);
            this.txtReciboDesde.TabIndex = 3;
            // 
            // bntBuscar
            // 
            this.bntBuscar.Location = new System.Drawing.Point(651, 18);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(32, 28);
            this.bntBuscar.TabIndex = 2;
            this.bntBuscar.Text = "...";
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // lblFechaCuadre
            // 
            this.lblFechaCuadre.AutoSize = true;
            this.lblFechaCuadre.Location = new System.Drawing.Point(149, 18);
            this.lblFechaCuadre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaCuadre.Name = "lblFechaCuadre";
            this.lblFechaCuadre.Size = new System.Drawing.Size(15, 16);
            this.lblFechaCuadre.TabIndex = 1;
            this.lblFechaCuadre.Text = "[]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de cuadre:";
            // 
            // dgIngresos
            // 
            this.dgIngresos.AllowUserToAddRows = false;
            this.dgIngresos.AllowUserToDeleteRows = false;
            this.dgIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgIngresos.Location = new System.Drawing.Point(0, 0);
            this.dgIngresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgIngresos.Name = "dgIngresos";
            this.dgIngresos.ReadOnly = true;
            this.dgIngresos.RowHeadersWidth = 51;
            this.dgIngresos.Size = new System.Drawing.Size(809, 523);
            this.dgIngresos.TabIndex = 1;
            // 
            // tabGastos
            // 
            this.tabGastos.Controls.Add(this.splitGastos);
            this.tabGastos.Location = new System.Drawing.Point(4, 25);
            this.tabGastos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGastos.Name = "tabGastos";
            this.tabGastos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGastos.Size = new System.Drawing.Size(817, 600);
            this.tabGastos.TabIndex = 2;
            this.tabGastos.Text = "Gastos";
            this.tabGastos.UseVisualStyleBackColor = true;
            // 
            // splitGastos
            // 
            this.splitGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitGastos.Location = new System.Drawing.Point(4, 4);
            this.splitGastos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitGastos.Name = "splitGastos";
            this.splitGastos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitGastos.Panel1
            // 
            this.splitGastos.Panel1.Controls.Add(this.btnAgregarGasto);
            this.splitGastos.Panel1.Controls.Add(this.lblFechaCuadre2);
            this.splitGastos.Panel1.Controls.Add(this.label4);
            // 
            // splitGastos.Panel2
            // 
            this.splitGastos.Panel2.Controls.Add(this.dgGastos);
            this.splitGastos.Size = new System.Drawing.Size(809, 592);
            this.splitGastos.SplitterDistance = 64;
            this.splitGastos.SplitterWidth = 5;
            this.splitGastos.TabIndex = 1;
            // 
            // btnAgregarGasto
            // 
            this.btnAgregarGasto.Location = new System.Drawing.Point(693, 17);
            this.btnAgregarGasto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarGasto.Name = "btnAgregarGasto";
            this.btnAgregarGasto.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarGasto.TabIndex = 4;
            this.btnAgregarGasto.Text = "Agregar";
            this.btnAgregarGasto.UseVisualStyleBackColor = true;
            this.btnAgregarGasto.Click += new System.EventHandler(this.btnAgregarGasto_Click);
            // 
            // lblFechaCuadre2
            // 
            this.lblFechaCuadre2.AutoSize = true;
            this.lblFechaCuadre2.Location = new System.Drawing.Point(153, 17);
            this.lblFechaCuadre2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaCuadre2.Name = "lblFechaCuadre2";
            this.lblFechaCuadre2.Size = new System.Drawing.Size(15, 16);
            this.lblFechaCuadre2.TabIndex = 3;
            this.lblFechaCuadre2.Text = "[]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha de cuadre:";
            // 
            // dgGastos
            // 
            this.dgGastos.AllowUserToAddRows = false;
            this.dgGastos.AllowUserToDeleteRows = false;
            this.dgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgGastos.Location = new System.Drawing.Point(0, 0);
            this.dgGastos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgGastos.Name = "dgGastos";
            this.dgGastos.ReadOnly = true;
            this.dgGastos.RowHeadersWidth = 51;
            this.dgGastos.Size = new System.Drawing.Size(809, 523);
            this.dgGastos.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 111);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "Fechas Reg:";
            // 
            // txtFechaIni
            // 
            this.txtFechaIni.Location = new System.Drawing.Point(140, 106);
            this.txtFechaIni.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaIni.Name = "txtFechaIni";
            this.txtFechaIni.Size = new System.Drawing.Size(190, 22);
            this.txtFechaIni.TabIndex = 26;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Enabled = false;
            this.txtFechaFin.Location = new System.Drawing.Point(141, 131);
            this.txtFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(189, 22);
            this.txtFechaFin.TabIndex = 27;
            // 
            // CuadreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 629);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CuadreCaja";
            this.Text = "CuadreCaja";
            this.Load += new System.EventHandler(this.CuadreCaja_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.tabCuadre.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabIngresos.ResumeLayout(false);
            this.splitIngresos.Panel1.ResumeLayout(false);
            this.splitIngresos.Panel1.PerformLayout();
            this.splitIngresos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitIngresos)).EndInit();
            this.splitIngresos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgIngresos)).EndInit();
            this.tabGastos.ResumeLayout(false);
            this.splitGastos.Panel1.ResumeLayout(false);
            this.splitGastos.Panel1.PerformLayout();
            this.splitGastos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGastos)).EndInit();
            this.splitGastos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabIngresos;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker txtFechaFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.TabPage tabGastos;
        private System.Windows.Forms.SplitContainer splitIngresos;
        private System.Windows.Forms.DataGridView dgIngresos;
        private System.Windows.Forms.SplitContainer splitGastos;
        private System.Windows.Forms.DataGridView dgGastos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaCuadre;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.Label lblFechaCuadre2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarGasto;
        private System.Windows.Forms.TabPage tabCuadre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCuadreId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtImporteDeposito;
        private System.Windows.Forms.TextBox txtImporteGastos;
        private System.Windows.Forms.TextBox txtImporteTransferencia;
        private System.Windows.Forms.TextBox txtImporteTarjeta;
        private System.Windows.Forms.TextBox txtImporteCheque;
        private System.Windows.Forms.TextBox txtImporteEfectivo;
        private System.Windows.Forms.TextBox txtImportePagos;
        private System.Windows.Forms.Button bntNuevo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtReciboHasta;
        private System.Windows.Forms.TextBox txtReciboDesde;
        private System.Windows.Forms.CheckBox chkActulizarIngreso;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DateTimePicker txtFechaHasta;
        private System.Windows.Forms.CheckBox chkBorrar;
        private System.Windows.Forms.DateTimePicker txtFechaFin;
        private System.Windows.Forms.DateTimePicker txtFechaIni;
        private System.Windows.Forms.Label label15;
    }
}