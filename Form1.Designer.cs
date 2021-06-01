
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRdeIngreso = new System.Windows.Forms.Button();
            this.btnGuardarDocumento = new System.Windows.Forms.Button();
            this.btnDevoluciones = new System.Windows.Forms.Button();
            this.btnTicketsEmitidos = new System.Windows.Forms.Button();
            this.btnEgresoCaja = new System.Windows.Forms.Button();
            this.btnCambiarPrecio = new System.Windows.Forms.Button();
            this.btnCargarDocumento = new System.Windows.Forms.Button();
            this.btnSistema = new System.Windows.Forms.Button();
            this.btnDescripcionFarmacologica = new System.Windows.Forms.Button();
            this.btnExistenciaenLocales = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbAsignar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1431, 13);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 46);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRdeIngreso
            // 
            this.btnRdeIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnRdeIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRdeIngreso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRdeIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRdeIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRdeIngreso.ForeColor = System.Drawing.Color.White;
            this.btnRdeIngreso.Location = new System.Drawing.Point(1332, 67);
            this.btnRdeIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnRdeIngreso.Name = "btnRdeIngreso";
            this.btnRdeIngreso.Size = new System.Drawing.Size(168, 60);
            this.btnRdeIngreso.TabIndex = 1;
            this.btnRdeIngreso.Text = "Recibo de Ingreso";
            this.btnRdeIngreso.UseVisualStyleBackColor = false;
            this.btnRdeIngreso.Click += new System.EventHandler(this.btnRdeIngreso_Click);
            // 
            // btnGuardarDocumento
            // 
            this.btnGuardarDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnGuardarDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardarDocumento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDocumento.ForeColor = System.Drawing.Color.White;
            this.btnGuardarDocumento.Location = new System.Drawing.Point(1156, 67);
            this.btnGuardarDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarDocumento.Name = "btnGuardarDocumento";
            this.btnGuardarDocumento.Size = new System.Drawing.Size(168, 60);
            this.btnGuardarDocumento.TabIndex = 2;
            this.btnGuardarDocumento.Text = "Guardar Documento";
            this.btnGuardarDocumento.UseVisualStyleBackColor = false;
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnDevoluciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDevoluciones.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevoluciones.ForeColor = System.Drawing.Color.White;
            this.btnDevoluciones.Location = new System.Drawing.Point(980, 67);
            this.btnDevoluciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(168, 60);
            this.btnDevoluciones.TabIndex = 3;
            this.btnDevoluciones.Text = "Devoluciones";
            this.btnDevoluciones.UseVisualStyleBackColor = false;
            this.btnDevoluciones.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // btnTicketsEmitidos
            // 
            this.btnTicketsEmitidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnTicketsEmitidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTicketsEmitidos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTicketsEmitidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketsEmitidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketsEmitidos.ForeColor = System.Drawing.Color.White;
            this.btnTicketsEmitidos.Location = new System.Drawing.Point(804, 67);
            this.btnTicketsEmitidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnTicketsEmitidos.Name = "btnTicketsEmitidos";
            this.btnTicketsEmitidos.Size = new System.Drawing.Size(168, 60);
            this.btnTicketsEmitidos.TabIndex = 4;
            this.btnTicketsEmitidos.Text = "Tickets Emitidos";
            this.btnTicketsEmitidos.UseVisualStyleBackColor = false;
            this.btnTicketsEmitidos.Click += new System.EventHandler(this.btnTicketsEmitidos_Click);
            // 
            // btnEgresoCaja
            // 
            this.btnEgresoCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnEgresoCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEgresoCaja.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEgresoCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEgresoCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgresoCaja.ForeColor = System.Drawing.Color.White;
            this.btnEgresoCaja.Location = new System.Drawing.Point(804, 135);
            this.btnEgresoCaja.Margin = new System.Windows.Forms.Padding(4);
            this.btnEgresoCaja.Name = "btnEgresoCaja";
            this.btnEgresoCaja.Size = new System.Drawing.Size(168, 60);
            this.btnEgresoCaja.TabIndex = 8;
            this.btnEgresoCaja.Text = "Egreso de Caja";
            this.btnEgresoCaja.UseVisualStyleBackColor = false;
            this.btnEgresoCaja.Click += new System.EventHandler(this.btnEgresoCaja_Click);
            // 
            // btnCambiarPrecio
            // 
            this.btnCambiarPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnCambiarPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCambiarPrecio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCambiarPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarPrecio.ForeColor = System.Drawing.Color.White;
            this.btnCambiarPrecio.Location = new System.Drawing.Point(980, 135);
            this.btnCambiarPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiarPrecio.Name = "btnCambiarPrecio";
            this.btnCambiarPrecio.Size = new System.Drawing.Size(168, 60);
            this.btnCambiarPrecio.TabIndex = 7;
            this.btnCambiarPrecio.Text = "Cambiar Precio";
            this.btnCambiarPrecio.UseVisualStyleBackColor = false;
            this.btnCambiarPrecio.Click += new System.EventHandler(this.btnCambiarPrecio_Click);
            // 
            // btnCargarDocumento
            // 
            this.btnCargarDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnCargarDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCargarDocumento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCargarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDocumento.ForeColor = System.Drawing.Color.White;
            this.btnCargarDocumento.Location = new System.Drawing.Point(1156, 135);
            this.btnCargarDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarDocumento.Name = "btnCargarDocumento";
            this.btnCargarDocumento.Size = new System.Drawing.Size(168, 60);
            this.btnCargarDocumento.TabIndex = 6;
            this.btnCargarDocumento.Text = "Cargar Documento";
            this.btnCargarDocumento.UseVisualStyleBackColor = false;
            // 
            // btnSistema
            // 
            this.btnSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
            this.btnSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSistema.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistema.ForeColor = System.Drawing.Color.White;
            this.btnSistema.Location = new System.Drawing.Point(1332, 135);
            this.btnSistema.Margin = new System.Windows.Forms.Padding(4);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Size = new System.Drawing.Size(168, 60);
            this.btnSistema.TabIndex = 5;
            this.btnSistema.Text = "Sistema";
            this.btnSistema.UseVisualStyleBackColor = false;
            this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
            // 
            // btnDescripcionFarmacologica
            // 
            this.btnDescripcionFarmacologica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnDescripcionFarmacologica.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDescripcionFarmacologica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescripcionFarmacologica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescripcionFarmacologica.ForeColor = System.Drawing.Color.White;
            this.btnDescripcionFarmacologica.Location = new System.Drawing.Point(484, 193);
            this.btnDescripcionFarmacologica.Name = "btnDescripcionFarmacologica";
            this.btnDescripcionFarmacologica.Size = new System.Drawing.Size(281, 44);
            this.btnDescripcionFarmacologica.TabIndex = 9;
            this.btnDescripcionFarmacologica.Text = "Descripción Farmacológica";
            this.btnDescripcionFarmacologica.UseVisualStyleBackColor = false;
            this.btnDescripcionFarmacologica.Click += new System.EventHandler(this.btnDescripcionFarmacologica_Click);
            // 
            // btnExistenciaenLocales
            // 
            this.btnExistenciaenLocales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnExistenciaenLocales.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExistenciaenLocales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExistenciaenLocales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistenciaenLocales.ForeColor = System.Drawing.Color.White;
            this.btnExistenciaenLocales.Location = new System.Drawing.Point(310, 31);
            this.btnExistenciaenLocales.Name = "btnExistenciaenLocales";
            this.btnExistenciaenLocales.Size = new System.Drawing.Size(125, 60);
            this.btnExistenciaenLocales.TabIndex = 10;
            this.btnExistenciaenLocales.Text = "Existencia en Locales";
            this.btnExistenciaenLocales.UseVisualStyleBackColor = false;
            this.btnExistenciaenLocales.Click += new System.EventHandler(this.btnExistenciaenLocales_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(277, 97);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 34);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.btnCotizacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizacion.ForeColor = System.Drawing.Color.White;
            this.btnCotizacion.Location = new System.Drawing.Point(554, 621);
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
            this.btnAbrirCajon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAbrirCajon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCajon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCajon.ForeColor = System.Drawing.Color.White;
            this.btnAbrirCajon.Location = new System.Drawing.Point(683, 621);
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
            this.btnAperturaCaja.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAperturaCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAperturaCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAperturaCaja.ForeColor = System.Drawing.Color.White;
            this.btnAperturaCaja.Location = new System.Drawing.Point(911, 619);
            this.btnAperturaCaja.Margin = new System.Windows.Forms.Padding(4);
            this.btnAperturaCaja.Name = "btnAperturaCaja";
            this.btnAperturaCaja.Size = new System.Drawing.Size(121, 52);
            this.btnAperturaCaja.TabIndex = 30;
            this.btnAperturaCaja.Text = "Apertura Caja";
            this.btnAperturaCaja.UseVisualStyleBackColor = false;
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(195)))), ((int)(((byte)(93)))));
            this.btnCotizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCotizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
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
            this.btnProductoFaltante.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProductoFaltante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoFaltante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoFaltante.ForeColor = System.Drawing.Color.White;
            this.btnProductoFaltante.Location = new System.Drawing.Point(911, 679);
            this.btnProductoFaltante.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductoFaltante.Name = "btnProductoFaltante";
            this.btnProductoFaltante.Size = new System.Drawing.Size(121, 55);
            this.btnProductoFaltante.TabIndex = 31;
            this.btnProductoFaltante.Text = "Producto Faltante";
            this.btnProductoFaltante.UseVisualStyleBackColor = false;
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
            this.btnDelivery.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Location = new System.Drawing.Point(782, 741);
            this.btnDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(121, 42);
            this.btnDelivery.TabIndex = 38;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.UseVisualStyleBackColor = false;
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
            // cmbAsignar
            // 
            this.cmbAsignar.AllowDrop = true;
            this.cmbAsignar.FormattingEnabled = true;
            this.cmbAsignar.Location = new System.Drawing.Point(902, 218);
            this.cmbAsignar.Name = "cmbAsignar";
            this.cmbAsignar.Size = new System.Drawing.Size(163, 24);
            this.cmbAsignar.TabIndex = 39;
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
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1524, 796);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAsignar);
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
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnExistenciaenLocales);
            this.Controls.Add(this.btnDescripcionFarmacologica);
            this.Controls.Add(this.btnEgresoCaja);
            this.Controls.Add(this.btnCambiarPrecio);
            this.Controls.Add(this.btnCargarDocumento);
            this.Controls.Add(this.btnSistema);
            this.Controls.Add(this.btnTicketsEmitidos);
            this.Controls.Add(this.btnDevoluciones);
            this.Controls.Add(this.btnGuardarDocumento);
            this.Controls.Add(this.btnRdeIngreso);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRdeIngreso;
        private System.Windows.Forms.Button btnGuardarDocumento;
        private System.Windows.Forms.Button btnDevoluciones;
        private System.Windows.Forms.Button btnTicketsEmitidos;
        private System.Windows.Forms.Button btnEgresoCaja;
        private System.Windows.Forms.Button btnCambiarPrecio;
        private System.Windows.Forms.Button btnCargarDocumento;
        private System.Windows.Forms.Button btnSistema;
        private System.Windows.Forms.Button btnDescripcionFarmacologica;
        private System.Windows.Forms.Button btnExistenciaenLocales;
        private System.Windows.Forms.Button btnBuscar;
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
        private System.Windows.Forms.ComboBox cmbAsignar;
        private System.Windows.Forms.Label label5;
    }
}

