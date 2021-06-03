
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
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.updownPrecio = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlmacen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrincipioActivo = new System.Windows.Forms.TextBox();
            this.btnCotizacion = new System.Windows.Forms.Button();
            this.btnAbrirCajon = new System.Windows.Forms.Button();
            this.btnAperturaCaja = new System.Windows.Forms.Button();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.btnProductoFaltante = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.drdVendedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExistenciaenLocales = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.iconButton11 = new FontAwesome.Sharp.IconButton();
            this.iconButton12 = new FontAwesome.Sharp.IconButton();
            this.iconButton13 = new FontAwesome.Sharp.IconButton();
            this.iconButton14 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRut
            // 
            this.txtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRut.Location = new System.Drawing.Point(106, 109);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(165, 22);
            this.txtRut.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(106, 137);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 22);
            this.txtNombre.TabIndex = 14;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(106, 193);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(241, 22);
            this.txtTelefono.TabIndex = 16;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(106, 165);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(241, 22);
            this.txtDireccion.TabIndex = 15;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(106, 221);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(241, 22);
            this.txtCorreo.TabIndex = 17;
            // 
            // dgvLista
            // 
            this.dgvLista.BackgroundColor = System.Drawing.Color.White;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 256);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(1488, 356);
            this.dgvLista.TabIndex = 18;
            // 
            // updownPrecio
            // 
            this.updownPrecio.Location = new System.Drawing.Point(1332, 219);
            this.updownPrecio.Name = "updownPrecio";
            this.updownPrecio.Size = new System.Drawing.Size(90, 22);
            this.updownPrecio.TabIndex = 20;
            this.updownPrecio.Text = "domainUpDown2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(1257, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Precio:";
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.Location = new System.Drawing.Point(1178, 219);
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.Size = new System.Drawing.Size(54, 22);
            this.txtAlmacen.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(1085, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Almacén:";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.Location = new System.Drawing.Point(12, 618);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(535, 55);
            this.txtBuscarProducto.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 676);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 39);
            this.label3.TabIndex = 25;
            this.label3.Text = "Principio Activo:";
            // 
            // txtPrincipioActivo
            // 
            this.txtPrincipioActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipioActivo.Location = new System.Drawing.Point(286, 679);
            this.txtPrincipioActivo.Name = "txtPrincipioActivo";
            this.txtPrincipioActivo.Size = new System.Drawing.Size(261, 40);
            this.txtPrincipioActivo.TabIndex = 26;
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnCotizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCotizacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.btnCotizacion.FlatAppearance.BorderSize = 3;
            this.btnCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizacion.ForeColor = System.Drawing.Color.White;
            this.btnCotizacion.Location = new System.Drawing.Point(507, 464);
            this.btnCotizacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Size = new System.Drawing.Size(121, 42);
            this.btnCotizacion.TabIndex = 27;
            this.btnCotizacion.Text = "Cotizacion";
            this.btnCotizacion.UseVisualStyleBackColor = false;
            // 
            // btnAbrirCajon
            // 
            this.btnAbrirCajon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnAbrirCajon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbrirCajon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.btnAbrirCajon.FlatAppearance.BorderSize = 3;
            this.btnAbrirCajon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCajon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCajon.ForeColor = System.Drawing.Color.White;
            this.btnAbrirCajon.Location = new System.Drawing.Point(732, 464);
            this.btnAbrirCajon.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirCajon.Name = "btnAbrirCajon";
            this.btnAbrirCajon.Size = new System.Drawing.Size(121, 42);
            this.btnAbrirCajon.TabIndex = 28;
            this.btnAbrirCajon.Text = "Abrir Cajón";
            this.btnAbrirCajon.UseVisualStyleBackColor = false;
            // 
            // btnAperturaCaja
            // 
            this.btnAperturaCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnAperturaCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAperturaCaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.btnAperturaCaja.FlatAppearance.BorderSize = 3;
            this.btnAperturaCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAperturaCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAperturaCaja.ForeColor = System.Drawing.Color.White;
            this.btnAperturaCaja.Location = new System.Drawing.Point(911, 619);
            this.btnAperturaCaja.Margin = new System.Windows.Forms.Padding(4);
            this.btnAperturaCaja.Name = "btnAperturaCaja";
            this.btnAperturaCaja.Size = new System.Drawing.Size(121, 63);
            this.btnAperturaCaja.TabIndex = 30;
            this.btnAperturaCaja.Text = "Apertura Caja";
            this.btnAperturaCaja.UseVisualStyleBackColor = false;
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnCotizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCotizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.btnCotizar.FlatAppearance.BorderSize = 3;
            this.btnCotizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.ForeColor = System.Drawing.Color.White;
            this.btnCotizar.Location = new System.Drawing.Point(911, 742);
            this.btnCotizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(121, 42);
            this.btnCotizar.TabIndex = 29;
            this.btnCotizar.Text = "Cotizacion";
            this.btnCotizar.UseVisualStyleBackColor = false;
            // 
            // btnProductoFaltante
            // 
            this.btnProductoFaltante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnProductoFaltante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProductoFaltante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.btnProductoFaltante.FlatAppearance.BorderSize = 3;
            this.btnProductoFaltante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoFaltante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoFaltante.ForeColor = System.Drawing.Color.White;
            this.btnProductoFaltante.Location = new System.Drawing.Point(911, 684);
            this.btnProductoFaltante.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductoFaltante.Name = "btnProductoFaltante";
            this.btnProductoFaltante.Size = new System.Drawing.Size(121, 55);
            this.btnProductoFaltante.TabIndex = 31;
            this.btnProductoFaltante.Text = "Producto Faltante";
            this.btnProductoFaltante.UseVisualStyleBackColor = false;
            this.btnProductoFaltante.Click += new System.EventHandler(this.btnProductoFaltante_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIva);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Location = new System.Drawing.Point(1039, 618);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(13, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Rut:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(13, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(13, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Teléfono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(13, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Dirección:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(13, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Correo:";
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelivery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.btnDelivery.FlatAppearance.BorderSize = 3;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Location = new System.Drawing.Point(782, 742);
            this.btnDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(121, 42);
            this.btnDelivery.TabIndex = 38;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = false;
            // 
            // drdVendedor
            // 
            this.drdVendedor.AllowDrop = true;
            this.drdVendedor.FormattingEnabled = true;
            this.drdVendedor.Location = new System.Drawing.Point(902, 218);
            this.drdVendedor.Name = "drdVendedor";
            this.drdVendedor.Size = new System.Drawing.Size(163, 24);
            this.drdVendedor.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(803, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Vendedor:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-18, -67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnExistenciaenLocales
            // 
            this.btnExistenciaenLocales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnExistenciaenLocales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.btnExistenciaenLocales.FlatAppearance.BorderSize = 3;
            this.btnExistenciaenLocales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExistenciaenLocales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistenciaenLocales.ForeColor = System.Drawing.Color.White;
            this.btnExistenciaenLocales.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.btnExistenciaenLocales.IconColor = System.Drawing.Color.White;
            this.btnExistenciaenLocales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExistenciaenLocales.IconSize = 50;
            this.btnExistenciaenLocales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExistenciaenLocales.Location = new System.Drawing.Point(310, 22);
            this.btnExistenciaenLocales.Name = "btnExistenciaenLocales";
            this.btnExistenciaenLocales.Size = new System.Drawing.Size(185, 60);
            this.btnExistenciaenLocales.TabIndex = 47;
            this.btnExistenciaenLocales.Text = "Existencia en Locales";
            this.btnExistenciaenLocales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExistenciaenLocales.UseVisualStyleBackColor = false;
            this.btnExistenciaenLocales.Click += new System.EventHandler(this.btnExistenciaenLocales_Click_1);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.iconButton1.FlatAppearance.BorderSize = 3;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 50;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(805, 66);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(168, 60);
            this.iconButton1.TabIndex = 48;
            this.iconButton1.Text = "Tickets \r\nEmitidos\r\n";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.iconButton2.FlatAppearance.BorderSize = 3;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 50;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(805, 132);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(168, 60);
            this.iconButton2.TabIndex = 49;
            this.iconButton2.Text = "Egreso \r\nde Caja";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.iconButton3.FlatAppearance.BorderSize = 3;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 50;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(979, 66);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(168, 60);
            this.iconButton3.TabIndex = 50;
            this.iconButton3.Text = "Devoluciones";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.iconButton4.FlatAppearance.BorderSize = 3;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 50;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(979, 132);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(168, 60);
            this.iconButton4.TabIndex = 51;
            this.iconButton4.Text = "Cambiar\r\nPrecio\r\n";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.iconButton5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.iconButton5.FlatAppearance.BorderSize = 3;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(1153, 66);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(168, 60);
            this.iconButton5.TabIndex = 52;
            this.iconButton5.Text = "Guardar \r\nDocumento";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.iconButton6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.iconButton6.FlatAppearance.BorderSize = 3;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.Color.White;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 50;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(1153, 132);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(168, 60);
            this.iconButton6.TabIndex = 53;
            this.iconButton6.Text = "Cargar \r\nDocumento\r\n\r\n";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.iconButton7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.iconButton7.FlatAppearance.BorderSize = 3;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.Color.White;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.iconButton7.IconColor = System.Drawing.Color.White;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 50;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(1327, 66);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(168, 60);
            this.iconButton7.TabIndex = 54;
            this.iconButton7.Text = "Recibo \r\nde Ingreso";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton7.UseVisualStyleBackColor = false;
            // 
            // iconButton8
            // 
            this.iconButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.iconButton8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.iconButton8.FlatAppearance.BorderSize = 3;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton8.ForeColor = System.Drawing.Color.White;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButton8.IconColor = System.Drawing.Color.White;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 50;
            this.iconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton8.Location = new System.Drawing.Point(1327, 132);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(168, 60);
            this.iconButton8.TabIndex = 55;
            this.iconButton8.Text = "SIstema";
            this.iconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton8.UseVisualStyleBackColor = false;
            // 
            // iconButton9
            // 
            this.iconButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.iconButton9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.iconButton9.FlatAppearance.BorderSize = 3;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton9.ForeColor = System.Drawing.Color.White;
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconButton9.IconColor = System.Drawing.Color.White;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 45;
            this.iconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton9.Location = new System.Drawing.Point(1153, 8);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Size = new System.Drawing.Size(145, 55);
            this.iconButton9.TabIndex = 56;
            this.iconButton9.Text = "Ventas";
            this.iconButton9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton9.UseVisualStyleBackColor = false;
            // 
            // iconButton10
            // 
            this.iconButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.iconButton10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.iconButton10.FlatAppearance.BorderSize = 3;
            this.iconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton10.ForeColor = System.Drawing.Color.White;
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton10.IconColor = System.Drawing.Color.White;
            this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton10.IconSize = 50;
            this.iconButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton10.Location = new System.Drawing.Point(277, 88);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButton10.Size = new System.Drawing.Size(135, 43);
            this.iconButton10.TabIndex = 57;
            this.iconButton10.Text = "Buscar";
            this.iconButton10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton10.UseVisualStyleBackColor = false;
            // 
            // iconButton11
            // 
            this.iconButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.iconButton11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.iconButton11.FlatAppearance.BorderSize = 3;
            this.iconButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton11.ForeColor = System.Drawing.Color.White;
            this.iconButton11.IconChar = FontAwesome.Sharp.IconChar.Pills;
            this.iconButton11.IconColor = System.Drawing.Color.White;
            this.iconButton11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton11.IconSize = 50;
            this.iconButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton11.Location = new System.Drawing.Point(547, 163);
            this.iconButton11.Name = "iconButton11";
            this.iconButton11.Size = new System.Drawing.Size(250, 73);
            this.iconButton11.TabIndex = 58;
            this.iconButton11.Text = "Descripción \r\nfarmacológica";
            this.iconButton11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton11.UseVisualStyleBackColor = false;
            // 
            // iconButton12
            // 
            this.iconButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.iconButton12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.iconButton12.FlatAppearance.BorderSize = 3;
            this.iconButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton12.ForeColor = System.Drawing.Color.White;
            this.iconButton12.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButton12.IconColor = System.Drawing.Color.White;
            this.iconButton12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton12.IconSize = 50;
            this.iconButton12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton12.Location = new System.Drawing.Point(1367, 3);
            this.iconButton12.Name = "iconButton12";
            this.iconButton12.Size = new System.Drawing.Size(128, 60);
            this.iconButton12.TabIndex = 59;
            this.iconButton12.Text = "Salir";
            this.iconButton12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton12.UseVisualStyleBackColor = false;
            // 
            // iconButton13
            // 
            this.iconButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.iconButton13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.iconButton13.FlatAppearance.BorderSize = 3;
            this.iconButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton13.ForeColor = System.Drawing.Color.White;
            this.iconButton13.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWaveAlt;
            this.iconButton13.IconColor = System.Drawing.Color.White;
            this.iconButton13.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton13.IconSize = 50;
            this.iconButton13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton13.Location = new System.Drawing.Point(553, 617);
            this.iconButton13.Name = "iconButton13";
            this.iconButton13.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.iconButton13.Size = new System.Drawing.Size(162, 46);
            this.iconButton13.TabIndex = 60;
            this.iconButton13.Text = "Cotización";
            this.iconButton13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton13.UseVisualStyleBackColor = false;
            // 
            // iconButton14
            // 
            this.iconButton14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.iconButton14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(145)))), ((int)(((byte)(189)))));
            this.iconButton14.FlatAppearance.BorderSize = 3;
            this.iconButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton14.ForeColor = System.Drawing.Color.White;
            this.iconButton14.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.iconButton14.IconColor = System.Drawing.Color.White;
            this.iconButton14.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton14.IconSize = 50;
            this.iconButton14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton14.Location = new System.Drawing.Point(721, 617);
            this.iconButton14.Name = "iconButton14";
            this.iconButton14.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.iconButton14.Size = new System.Drawing.Size(162, 46);
            this.iconButton14.TabIndex = 61;
            this.iconButton14.Text = "Abrir Caja";
            this.iconButton14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton14.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1524, 796);
            this.Controls.Add(this.iconButton14);
            this.Controls.Add(this.iconButton13);
            this.Controls.Add(this.iconButton12);
            this.Controls.Add(this.iconButton11);
            this.Controls.Add(this.iconButton10);
            this.Controls.Add(this.iconButton9);
            this.Controls.Add(this.iconButton8);
            this.Controls.Add(this.iconButton7);
            this.Controls.Add(this.iconButton6);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnExistenciaenLocales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.drdVendedor);
            this.Controls.Add(this.btnDelivery);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProductoFaltante);
            this.Controls.Add(this.btnAperturaCaja);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.btnAbrirCajon);
            this.Controls.Add(this.btnCotizacion);
            this.Controls.Add(this.txtPrincipioActivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlmacen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updownPrecio);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Punto de Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DomainUpDown updownPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlmacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrincipioActivo;
        private System.Windows.Forms.Button btnCotizacion;
        private System.Windows.Forms.Button btnAbrirCajon;
        private System.Windows.Forms.Button btnAperturaCaja;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Button btnProductoFaltante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtIva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.ComboBox drdVendedor;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnExistenciaenLocales;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton iconButton11;
        private FontAwesome.Sharp.IconButton iconButton12;
        private FontAwesome.Sharp.IconButton iconButton13;
        private FontAwesome.Sharp.IconButton iconButton14;
    }
}

