using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
using MaterialSkin;


namespace ptoVenta
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {

        public static SqlConnection cn;
        SqlCommand com;
        SqlDataReader dr;

        //private DataGridView dgvGrid1 = new DataGridView();

        public static int totf = 0;
        public static int totp = 0;
        public static int tots = 0;
        public static int toti = 0;
        public static string newpre = "";
        public static string cod = "";
        private string upre = "";

        public static string nombre = "";
        public static string rut = "";
        public static string telefono = "";
        public static string correo = "";
        public static string direccion = "";
        public static double desc = 0;

        public string ucodigo = "";
        public string unombre = "";
        public string uperfil = "";
        public string ucaja = "";

        string empresalic = "";
        string erif = "";
        string edire = "";
        public static string eservidor = "";
        public static string edatabase = "";
        string eserial = "";
        string elogo = "";
        string vari = "";
        string vfoto = "";
        public static int montoape = 0;
        string uforma = "";
        string strHostName = Dns.GetHostName();
        string vuser = "";
        public static string alma = "";
        public static string mante = "";

        public SqlDataReader Dr { get => dr; set => dr = value; }

        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue800, Primary.LightBlue400, Accent.LightBlue100, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = Conexion.conexion();
            cn.Open();

            textBox1.BorderStyle = BorderStyle.None;
            iconButton1.Left = iconButton3.Left;
            dgvLista.Width = dgvGrid1.Width;
            dgvLista.Visible = false;
            dgvGrid1.Visible = false;
            int anc = dgvGrid1.Width;
            int ancp = 0;
            for( int a = 0; a < 10; a++)
            {
                ancp = ancp + dgvGrid1.Columns[a].Width;
            }
            anc = (anc - ancp) - 20;
            dgvGrid1.Columns[3].Width = dgvGrid1.Columns[3].Width + anc;
            anc = dgvLista.Width;
            ancp = 0;
            for (int a = 0; a < 8; a++)
            {
                ancp = ancp + dgvLista.Columns[a].Width;
            }
            anc = (anc - ancp) - 20;
            dgvLista.Columns[3].Width = dgvLista.Columns[3].Width + anc;

            alternarColorData(dgvLista);
            dgvLista.Rows.Clear();
            dgvGrid1.Rows.Clear();

            Cargarvariables();
            dgvGrid1.Visible = true;
            timer1.Start();
        }

        public void Cargarvariables()
        {
            empresalic = "FARMACIAS GEMINIS SPA";
            textBox1.Text = empresalic;
            com = new SqlCommand("SELECT * FROM EMPRESA", cn);
            com.ExecuteNonQuery();
            Dr = com.ExecuteReader();
            while (Dr.Read())
            {
                mante = Convert.ToString(Dr["MANTE"]);
                erif = Convert.ToString(Dr["ERIF"]);
                edire = Convert.ToString(Dr["EDIRECCION"]);
                eserial = Convert.ToString(Dr["FONDOSYS"]);
                elogo = Convert.ToString(Dr["LOGOSYS"]);
                alma = Convert.ToString(Dr["ALMACEN"]);
                desc = Convert.ToDouble(Dr["PDESC"]);
            }
            Dr.Close();

            com = new SqlCommand("SELECT * FROM LOCALES WHERE SIGLAS= '" + mante + "' ", cn);
            com.ExecuteNonQuery();
            Dr = com.ExecuteReader();
            while (Dr.Read())
            {
                label13.Text= Convert.ToString(Dr["NOMBRE"]).Trim();
                label13.Text = Convert.ToString(Dr["NOMBRE"]).Trim();
            }
            Dr.Close();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            controlCambio();
        }

        private void controlCambio()
        {
            vari = txtProducto.Text.Trim();
            if (!string.IsNullOrEmpty(vari))
            {
                string ivari = vari.Substring(0, 1);
                if (vari.All(Char.IsLetter) || ivari.ToString() == "*" || ivari.ToString() == "+")
                {
                    panel1.Visible = true;
                    dgvLista.Visible = true;
                    dgvLista.Rows.Clear();
                    com = new SqlCommand("SELECT I.CODIGO,I.NOMBRE,E.CANTIDAD STOCK,CONVERT(numeric(10,0),ROUND(I.PRECIO1*1.19,-1)) PRECIO1,CONVERT(numeric(10,0),ROUND(I.PRECIO2*1.19,-1)) PRECIO2,I.PRINCIPIO,I.FOTO FROM INVENTARIO I LEFT JOIN EXISTENCIA E ON E.CODIGO=I.CODIGO WHERE I.NOMBRE LIKE '" + vari + "%' ORDER BY I.NOMBRE", cn);
                    if (ivari.ToString() == "*" && vari.Length > 3)
                    {
                        vari = vari.Substring(1);
                        com = new SqlCommand("SELECT I.CODIGO,I.NOMBRE,E.CANTIDAD STOCK,CONVERT(numeric(10,0),ROUND(I.PRECIO1*1.19,-1)) PRECIO1,CONVERT(numeric(10,0),ROUND(I.PRECIO2*1.19,-1)) PRECIO2,I.PRINCIPIO,I.FOTO FROM INVENTARIO I LEFT JOIN EXISTENCIA E ON E.CODIGO=I.CODIGO WHERE I.NOMBRE LIKE '%" + vari + "%' ORDER BY I.NOMBRE", cn);
                    }
                    if (ivari.ToString() == "+" && vari.Length > 3)
                    {
                        vari = vari.Substring(1);
                        com = new SqlCommand("SELECT I.CODIGO,I.NOMBRE,E.CANTIDAD STOCK,CONVERT(numeric(10,0),ROUND(I.PRECIO1*1.19,-1)) PRECIO1,CONVERT(numeric(10,0),ROUND(I.PRECIO2*1.19,-1)) PRECIO2,I.PRINCIPIO,I.FOTO FROM INVENTARIO I LEFT JOIN EXISTENCIA E ON E.CODIGO=I.CODIGO WHERE I.PRINCIPIO LIKE '%" + vari + "%' ORDER BY I.NOMBRE", cn);
                    }
                    com.ExecuteNonQuery();
                    Dr = com.ExecuteReader();
                    while (Dr.Read())
                    {
                        int renglon = dgvLista.Rows.Add();
                        dgvLista.Rows[renglon].Cells["Linea"].Value = Convert.ToString(renglon + 1);
                        vfoto = (string)Convert.ToString(Dr["FOTO"]);
                        if (vfoto.Trim() != "")
                        {
                            if (File.Exists(vfoto))
                            {
                                dgvLista.Rows[renglon].Cells["FOTO"].Value = Image.FromFile(vfoto);
                            }
                        }
                        dgvLista.Rows[renglon].Cells["CODIGO"].Value = Dr["CODIGO"] == DBNull.Value ? " " : Convert.ToString(Dr["CODIGO"]).Trim();
                        dgvLista.Rows[renglon].Cells["PRODUCTO"].Value = Dr["NOMBRE"] == DBNull.Value ? " " : Convert.ToString(Dr["NOMBRE"]).Trim();
                        dgvLista.Rows[renglon].Cells["PRINCIPIO"].Value = Dr["PRINCIPIO"] == DBNull.Value ? " " : Convert.ToString(Dr["PRINCIPIO"]).Trim();
                        dgvLista.Rows[renglon].Cells["STOCK"].Value = Dr["STOCK"] == DBNull.Value ? 0 : Convert.ToDouble(Dr["STOCK"]);
                        dgvLista.Rows[renglon].Cells["PRECIO"].Value = Dr["PRECIO1"] == DBNull.Value ? 0 : Convert.ToDouble(Dr["PRECIO1"]);
                        dgvLista.Rows[renglon].Cells["OFERTA"].Value = Dr["PRECIO2"] == DBNull.Value ? 0 : Convert.ToDouble(Dr["PRECIO2"]);
                    }
                    Dr.Close();
                }
            }
            else
            {
                panel1.Visible = false;
                dgvLista.Visible = false;
                txtProducto.Focus();
            }
        }

        public void asignavalores()
        {
            rut = txtRut.Text.ToString();
            nombre = txtNombre.Text.ToString();
            direccion = txtDireccion.Text.ToString();
            telefono = txtTelefono.Text.ToString();
            correo = txtCorreo.Text.ToString();
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                vari = txtProducto.Text.Trim();
                if (!string.IsNullOrEmpty(vari))
                {
                    this.dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    if (vari.Substring(0, 1) == "*" || vari.Substring(0, 1) == "+")
                    {
                        vari = vari.Substring(1);
                    }
                    if (vari.All(Char.IsLetter)) 
                    {
                        dgvLista.Rows[0].Selected = true;
                        dgvLista.Focus(); 
                    }
                    else 
                    { 
                        Cargarproducto(); 
                    }
                }
                else
                {
                    int vtot = (int)Convert.ToDouble(txtTotal.Text);
                    if (vtot > 0 && iconButton1.Visible == true)
                    {
                        asignavalores();
                        cierreBoleta frm = new cierreBoleta();
                        AddOwnedForm(frm);
                        frm.ShowDialog();
                        Sumarproductos();
                    }
                }
            }
            if (e.KeyChar == 27)
            {
                if (!string.IsNullOrEmpty(txtProducto.Text.Trim()))
                {
                    txtProducto.Text = "";
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtTotal.Text.Trim()))
                    {
                        dgvGrid1.Rows.Clear();
                    }
                }
            }
            if (e.KeyChar == 120) 
            {
                cambiaprecios();
            }
        }

        private void dgvLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvLista.SelectionMode = DataGridViewSelectionMode.CellSelect;
            if (e.KeyChar == 13)
            {
                vari = Convert.ToString(dgvLista.Rows[dgvLista.CurrentRow.Index - 1].Cells[2].Value).Trim();
                upre = Convert.ToString(dgvLista.Rows[dgvLista.CurrentRow.Index - 1].Cells[6].Value).Trim();
                Cargarproducto();
            }
            if (e.KeyChar == 27)
            {
                Cargarproducto();
            }
        }

        private void dgvLista_DoubleClick(object sender, EventArgs e)
        {
            vari = Convert.ToString(dgvLista.Rows[dgvLista.CurrentRow.Index].Cells[2].Value).Trim();
            Cargarproducto();
        }

        public void Cargarproducto()
        {
            //BUSCAR REGISTRO
            int fila = 0;
            int cant = 0;
            int enc  = 0;

            foreach (DataGridViewRow row in dgvGrid1.Rows)
            {
                if (row.Cells["CODIGO1"].Value != null)
                {
                    row.Selected = false;
                    fila += 1;
                    string ss = row.Cells["CODIGO1"].Value.ToString();
                    cant = Convert.ToInt32(row.Cells["CANTIDAD1"].Value.ToString());
                    ss = ss.Trim();
                    if (vari == ss)
                    {
                        enc = 1;
                        cant = Convert.ToInt32(row.Cells["CANTIDAD1"].Value.ToString()) + 1;
                        break;
                    }
                }
            }
            if (enc != 0)
            {
                dgvGrid1.Rows[fila - 1].Cells["CANTIDAD1"].Value = cant.ToString();
                dgvGrid1.Rows[fila - 1].Cells["PRECIO1"].Value = upre.ToString();
            }
            else
            {
                int renglon = 0;
                com = new SqlCommand("SELECT I.CODIGO,I.NOMBRE,E.CANTIDAD STOCK,CONVERT(numeric(10,0),ROUND(I.PRECIO1*1.19,-1)) PRECIO1,CONVERT(numeric(10,0),ROUND(I.PRECIO2*1.19,-1)) PRECIO2,I.PRINCIPIO,I.FOTO FROM INVENTARIO I LEFT JOIN EXISTENCIA E ON E.CODIGO=I.CODIGO WHERE I.CODIGO = '" + vari + "' ", cn);
                com.ExecuteNonQuery();
                Dr = com.ExecuteReader();
                while (Dr.Read())
                {
                    renglon = dgvGrid1.Rows.Add();
                    dgvGrid1.Rows[renglon].Cells["Linea1"].Value = Convert.ToString(renglon+1);
                    string vfoto = (string)Convert.ToString(Dr["FOTO"]);
                    if (vfoto.Trim() != "")
                    {
                        if (File.Exists(vfoto))
                        {
                            dgvGrid1.Rows[renglon].Cells["FOTO1"].Value = Image.FromFile(vfoto);
                        }
                    }
                    dgvGrid1.Rows[renglon].Cells["CODIGO1"].Value = Dr["CODIGO"] == DBNull.Value ? " " : Convert.ToString(Dr["CODIGO"]).Trim();
                    dgvGrid1.Rows[renglon].Cells["PRODUCTO1"].Value = Dr["NOMBRE"] == DBNull.Value ? " " : Convert.ToString(Dr["NOMBRE"]).Trim();
                    dgvGrid1.Rows[renglon].Cells["STOCK1"].Value = Dr["STOCK"] == DBNull.Value ? 0 : Convert.ToDouble(Dr["STOCK"]);
                    dgvGrid1.Rows[renglon].Cells["CANTIDAD1"].Value = "1";
                    dgvGrid1.Rows[renglon].Cells["PRECIO1"].Value = Dr["PRECIO1"] == DBNull.Value ? 0 : Convert.ToDouble(Dr["PRECIO1"]);
                    dgvGrid1.Rows[renglon].Cells["OFERTA1"].Value = Dr["PRECIO2"] == DBNull.Value ? 0 : Convert.ToDouble(Dr["PRECIO2"]);
                    dgvGrid1.Rows[renglon].Cells["TOTAL1"].Value = Dr["PRECIO1"] == DBNull.Value ? 0 : Convert.ToDouble(Dr["PRECIO1"]);
                }
                Dr.Close();
                if (renglon>0)
                {
                    dgvGrid1.CurrentCell = dgvGrid1.Rows[renglon].Cells[0];
                }
            }
            Sumarproductos();
        }

        public void Sumarproductos() 
        {
            int fila = 0;
            int cant;
            int prec, pre1,tpre;
            int ofer;
            int tot,toto;
            totf = 0;
            totp = 0;
            tots = 0;
            toti = 0;

            foreach (DataGridViewRow row in dgvGrid1.Rows)
            {
                if (row.Cells["CODIGO1"].Value != null)
                {
                    fila += 1;
                    cant = Convert.ToInt32(row.Cells["CANTIDAD1"].Value.ToString());
                    prec = Convert.ToInt32(row.Cells["PRECIO1"].Value.ToString());
                    pre1 = prec;
                    ofer = Convert.ToInt32(row.Cells["OFERTA1"].Value.ToString());
                    if (ofer > 0 && cant > 1)
                    {
                       prec = ofer;
                    }
                    string cod = (row.Cells["CODIGO1"].Value.ToString());
                    com = new SqlCommand("SELECT * FROM COMPRAVENTA WHERE codigo = '" + cod + "' ", Form1.cn);
                    com.ExecuteNonQuery();
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        prec = dr["COSTO"] == DBNull.Value ? 0 : Convert.ToInt32(Dr["COSTO"]);
                    }
                    dr.Close();
                    tot = cant * prec;
                    tpre = cant * pre1;
                    dgvGrid1.Rows[fila - 1].Cells["TOTAL1"].Value = tot;
                    tot = Convert.ToInt32(row.Cells["TOTAL1"].Value.ToString());
                    totf += tot;
                    totp += tpre;
                    tots = (int)Math.Round(totf / 1.19);
                    toti = totf - tots;
                }
            }
            txtTotal.Text = totf.ToString("N0");
            txtSubTotal.Text = tots.ToString("N0");
            txtIva.Text = toti.ToString("N0");
            textBox2.Text = totp.ToString("N0");
            toto = totp - totf;
            textBox3.Text = toto.ToString("N0");
            txtProducto.Text = "";
            txtProducto.Focus();
        }

        public void alternarColorData(DataGridView dgv)
        {
            dgvLista.RowsDefaultCellStyle.BackColor = Color.MistyRose;
            dgvLista.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgvLista.EnableHeadersVisualStyles = false;
            dgvLista.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSlateBlue;
            dgvLista.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvGrid1.RowsDefaultCellStyle.BackColor = Color.Azure;
            dgvGrid1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgvGrid1.EnableHeadersVisualStyles = false;
            dgvGrid1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(121,195,93);
            dgvGrid1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void btnExistenciaenLocales_Click_1(object sender, EventArgs e)
        {
            existenciaLocales abrirExistencia = new existenciaLocales();
            abrirExistencia.ShowDialog();
            txtProducto.Text = "";
            txtProducto.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            formClass abrirFormClass = new formClass();
            abrirFormClass.ShowDialog();
            txtProducto.Text = "";
            txtProducto.Focus();
        }

        private void btnTicketsEmitidos_Click(object sender, EventArgs e)
        {
            ticketsEmitidos abrirTicketsEmitidos = new ticketsEmitidos();
            abrirTicketsEmitidos.ShowDialog();
            txtProducto.Text = "";
            txtProducto.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            iniciarSesion abririniciarSesion = new iniciarSesion();
            abririniciarSesion.ShowDialog();
            label14.Text = "Caja: " + iniciarSesion.ucaja.Trim() + " " + iniciarSesion.unombre.Trim();
            int position = eservidor.IndexOf(";");
            edatabase = eservidor.Substring(position+18);
            eservidor = eservidor.Substring(14, position-14);

            position = edatabase.IndexOf(";");
            edatabase = edatabase.Substring(1,position-1);

            label16.Text = eservidor.ToString() + " (" + edatabase.ToString() + ")";
            //apertura de caja
            vuser = iniciarSesion.ucodigo.Trim();
                com = new SqlCommand("SELECT TOP 1 * FROM USUARIOS WHERE CODIGO = '" + vuser + "' ", cn);
                com.ExecuteNonQuery();
                Dr = com.ExecuteReader();
                while (Dr.Read())
                {
                    uforma = Convert.ToString(Dr["FORMATO"]);
                }
                Dr.Close();
                if (uforma.Trim() == strHostName)
                {
                    iconButton1.Visible = true;
                }
            //
            txtProducto.ReadOnly = false;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            vuser = iniciarSesion.ucodigo.Trim();
            com = new SqlCommand("SELECT TOP 1 * FROM USUARIOS WHERE CODIGO = '"+vuser+"' ", cn);
            com.ExecuteNonQuery();
            Dr = com.ExecuteReader(); 
            while (Dr.Read())
            {
                uforma = Convert.ToString(Dr["FORMATO"]);
            }
            Dr.Close();
            if (uforma.Trim() != "")
            {
                if (uforma.Trim() == strHostName) 
                {
                    MessageBox.Show("SU CAJA YA ESTA APERTURADA EN ESTE COMPUTADOR");
                }
                else
                {
                    MessageBox.Show("SU CAJA YA ESTA APERTURADA EN EL COMPUTADOR: " + uforma.Trim());
                }
            }
            else
            {
                aperturaCaja frm = new aperturaCaja();
                frm.ShowDialog();
                if(montoape > 0)
                {
                    string rec = "";
                    com = new SqlCommand("SELECT MAX(convert(int, RECIBO))+1 REXP FROM RECIBOS WHERE TIPO=1", cn);
                    com.ExecuteNonQuery();
                    Dr = com.ExecuteReader();
                    while (Dr.Read())
                    {
                        rec = Convert.ToString(Dr["REXP"]);
                    }
                    Dr.Close();
                    string cod = iniciarSesion.ucodigo.Trim();
                    string nom = iniciarSesion.unombre.Trim();
                    string con = "APERTURA DE CAJA: " + nom;
                    string caj = iniciarSesion.ucaja.Trim();
                    int mon = montoape;
                    com = new SqlCommand("INSERT INTO RECIBOS (CODIGO,RECIBO,FECHA,NOMBRE,CONCEPTO,CAJA,MONTO,TIPO) VALUES ('"+cod+ "','"+rec+ "', '" + DateTime.Now + "','" + nom + "','" + con+"','"+caj+"',"+mon+","+1+") ", cn);
                    com.ExecuteNonQuery();

                    com = new SqlCommand("UPDATE USUARIOS SET FORMATO = '" + strHostName + "' WHERE CODIGO = '" + vuser + "' ", cn);
                    com.ExecuteNonQuery();

                    Dr.Close();
                    //Report Form reci To Printer Noconsole
                    iconButton1.Visible = true;
                }
            }
            txtProducto.Text = "";
            txtProducto.Focus();
        }

        private void btnEgresoCaja_Click(object sender, EventArgs e)
        {
            egresoCaja abriregresoCajas = new egresoCaja();
            abriregresoCajas.ShowDialog();

            txtProducto.Text = "";
            txtProducto.Focus();
        }

        private void dgvGrid1_CurrentCellChanged(object sender, EventArgs e)
        {
            Sumarproductos();
        }

        private void dgvGrid1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewComboBoxEditingControl dgvCombo = e.Control as DataGridViewComboBoxEditingControl;

            if (dgvCombo != null)
            {
                dgvCombo.SelectedIndexChanged -= new EventHandler(dvgCombo_SelectedIndexChanged);
                dgvCombo.SelectedIndexChanged += new EventHandler(dvgCombo_SelectedIndexChanged);
            }
        }

        private void dvgCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            int xcan = Convert.ToInt32(combo.SelectedIndex);
            xcan = xcan + 1;
            dgvGrid1.Rows[dgvGrid1.CurrentRow.Index].Cells[5].Value = xcan.ToString();
            Sumarproductos();

            txtProducto.Text = "";
            txtProducto.Focus();
        }

        private void dgvGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrid1.Rows.Count > 0)
            {
                if (dgvGrid1.CurrentCell.ColumnIndex == 9)
                {
                    dgvGrid1.Rows.Remove(dgvGrid1.CurrentRow);
                }
            }
            if (dgvGrid1.Rows.Count > 0)
            {
                if (dgvGrid1.CurrentCell.ColumnIndex == 6)
                {
                    cambiaprecios();
                }
            }

        }

        private void cambiaprecios()
        {
            newpre = "";
            cod = Convert.ToString(dgvGrid1.Rows[dgvGrid1.CurrentRow.Index].Cells[2].Value);
            cambiarPrecio frm = new cambiarPrecio();
            frm.ShowDialog();
            if (Convert.ToInt32(newpre) > 0)
            {
                dgvGrid1.Rows[dgvGrid1.CurrentRow.Index].Cells["PRECIO1"].Value = newpre.ToString();
            }
            Sumarproductos();
            txtProducto.Text = "";
            txtProducto.Focus();
     }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            bool passed = false;
            if (keyData == Keys.F9)
            {
                if (dgvGrid1.Rows.Count > 0)
                {
                    cambiaprecios();
                    passed = false;
                }
            }

            return passed;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reporte abrirReporte = new Reporte();
            abrirReporte.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormFactura abrirFactura = new FormFactura();
            abrirFactura.Show();
        }

        private void btnAggImagen_Click(object sender, EventArgs e)
        {
            aggImagen abrirAgg = new aggImagen();
            abrirAgg.Show();
        }
    }
}
