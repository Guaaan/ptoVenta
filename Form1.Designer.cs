
namespace ptoVenta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.updownPrecio = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlmacen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrincipioActivo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.drdVendedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSistema = new FontAwesome.Sharp.IconButton();
            this.btnReciboIngreso = new FontAwesome.Sharp.IconButton();
            this.btnCargarDocumento = new FontAwesome.Sharp.IconButton();
            this.btnGuardarDocumento = new FontAwesome.Sharp.IconButton();
            this.btnCargarPrecio = new FontAwesome.Sharp.IconButton();
            this.btnDevoluciones = new FontAwesome.Sharp.IconButton();
            this.btnEgresoCaja = new FontAwesome.Sharp.IconButton();
            this.btnTicketsEmitidos = new FontAwesome.Sharp.IconButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnDelivery = new FontAwesome.Sharp.IconButton();
            this.btnProductoFaltante = new FontAwesome.Sharp.IconButton();
            this.btnProductosNoVendidos = new FontAwesome.Sharp.IconButton();
            this.btnAperturaCaja = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnAbrirCajon = new FontAwesome.Sharp.IconButton();
            this.btnCotizacion = new FontAwesome.Sharp.IconButton();
            this.btnDescripciónFarmacologica = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelBuscarPersona = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDesplegarBuscar = new FontAwesome.Sharp.IconButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel18.SuspendLayout();
            this.panelBuscarPersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLista.BackgroundColor = System.Drawing.Color.White;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(19, 355);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(1488, 217);
            this.dgvLista.TabIndex = 18;
            // 
            // updownPrecio
            // 
            this.updownPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updownPrecio.Location = new System.Drawing.Point(614, 16);
            this.updownPrecio.Name = "updownPrecio";
            this.updownPrecio.Size = new System.Drawing.Size(90, 22);
            this.updownPrecio.TabIndex = 20;
            this.updownPrecio.Text = "domainUpDown2";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(1265, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Precio:";
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlmacen.Location = new System.Drawing.Point(427, 15);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.Size = new System.Drawing.Size(54, 22);
            this.txtAlmacen.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(1093, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Almacén:";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.Location = new System.Drawing.Point(19, 579);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(535, 55);
            this.txtBuscarProducto.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 698);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 39);
            this.label3.TabIndex = 25;
            this.label3.Text = "Principio Activo:";
            // 
            // txtPrincipioActivo
            // 
            this.txtPrincipioActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPrincipioActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipioActivo.Location = new System.Drawing.Point(293, 640);
            this.txtPrincipioActivo.Name = "txtPrincipioActivo";
            this.txtPrincipioActivo.Size = new System.Drawing.Size(261, 40);
            this.txtPrincipioActivo.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIva);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Location = new System.Drawing.Point(1046, 578);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 166);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(6, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 39);
            this.label6.TabIndex = 37;
            this.label6.Text = "Total";
            // 
            // txtIva
            // 
            this.txtIva.AutoSize = true;
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIva.Location = new System.Drawing.Point(6, 66);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(157, 39);
            this.txtIva.TabIndex = 36;
            this.txtIva.Text = "IVA 19%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 39);
            this.label4.TabIndex = 33;
            this.label4.Text = "Sub-Total";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(186, 68);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(261, 40);
            this.textBox11.TabIndex = 35;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(186, 114);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(261, 40);
            this.txtTotal.TabIndex = 34;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(186, 22);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(261, 40);
            this.txtSubTotal.TabIndex = 33;
            // 
            // drdVendedor
            // 
            this.drdVendedor.AllowDrop = true;
            this.drdVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drdVendedor.FormattingEnabled = true;
            this.drdVendedor.Location = new System.Drawing.Point(112, 15);
            this.drdVendedor.Name = "drdVendedor";
            this.drdVendedor.Size = new System.Drawing.Size(163, 24);
            this.drdVendedor.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Vendedor:";
            // 
            // btnSistema
            // 
            this.btnSistema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(229)))));
            this.btnSistema.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnSistema.FlatAppearance.BorderSize = 3;
            this.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistema.ForeColor = System.Drawing.Color.White;
            this.btnSistema.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSistema.IconColor = System.Drawing.Color.White;
            this.btnSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSistema.IconSize = 50;
            this.btnSistema.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSistema.Location = new System.Drawing.Point(1334, 142);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSistema.Size = new System.Drawing.Size(175, 110);
            this.btnSistema.TabIndex = 55;
            this.btnSistema.Text = "SIstema";
            this.btnSistema.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSistema.UseVisualStyleBackColor = false;
            this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
            // 
            // btnReciboIngreso
            // 
            this.btnReciboIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReciboIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(229)))));
            this.btnReciboIngreso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnReciboIngreso.FlatAppearance.BorderSize = 3;
            this.btnReciboIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReciboIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciboIngreso.ForeColor = System.Drawing.Color.White;
            this.btnReciboIngreso.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.btnReciboIngreso.IconColor = System.Drawing.Color.White;
            this.btnReciboIngreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReciboIngreso.IconSize = 50;
            this.btnReciboIngreso.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnReciboIngreso.Location = new System.Drawing.Point(1334, 12);
            this.btnReciboIngreso.Name = "btnReciboIngreso";
            this.btnReciboIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReciboIngreso.Size = new System.Drawing.Size(175, 110);
            this.btnReciboIngreso.TabIndex = 54;
            this.btnReciboIngreso.Text = "Recibo \r\nde Ingreso";
            this.btnReciboIngreso.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReciboIngreso.UseVisualStyleBackColor = false;
            this.btnReciboIngreso.Click += new System.EventHandler(this.btnReciboIngreso_Click);
            // 
            // btnCargarDocumento
            // 
            this.btnCargarDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(229)))));
            this.btnCargarDocumento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnCargarDocumento.FlatAppearance.BorderSize = 3;
            this.btnCargarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDocumento.ForeColor = System.Drawing.Color.White;
            this.btnCargarDocumento.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.btnCargarDocumento.IconColor = System.Drawing.Color.White;
            this.btnCargarDocumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarDocumento.IconSize = 50;
            this.btnCargarDocumento.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCargarDocumento.Location = new System.Drawing.Point(1153, 142);
            this.btnCargarDocumento.Name = "btnCargarDocumento";
            this.btnCargarDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCargarDocumento.Size = new System.Drawing.Size(175, 110);
            this.btnCargarDocumento.TabIndex = 53;
            this.btnCargarDocumento.Text = "Cargar \r\nDocumento\r\n\r\n";
            this.btnCargarDocumento.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCargarDocumento.UseVisualStyleBackColor = false;
            // 
            // btnGuardarDocumento
            // 
            this.btnGuardarDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(229)))));
            this.btnGuardarDocumento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnGuardarDocumento.FlatAppearance.BorderSize = 3;
            this.btnGuardarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDocumento.ForeColor = System.Drawing.Color.White;
            this.btnGuardarDocumento.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btnGuardarDocumento.IconColor = System.Drawing.Color.White;
            this.btnGuardarDocumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarDocumento.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGuardarDocumento.Location = new System.Drawing.Point(1153, 12);
            this.btnGuardarDocumento.Name = "btnGuardarDocumento";
            this.btnGuardarDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGuardarDocumento.Size = new System.Drawing.Size(175, 110);
            this.btnGuardarDocumento.TabIndex = 52;
            this.btnGuardarDocumento.Text = "Guardar \r\nDocumento";
            this.btnGuardarDocumento.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGuardarDocumento.UseVisualStyleBackColor = false;
            // 
            // btnCargarPrecio
            // 
            this.btnCargarPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(229)))));
            this.btnCargarPrecio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnCargarPrecio.FlatAppearance.BorderSize = 3;
            this.btnCargarPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPrecio.ForeColor = System.Drawing.Color.White;
            this.btnCargarPrecio.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnCargarPrecio.IconColor = System.Drawing.Color.White;
            this.btnCargarPrecio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarPrecio.IconSize = 50;
            this.btnCargarPrecio.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCargarPrecio.Location = new System.Drawing.Point(972, 142);
            this.btnCargarPrecio.Name = "btnCargarPrecio";
            this.btnCargarPrecio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCargarPrecio.Size = new System.Drawing.Size(175, 110);
            this.btnCargarPrecio.TabIndex = 51;
            this.btnCargarPrecio.Text = "Cambiar\r\nPrecio\r\n";
            this.btnCargarPrecio.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCargarPrecio.UseVisualStyleBackColor = false;
            this.btnCargarPrecio.Click += new System.EventHandler(this.btnCargarPrecio_Click);
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevoluciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(229)))));
            this.btnDevoluciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnDevoluciones.FlatAppearance.BorderSize = 3;
            this.btnDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevoluciones.ForeColor = System.Drawing.Color.White;
            this.btnDevoluciones.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnDevoluciones.IconColor = System.Drawing.Color.White;
            this.btnDevoluciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDevoluciones.IconSize = 50;
            this.btnDevoluciones.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDevoluciones.Location = new System.Drawing.Point(972, 12);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDevoluciones.Size = new System.Drawing.Size(175, 110);
            this.btnDevoluciones.TabIndex = 50;
            this.btnDevoluciones.Text = "Devoluciones";
            this.btnDevoluciones.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDevoluciones.UseVisualStyleBackColor = false;
            this.btnDevoluciones.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // btnEgresoCaja
            // 
            this.btnEgresoCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEgresoCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(229)))));
            this.btnEgresoCaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnEgresoCaja.FlatAppearance.BorderSize = 3;
            this.btnEgresoCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEgresoCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgresoCaja.ForeColor = System.Drawing.Color.White;
            this.btnEgresoCaja.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnEgresoCaja.IconColor = System.Drawing.Color.White;
            this.btnEgresoCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEgresoCaja.IconSize = 50;
            this.btnEgresoCaja.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEgresoCaja.Location = new System.Drawing.Point(791, 142);
            this.btnEgresoCaja.Name = "btnEgresoCaja";
            this.btnEgresoCaja.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEgresoCaja.Size = new System.Drawing.Size(175, 110);
            this.btnEgresoCaja.TabIndex = 49;
            this.btnEgresoCaja.Text = "Egreso \r\nde Caja";
            this.btnEgresoCaja.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEgresoCaja.UseVisualStyleBackColor = false;
            this.btnEgresoCaja.Click += new System.EventHandler(this.btnEgresoCaja_Click);
            // 
            // btnTicketsEmitidos
            // 
            this.btnTicketsEmitidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTicketsEmitidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(229)))));
            this.btnTicketsEmitidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnTicketsEmitidos.FlatAppearance.BorderSize = 3;
            this.btnTicketsEmitidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketsEmitidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketsEmitidos.ForeColor = System.Drawing.Color.White;
            this.btnTicketsEmitidos.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.btnTicketsEmitidos.IconColor = System.Drawing.Color.White;
            this.btnTicketsEmitidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTicketsEmitidos.IconSize = 50;
            this.btnTicketsEmitidos.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnTicketsEmitidos.Location = new System.Drawing.Point(791, 12);
            this.btnTicketsEmitidos.Name = "btnTicketsEmitidos";
            this.btnTicketsEmitidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTicketsEmitidos.Size = new System.Drawing.Size(175, 110);
            this.btnTicketsEmitidos.TabIndex = 48;
            this.btnTicketsEmitidos.Text = "Tickets \r\nEmitidos\r\n";
            this.btnTicketsEmitidos.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTicketsEmitidos.UseVisualStyleBackColor = false;
            this.btnTicketsEmitidos.Click += new System.EventHandler(this.btnTicketsEmitidos_Click);
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.panel10.Location = new System.Drawing.Point(1006, 810);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(153, 13);
            this.panel10.TabIndex = 68;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.panel11.Location = new System.Drawing.Point(1165, 810);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(153, 13);
            this.panel11.TabIndex = 69;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel12.Location = new System.Drawing.Point(1354, 810);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(153, 13);
            this.panel12.TabIndex = 70;
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.panel13.Location = new System.Drawing.Point(485, 753);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(237, 13);
            this.panel13.TabIndex = 68;
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.panel14.Location = new System.Drawing.Point(535, 252);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(250, 13);
            this.panel14.TabIndex = 70;
            // 
            // panel16
            // 
            this.panel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.panel16.Location = new System.Drawing.Point(560, 621);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(162, 13);
            this.panel16.TabIndex = 72;
            // 
            // panel17
            // 
            this.panel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.panel17.Location = new System.Drawing.Point(560, 680);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(162, 13);
            this.panel17.TabIndex = 73;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.btnBuscar.FlatAppearance.BorderSize = 3;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 50;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(247, 201);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnBuscar.Size = new System.Drawing.Size(135, 43);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnDelivery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.btnDelivery.FlatAppearance.BorderSize = 3;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            this.btnDelivery.IconColor = System.Drawing.Color.White;
            this.btnDelivery.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelivery.IconSize = 50;
            this.btnDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelivery.Location = new System.Drawing.Point(878, 652);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(162, 56);
            this.btnDelivery.TabIndex = 65;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelivery.UseVisualStyleBackColor = false;
            // 
            // btnProductoFaltante
            // 
            this.btnProductoFaltante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductoFaltante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnProductoFaltante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.btnProductoFaltante.FlatAppearance.BorderSize = 3;
            this.btnProductoFaltante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoFaltante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoFaltante.ForeColor = System.Drawing.Color.White;
            this.btnProductoFaltante.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnProductoFaltante.IconColor = System.Drawing.Color.White;
            this.btnProductoFaltante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductoFaltante.IconSize = 50;
            this.btnProductoFaltante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoFaltante.Location = new System.Drawing.Point(878, 584);
            this.btnProductoFaltante.Name = "btnProductoFaltante";
            this.btnProductoFaltante.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnProductoFaltante.Size = new System.Drawing.Size(162, 56);
            this.btnProductoFaltante.TabIndex = 64;
            this.btnProductoFaltante.Text = "Producto Faltante";
            this.btnProductoFaltante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductoFaltante.UseVisualStyleBackColor = false;
            this.btnProductoFaltante.Click += new System.EventHandler(this.btnProductoFaltante_Click);
            // 
            // btnProductosNoVendidos
            // 
            this.btnProductosNoVendidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductosNoVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnProductosNoVendidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.btnProductosNoVendidos.FlatAppearance.BorderSize = 3;
            this.btnProductosNoVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosNoVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosNoVendidos.ForeColor = System.Drawing.Color.White;
            this.btnProductosNoVendidos.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnProductosNoVendidos.IconColor = System.Drawing.Color.White;
            this.btnProductosNoVendidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductosNoVendidos.IconSize = 50;
            this.btnProductosNoVendidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductosNoVendidos.Location = new System.Drawing.Point(1006, 750);
            this.btnProductosNoVendidos.Name = "btnProductosNoVendidos";
            this.btnProductosNoVendidos.Size = new System.Drawing.Size(153, 64);
            this.btnProductosNoVendidos.TabIndex = 66;
            this.btnProductosNoVendidos.Text = "Productos \r\nno Vendidos";
            this.btnProductosNoVendidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductosNoVendidos.UseVisualStyleBackColor = false;
            this.btnProductosNoVendidos.Click += new System.EventHandler(this.btnProductosNoVendidos_Click);
            // 
            // btnAperturaCaja
            // 
            this.btnAperturaCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAperturaCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnAperturaCaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.btnAperturaCaja.FlatAppearance.BorderSize = 3;
            this.btnAperturaCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAperturaCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAperturaCaja.ForeColor = System.Drawing.Color.White;
            this.btnAperturaCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnAperturaCaja.IconColor = System.Drawing.Color.White;
            this.btnAperturaCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAperturaCaja.IconSize = 50;
            this.btnAperturaCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAperturaCaja.Location = new System.Drawing.Point(485, 699);
            this.btnAperturaCaja.Name = "btnAperturaCaja";
            this.btnAperturaCaja.Size = new System.Drawing.Size(237, 56);
            this.btnAperturaCaja.TabIndex = 63;
            this.btnAperturaCaja.Text = "Apertura de Caja";
            this.btnAperturaCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAperturaCaja.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 50;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(1354, 750);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(153, 64);
            this.btnSalir.TabIndex = 59;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.btnVentas.FlatAppearance.BorderSize = 3;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 45;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(1165, 750);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(153, 64);
            this.btnVentas.TabIndex = 56;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnAbrirCajon
            // 
            this.btnAbrirCajon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbrirCajon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnAbrirCajon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.btnAbrirCajon.FlatAppearance.BorderSize = 3;
            this.btnAbrirCajon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCajon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCajon.ForeColor = System.Drawing.Color.White;
            this.btnAbrirCajon.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btnAbrirCajon.IconColor = System.Drawing.Color.White;
            this.btnAbrirCajon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbrirCajon.IconSize = 50;
            this.btnAbrirCajon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirCajon.Location = new System.Drawing.Point(560, 639);
            this.btnAbrirCajon.Name = "btnAbrirCajon";
            this.btnAbrirCajon.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnAbrirCajon.Size = new System.Drawing.Size(162, 46);
            this.btnAbrirCajon.TabIndex = 61;
            this.btnAbrirCajon.Text = "Abrir Cajón";
            this.btnAbrirCajon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirCajon.UseVisualStyleBackColor = false;
            this.btnAbrirCajon.Click += new System.EventHandler(this.btnAbrirCajon_Click);
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnCotizacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.btnCotizacion.FlatAppearance.BorderSize = 3;
            this.btnCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizacion.ForeColor = System.Drawing.Color.White;
            this.btnCotizacion.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWaveAlt;
            this.btnCotizacion.IconColor = System.Drawing.Color.White;
            this.btnCotizacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCotizacion.IconSize = 50;
            this.btnCotizacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCotizacion.Location = new System.Drawing.Point(560, 578);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnCotizacion.Size = new System.Drawing.Size(162, 46);
            this.btnCotizacion.TabIndex = 60;
            this.btnCotizacion.Text = "Cotización";
            this.btnCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCotizacion.UseVisualStyleBackColor = false;
            // 
            // btnDescripciónFarmacologica
            // 
            this.btnDescripciónFarmacologica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescripciónFarmacologica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnDescripciónFarmacologica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.btnDescripciónFarmacologica.FlatAppearance.BorderSize = 3;
            this.btnDescripciónFarmacologica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescripciónFarmacologica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescripciónFarmacologica.ForeColor = System.Drawing.Color.White;
            this.btnDescripciónFarmacologica.IconChar = FontAwesome.Sharp.IconChar.Pills;
            this.btnDescripciónFarmacologica.IconColor = System.Drawing.Color.White;
            this.btnDescripciónFarmacologica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescripciónFarmacologica.IconSize = 50;
            this.btnDescripciónFarmacologica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescripciónFarmacologica.Location = new System.Drawing.Point(535, 183);
            this.btnDescripciónFarmacologica.Name = "btnDescripciónFarmacologica";
            this.btnDescripciónFarmacologica.Size = new System.Drawing.Size(250, 73);
            this.btnDescripciónFarmacologica.TabIndex = 58;
            this.btnDescripciónFarmacologica.Text = "Descripción \r\nfarmacológica";
            this.btnDescripciónFarmacologica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescripciónFarmacologica.UseVisualStyleBackColor = false;
            this.btnDescripciónFarmacologica.Click += new System.EventHandler(this.btnDescripciónFarmacologica_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 13);
            this.panel2.TabIndex = 72;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.panel1.Location = new System.Drawing.Point(791, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 13);
            this.panel1.TabIndex = 73;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.panel3.Location = new System.Drawing.Point(972, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 13);
            this.panel3.TabIndex = 74;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.panel4.Location = new System.Drawing.Point(1334, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 13);
            this.panel4.TabIndex = 76;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.panel5.Location = new System.Drawing.Point(1153, 119);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 13);
            this.panel5.TabIndex = 75;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.panel6.Location = new System.Drawing.Point(1334, 252);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 13);
            this.panel6.TabIndex = 80;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.panel7.Location = new System.Drawing.Point(972, 252);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(175, 13);
            this.panel7.TabIndex = 78;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.panel8.Location = new System.Drawing.Point(1153, 252);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(175, 13);
            this.panel8.TabIndex = 79;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.panel9.Location = new System.Drawing.Point(791, 252);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(175, 13);
            this.panel9.TabIndex = 77;
            // 
            // panel18
            // 
            this.panel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel18.BackColor = System.Drawing.Color.SlateGray;
            this.panel18.Controls.Add(this.label8);
            this.panel18.Controls.Add(this.label7);
            this.panel18.Controls.Add(this.label5);
            this.panel18.Controls.Add(this.drdVendedor);
            this.panel18.Controls.Add(this.txtAlmacen);
            this.panel18.Controls.Add(this.updownPrecio);
            this.panel18.Location = new System.Drawing.Point(791, 271);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(718, 48);
            this.panel18.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(539, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(334, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Almacén:";
            // 
            // panelBuscarPersona
            // 
            this.panelBuscarPersona.BackColor = System.Drawing.Color.SlateGray;
            this.panelBuscarPersona.Controls.Add(this.label13);
            this.panelBuscarPersona.Controls.Add(this.textBox1);
            this.panelBuscarPersona.Controls.Add(this.textBox2);
            this.panelBuscarPersona.Controls.Add(this.label12);
            this.panelBuscarPersona.Controls.Add(this.textBox3);
            this.panelBuscarPersona.Controls.Add(this.textBox4);
            this.panelBuscarPersona.Controls.Add(this.textBox5);
            this.panelBuscarPersona.Controls.Add(this.btnBuscar);
            this.panelBuscarPersona.Controls.Add(this.label14);
            this.panelBuscarPersona.Controls.Add(this.label16);
            this.panelBuscarPersona.Controls.Add(this.label15);
            this.panelBuscarPersona.Location = new System.Drawing.Point(389, 84);
            this.panelBuscarPersona.Name = "panelBuscarPersona";
            this.panelBuscarPersona.Size = new System.Drawing.Size(396, 256);
            this.panelBuscarPersona.TabIndex = 83;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(139, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 30);
            this.textBox1.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(139, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 30);
            this.textBox2.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 29);
            this.label12.TabIndex = 47;
            this.label12.Text = "Correo:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(139, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 30);
            this.textBox3.TabIndex = 42;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(139, 129);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(243, 30);
            this.textBox4.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 29);
            this.label13.TabIndex = 46;
            this.label13.Text = "Teléfono:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(139, 93);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(243, 30);
            this.textBox5.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 29);
            this.label14.TabIndex = 45;
            this.label14.Text = "Dirección:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 29);
            this.label16.TabIndex = 43;
            this.label16.Text = "Rut:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(2, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 29);
            this.label15.TabIndex = 44;
            this.label15.Text = "Nombre:";
            // 
            // btnDesplegarBuscar
            // 
            this.btnDesplegarBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnDesplegarBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.btnDesplegarBuscar.FlatAppearance.BorderSize = 3;
            this.btnDesplegarBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesplegarBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesplegarBuscar.ForeColor = System.Drawing.Color.White;
            this.btnDesplegarBuscar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnDesplegarBuscar.IconColor = System.Drawing.Color.White;
            this.btnDesplegarBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDesplegarBuscar.IconSize = 50;
            this.btnDesplegarBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesplegarBuscar.Location = new System.Drawing.Point(389, 12);
            this.btnDesplegarBuscar.Name = "btnDesplegarBuscar";
            this.btnDesplegarBuscar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnDesplegarBuscar.Size = new System.Drawing.Size(396, 66);
            this.btnDesplegarBuscar.TabIndex = 84;
            this.btnDesplegarBuscar.Text = "Buscar";
            this.btnDesplegarBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesplegarBuscar.UseVisualStyleBackColor = false;
            this.btnDesplegarBuscar.Click += new System.EventHandler(this.btnDesplegarBuscar_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.panel15.Location = new System.Drawing.Point(389, 75);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(396, 13);
            this.panel15.TabIndex = 71;
            // 
            // panel19
            // 
            this.panel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.panel19.Location = new System.Drawing.Point(878, 633);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(162, 13);
            this.panel19.TabIndex = 73;
            // 
            // panel20
            // 
            this.panel20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.panel20.Location = new System.Drawing.Point(878, 705);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(162, 13);
            this.panel20.TabIndex = 74;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.panel21.Location = new System.Drawing.Point(19, 156);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(183, 13);
            this.panel21.TabIndex = 75;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.iconButton1.FlatAppearance.BorderSize = 3;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 50;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(19, 96);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(183, 62);
            this.iconButton1.TabIndex = 74;
            this.iconButton1.Text = "Existencia en Locales";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1521, 839);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.panelBuscarPersona);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.btnDesplegarBuscar);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSistema);
            this.Controls.Add(this.btnReciboIngreso);
            this.Controls.Add(this.btnCargarDocumento);
            this.Controls.Add(this.btnGuardarDocumento);
            this.Controls.Add(this.btnCargarPrecio);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.btnDevoluciones);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.btnEgresoCaja);
            this.Controls.Add(this.btnTicketsEmitidos);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.btnDelivery);
            this.Controls.Add(this.btnProductoFaltante);
            this.Controls.Add(this.btnProductosNoVendidos);
            this.Controls.Add(this.btnAperturaCaja);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnAbrirCajon);
            this.Controls.Add(this.btnCotizacion);
            this.Controls.Add(this.btnDescripciónFarmacologica);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPrincipioActivo);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Punto de Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panelBuscarPersona.ResumeLayout(false);
            this.panelBuscarPersona.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DomainUpDown updownPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlmacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrincipioActivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtIva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.ComboBox drdVendedor;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnDescripciónFarmacologica;
        private FontAwesome.Sharp.IconButton btnCotizacion;
        private FontAwesome.Sharp.IconButton btnAbrirCajon;
        private FontAwesome.Sharp.IconButton btnAperturaCaja;
        private FontAwesome.Sharp.IconButton btnProductoFaltante;
        private FontAwesome.Sharp.IconButton btnDelivery;
        private FontAwesome.Sharp.IconButton btnTicketsEmitidos;
        private FontAwesome.Sharp.IconButton btnEgresoCaja;
        private FontAwesome.Sharp.IconButton btnDevoluciones;
        private FontAwesome.Sharp.IconButton btnCargarPrecio;
        private FontAwesome.Sharp.IconButton btnGuardarDocumento;
        private FontAwesome.Sharp.IconButton btnCargarDocumento;
        private FontAwesome.Sharp.IconButton btnReciboIngreso;
        private FontAwesome.Sharp.IconButton btnSistema;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnProductosNoVendidos;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panelBuscarPersona;
        private FontAwesome.Sharp.IconButton btnDesplegarBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

