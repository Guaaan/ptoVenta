
namespace ptoVenta
{
    partial class sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sistema));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpReportes = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlChico = new System.Windows.Forms.TabControl();
            this.tpReimprimirFactura = new System.Windows.Forms.TabPage();
            this.cmbAsignar = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpReporteConsumo = new System.Windows.Forms.TabPage();
            this.tpCierreCaja = new System.Windows.Forms.TabPage();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.tpConsolaFiscal = new System.Windows.Forms.TabPage();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.ReporteVentas = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbConsolaFiscal = new System.Windows.Forms.RadioButton();
            this.rbReporteVentas = new System.Windows.Forms.RadioButton();
            this.rbCierreCaja = new System.Windows.Forms.RadioButton();
            this.rbReporteConsumo = new System.Windows.Forms.RadioButton();
            this.rbImprimirFactura = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAceptarIngreso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbConfiguracion = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvConfiguración = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpReportes.SuspendLayout();
            this.tabControlChico.SuspendLayout();
            this.tpReimprimirFactura.SuspendLayout();
            this.tpCierreCaja.SuspendLayout();
            this.tpConsolaFiscal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbConfiguracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfiguración)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpReportes);
            this.tabControl1.Controls.Add(this.tbConfiguracion);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1209, 815);
            this.tabControl1.TabIndex = 0;
            // 
            // tpReportes
            // 
            this.tpReportes.AccessibleName = "Reportes";
            this.tpReportes.Controls.Add(this.panel1);
            this.tpReportes.Controls.Add(this.tabControlChico);
            this.tpReportes.Controls.Add(this.groupBox2);
            this.tpReportes.Controls.Add(this.groupBox1);
            this.tpReportes.Location = new System.Drawing.Point(4, 25);
            this.tpReportes.Name = "tpReportes";
            this.tpReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tpReportes.Size = new System.Drawing.Size(1201, 786);
            this.tpReportes.TabIndex = 0;
            this.tpReportes.Text = " Reportes";
            this.tpReportes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(32, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 39);
            this.panel1.TabIndex = 49;
            // 
            // tabControlChico
            // 
            this.tabControlChico.CausesValidation = false;
            this.tabControlChico.Controls.Add(this.tpReimprimirFactura);
            this.tabControlChico.Controls.Add(this.tpReporteConsumo);
            this.tabControlChico.Controls.Add(this.tpCierreCaja);
            this.tabControlChico.Controls.Add(this.tpConsolaFiscal);
            this.tabControlChico.Controls.Add(this.ReporteVentas);
            this.tabControlChico.Location = new System.Drawing.Point(32, 334);
            this.tabControlChico.Name = "tabControlChico";
            this.tabControlChico.SelectedIndex = 0;
            this.tabControlChico.Size = new System.Drawing.Size(898, 420);
            this.tabControlChico.TabIndex = 48;
            // 
            // tpReimprimirFactura
            // 
            this.tpReimprimirFactura.Controls.Add(this.cmbAsignar);
            this.tpReimprimirFactura.Controls.Add(this.checkBox1);
            this.tpReimprimirFactura.Controls.Add(this.button4);
            this.tpReimprimirFactura.Controls.Add(this.txtPrecio);
            this.tpReimprimirFactura.Controls.Add(this.label2);
            this.tpReimprimirFactura.Location = new System.Drawing.Point(4, 25);
            this.tpReimprimirFactura.Name = "tpReimprimirFactura";
            this.tpReimprimirFactura.Padding = new System.Windows.Forms.Padding(3);
            this.tpReimprimirFactura.Size = new System.Drawing.Size(890, 391);
            this.tpReimprimirFactura.TabIndex = 0;
            this.tpReimprimirFactura.Text = "Reimprimir";
            this.tpReimprimirFactura.UseVisualStyleBackColor = true;
            // 
            // cmbAsignar
            // 
            this.cmbAsignar.AllowDrop = true;
            this.cmbAsignar.FormattingEnabled = true;
            this.cmbAsignar.Location = new System.Drawing.Point(363, 240);
            this.cmbAsignar.Name = "cmbAsignar";
            this.cmbAsignar.Size = new System.Drawing.Size(163, 24);
            this.cmbAsignar.TabIndex = 49;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(380, 210);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 24);
            this.checkBox1.TabIndex = 48;
            this.checkBox1.Text = "Copia Fiscal";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(587, 129);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 36);
            this.button4.TabIndex = 47;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(380, 129);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(200, 36);
            this.txtPrecio.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 39);
            this.label2.TabIndex = 34;
            this.label2.Text = "Transacción N°:";
            // 
            // tpReporteConsumo
            // 
            this.tpReporteConsumo.Location = new System.Drawing.Point(4, 25);
            this.tpReporteConsumo.Name = "tpReporteConsumo";
            this.tpReporteConsumo.Padding = new System.Windows.Forms.Padding(3);
            this.tpReporteConsumo.Size = new System.Drawing.Size(890, 391);
            this.tpReporteConsumo.TabIndex = 1;
            this.tpReporteConsumo.Text = "Reporte";
            this.tpReporteConsumo.UseVisualStyleBackColor = true;
            // 
            // tpCierreCaja
            // 
            this.tpCierreCaja.Controls.Add(this.button21);
            this.tpCierreCaja.Controls.Add(this.button22);
            this.tpCierreCaja.Controls.Add(this.button23);
            this.tpCierreCaja.Controls.Add(this.button24);
            this.tpCierreCaja.Location = new System.Drawing.Point(4, 25);
            this.tpCierreCaja.Name = "tpCierreCaja";
            this.tpCierreCaja.Padding = new System.Windows.Forms.Padding(3);
            this.tpCierreCaja.Size = new System.Drawing.Size(890, 391);
            this.tpCierreCaja.TabIndex = 2;
            this.tpCierreCaja.Text = "cierre";
            this.tpCierreCaja.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Gray;
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(715, 210);
            this.button21.Margin = new System.Windows.Forms.Padding(4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(142, 57);
            this.button21.TabIndex = 53;
            this.button21.Text = "Grabar Archivo";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Gray;
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(715, 52);
            this.button22.Margin = new System.Windows.Forms.Padding(4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(142, 57);
            this.button22.TabIndex = 54;
            this.button22.Text = "Salir";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Gray;
            this.button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(715, 291);
            this.button23.Margin = new System.Windows.Forms.Padding(4);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(142, 57);
            this.button23.TabIndex = 51;
            this.button23.Text = "Generar en Pantalla";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Gray;
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.Color.White;
            this.button24.Location = new System.Drawing.Point(715, 131);
            this.button24.Margin = new System.Windows.Forms.Padding(4);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(142, 57);
            this.button24.TabIndex = 52;
            this.button24.Text = "Imprimir Reporte";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // tpConsolaFiscal
            // 
            this.tpConsolaFiscal.Controls.Add(this.button25);
            this.tpConsolaFiscal.Controls.Add(this.button26);
            this.tpConsolaFiscal.Controls.Add(this.button27);
            this.tpConsolaFiscal.Controls.Add(this.button28);
            this.tpConsolaFiscal.Location = new System.Drawing.Point(4, 25);
            this.tpConsolaFiscal.Name = "tpConsolaFiscal";
            this.tpConsolaFiscal.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsolaFiscal.Size = new System.Drawing.Size(890, 391);
            this.tpConsolaFiscal.TabIndex = 3;
            this.tpConsolaFiscal.Text = "consola";
            this.tpConsolaFiscal.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Gray;
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button25.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.Color.White;
            this.button25.Location = new System.Drawing.Point(600, 215);
            this.button25.Margin = new System.Windows.Forms.Padding(4);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(142, 57);
            this.button25.TabIndex = 53;
            this.button25.Text = "Grabar Archivo";
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Gray;
            this.button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.ForeColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(600, 57);
            this.button26.Margin = new System.Windows.Forms.Padding(4);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(142, 57);
            this.button26.TabIndex = 54;
            this.button26.Text = "Salir";
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Gray;
            this.button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button27.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.ForeColor = System.Drawing.Color.White;
            this.button27.Location = new System.Drawing.Point(600, 296);
            this.button27.Margin = new System.Windows.Forms.Padding(4);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(142, 57);
            this.button27.TabIndex = 51;
            this.button27.Text = "Generar en Pantalla";
            this.button27.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Gray;
            this.button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button28.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.ForeColor = System.Drawing.Color.White;
            this.button28.Location = new System.Drawing.Point(600, 136);
            this.button28.Margin = new System.Windows.Forms.Padding(4);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(142, 57);
            this.button28.TabIndex = 52;
            this.button28.Text = "Imprimir Reporte";
            this.button28.UseVisualStyleBackColor = false;
            // 
            // ReporteVentas
            // 
            this.ReporteVentas.Location = new System.Drawing.Point(4, 25);
            this.ReporteVentas.Name = "ReporteVentas";
            this.ReporteVentas.Padding = new System.Windows.Forms.Padding(3);
            this.ReporteVentas.Size = new System.Drawing.Size(890, 391);
            this.ReporteVentas.TabIndex = 4;
            this.ReporteVentas.Text = "ventas";
            this.ReporteVentas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbConsolaFiscal);
            this.groupBox2.Controls.Add(this.rbReporteVentas);
            this.groupBox2.Controls.Add(this.rbCierreCaja);
            this.groupBox2.Controls.Add(this.rbReporteConsumo);
            this.groupBox2.Controls.Add(this.rbImprimirFactura);
            this.groupBox2.Location = new System.Drawing.Point(32, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 309);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dispositivo";
            // 
            // rbConsolaFiscal
            // 
            this.rbConsolaFiscal.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbConsolaFiscal.BackColor = System.Drawing.Color.Gray;
            this.rbConsolaFiscal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbConsolaFiscal.FlatAppearance.BorderSize = 3;
            this.rbConsolaFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbConsolaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbConsolaFiscal.ForeColor = System.Drawing.Color.White;
            this.rbConsolaFiscal.Location = new System.Drawing.Point(30, 191);
            this.rbConsolaFiscal.Name = "rbConsolaFiscal";
            this.rbConsolaFiscal.Size = new System.Drawing.Size(365, 43);
            this.rbConsolaFiscal.TabIndex = 4;
            this.rbConsolaFiscal.Text = "Consola Fiscal";
            this.rbConsolaFiscal.UseVisualStyleBackColor = false;
            this.rbConsolaFiscal.CheckedChanged += new System.EventHandler(this.rbConsolaFiscal_CheckedChanged);
            // 
            // rbReporteVentas
            // 
            this.rbReporteVentas.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbReporteVentas.BackColor = System.Drawing.Color.Gray;
            this.rbReporteVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbReporteVentas.FlatAppearance.BorderSize = 3;
            this.rbReporteVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReporteVentas.ForeColor = System.Drawing.Color.White;
            this.rbReporteVentas.Location = new System.Drawing.Point(30, 242);
            this.rbReporteVentas.Name = "rbReporteVentas";
            this.rbReporteVentas.Size = new System.Drawing.Size(365, 43);
            this.rbReporteVentas.TabIndex = 5;
            this.rbReporteVentas.Text = "Reporte de Ventas";
            this.rbReporteVentas.UseVisualStyleBackColor = false;
            this.rbReporteVentas.CheckedChanged += new System.EventHandler(this.rbReporteVentas_CheckedChanged);
            // 
            // rbCierreCaja
            // 
            this.rbCierreCaja.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCierreCaja.BackColor = System.Drawing.Color.Gray;
            this.rbCierreCaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbCierreCaja.FlatAppearance.BorderSize = 3;
            this.rbCierreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbCierreCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCierreCaja.ForeColor = System.Drawing.Color.White;
            this.rbCierreCaja.Location = new System.Drawing.Point(30, 140);
            this.rbCierreCaja.Name = "rbCierreCaja";
            this.rbCierreCaja.Size = new System.Drawing.Size(365, 43);
            this.rbCierreCaja.TabIndex = 3;
            this.rbCierreCaja.Text = "Cierre Caja";
            this.rbCierreCaja.UseVisualStyleBackColor = false;
            this.rbCierreCaja.CheckedChanged += new System.EventHandler(this.rbCierreCaja_CheckedChanged);
            // 
            // rbReporteConsumo
            // 
            this.rbReporteConsumo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbReporteConsumo.BackColor = System.Drawing.Color.Gray;
            this.rbReporteConsumo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbReporteConsumo.FlatAppearance.BorderSize = 3;
            this.rbReporteConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbReporteConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReporteConsumo.ForeColor = System.Drawing.Color.White;
            this.rbReporteConsumo.Location = new System.Drawing.Point(30, 89);
            this.rbReporteConsumo.Name = "rbReporteConsumo";
            this.rbReporteConsumo.Size = new System.Drawing.Size(365, 43);
            this.rbReporteConsumo.TabIndex = 2;
            this.rbReporteConsumo.Text = "Reporte de Consumo";
            this.rbReporteConsumo.UseVisualStyleBackColor = false;
            this.rbReporteConsumo.CheckedChanged += new System.EventHandler(this.rbReporteConsumo_CheckedChanged);
            // 
            // rbImprimirFactura
            // 
            this.rbImprimirFactura.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbImprimirFactura.BackColor = System.Drawing.Color.Gray;
            this.rbImprimirFactura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbImprimirFactura.FlatAppearance.BorderSize = 3;
            this.rbImprimirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbImprimirFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbImprimirFactura.ForeColor = System.Drawing.Color.White;
            this.rbImprimirFactura.Location = new System.Drawing.Point(30, 37);
            this.rbImprimirFactura.Name = "rbImprimirFactura";
            this.rbImprimirFactura.Size = new System.Drawing.Size(365, 43);
            this.rbImprimirFactura.TabIndex = 1;
            this.rbImprimirFactura.Text = "Reimprimir Factura";
            this.rbImprimirFactura.UseVisualStyleBackColor = false;
            this.rbImprimirFactura.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnAceptarIngreso);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(979, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 443);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dispositivo";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(28, 167);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 57);
            this.button2.TabIndex = 45;
            this.button2.Text = "Grabar Archivo";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(28, 370);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 57);
            this.button3.TabIndex = 46;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAceptarIngreso
            // 
            this.btnAceptarIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnAceptarIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptarIngreso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.btnAceptarIngreso.FlatAppearance.BorderSize = 3;
            this.btnAceptarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarIngreso.ForeColor = System.Drawing.Color.White;
            this.btnAceptarIngreso.Location = new System.Drawing.Point(28, 37);
            this.btnAceptarIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarIngreso.Name = "btnAceptarIngreso";
            this.btnAceptarIngreso.Size = new System.Drawing.Size(142, 57);
            this.btnAceptarIngreso.TabIndex = 43;
            this.btnAceptarIngreso.Text = "Generar en Pantalla";
            this.btnAceptarIngreso.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(28, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 57);
            this.button1.TabIndex = 44;
            this.button1.Text = "Imprimir Reporte";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbConfiguracion
            // 
            this.tbConfiguracion.AccessibleName = "Configuración";
            this.tbConfiguracion.Controls.Add(this.textBox2);
            this.tbConfiguracion.Controls.Add(this.textBox1);
            this.tbConfiguracion.Controls.Add(this.dgvConfiguración);
            this.tbConfiguracion.Location = new System.Drawing.Point(4, 25);
            this.tbConfiguracion.Name = "tbConfiguracion";
            this.tbConfiguracion.Padding = new System.Windows.Forms.Padding(3);
            this.tbConfiguracion.Size = new System.Drawing.Size(1201, 786);
            this.tbConfiguracion.TabIndex = 1;
            this.tbConfiguracion.Text = "Configuración";
            this.tbConfiguracion.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(198, 706);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(492, 36);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Hora de Envíos de Informes (Hora Militar)";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(690, 706);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 36);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "10:30";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvConfiguración
            // 
            this.dgvConfiguración.BackgroundColor = System.Drawing.Color.White;
            this.dgvConfiguración.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfiguración.Location = new System.Drawing.Point(6, 6);
            this.dgvConfiguración.Name = "dgvConfiguración";
            this.dgvConfiguración.RowHeadersWidth = 51;
            this.dgvConfiguración.RowTemplate.Height = 24;
            this.dgvConfiguración.Size = new System.Drawing.Size(1189, 674);
            this.dgvConfiguración.TabIndex = 19;
            // 
            // sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 847);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sistema";
            this.Text = "sistema";
            this.tabControl1.ResumeLayout(false);
            this.tpReportes.ResumeLayout(false);
            this.tabControlChico.ResumeLayout(false);
            this.tpReimprimirFactura.ResumeLayout(false);
            this.tpReimprimirFactura.PerformLayout();
            this.tpCierreCaja.ResumeLayout(false);
            this.tpConsolaFiscal.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tbConfiguracion.ResumeLayout(false);
            this.tbConfiguracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfiguración)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbConfiguracion;
        private System.Windows.Forms.TabPage tpReportes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAceptarIngreso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlChico;
        private System.Windows.Forms.TabPage tpReimprimirFactura;
        private System.Windows.Forms.TabPage tpReporteConsumo;
        private System.Windows.Forms.TabPage tpCierreCaja;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TabPage tpConsolaFiscal;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.RadioButton rbReporteVentas;
        private System.Windows.Forms.RadioButton rbConsolaFiscal;
        private System.Windows.Forms.RadioButton rbCierreCaja;
        private System.Windows.Forms.RadioButton rbReporteConsumo;
        private System.Windows.Forms.RadioButton rbImprimirFactura;
        private System.Windows.Forms.TabPage ReporteVentas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmbAsignar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvConfiguración;
    }
}