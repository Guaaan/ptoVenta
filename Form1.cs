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


namespace ptoVenta
{
    public partial class Form1 : Form
    {

        SqlConnection cn;
        SqlCommand com;
        SqlDataReader dr;
        int totf = 0;
        public string ucodigo = "";
        public string unombre = "";
        public string uperfil = "";
        public string ucaja = "";

        string empresalic = "";
        string erif = "";
        string edire = "";
        string eservidor = "";
        string eserial = "";
        string elogo = "";
        string vari = "";

        public SqlDataReader Dr { get => dr; set => dr = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.BorderStyle = BorderStyle.None;
            dgvLista.Width = dgvGrid1.Width;
            dgvLista.Visible = false;
            dgvGrid1.Visible = false;
            int anc = dgvGrid1.Width;
            int ancp = 0;
            for( int a = 0; a < 9; a++)
            {
                ancp = ancp + dgvGrid1.Columns[a].Width;
            }
            anc = (anc - ancp) - 40;
            dgvGrid1.Columns[3].Width = dgvGrid1.Columns[3].Width + anc;
            anc = dgvLista.Width;
            ancp = 0;
            for (int a = 0; a < 8; a++)
            {
                ancp = ancp + dgvLista.Columns[a].Width;
            }
            anc = (anc - ancp) - 40;
            dgvLista.Columns[3].Width = dgvLista.Columns[3].Width + anc;

            alternarColorData(dgvLista);
            Cargarconexion();
            Cargarvariables();
            dgvGrid1.Visible = true;
            timer1.Start();
        }

        public void Cargarconexion()
        {

            string[] lines = System.IO.File.ReadAllLines(@"configsql.ini");
            foreach (string line in lines)
            {
                eservidor = eservidor + line;
            }
            cn = new SqlConnection(eservidor);
            //    "Data Source = server-fg1\\geminis1; initial Catalog = SAES_ADMINISTRATIVOFD; user id = sa; password = FG12345");
            cn.Open();
            dgvLista.Rows.Clear();
            dgvGrid1.Rows.Clear();
        }

        public void Cargarvariables()
        {
            string mante;
            mante = "";
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
            if (txtProducto.Text.Trim() != string.Empty && txtProducto.Text.All(Char.IsLetter))
            {
                panel1.Visible = true;
                dgvLista.Visible = true;

                dgvLista.Rows.Clear();
                string vari = txtProducto.Text.Trim();
                com = new SqlCommand("SELECT I.CODIGO,I.NOMBRE,E.CANTIDAD STOCK,I.PRECIO1,I.PRECIO2,I.PRINCIPIO,I.FOTO FROM INVENTARIO I LEFT JOIN EXISTENCIA E ON E.CODIGO=I.CODIGO WHERE I.NOMBRE LIKE '" + vari + "%' ORDER BY I.NOMBRE", cn);
                com.ExecuteNonQuery();
                Dr = com.ExecuteReader();
                while (Dr.Read())
                {
                    int renglon = dgvLista.Rows.Add();
                    dgvLista.Rows[renglon].Cells["Linea"].Value = Convert.ToString(renglon+1);
                    string vfoto = (string)Convert.ToString(Dr["FOTO"]);
                    if (vfoto.Trim() != "") 
                    {
                        if (File.Exists(vfoto))
                        {
                            dgvLista.Rows[renglon].Cells["FOTO"].Value = Image.FromFile(vfoto);
                        }
                    }
                    dgvLista.Rows[renglon].Cells["CODIGO"].Value = Dr["CODIGO"] == DBNull.Value ? " " : Convert.ToString(Dr["CODIGO"]);
                    dgvLista.Rows[renglon].Cells["PRODUCTO"].Value = Dr["NOMBRE"] == DBNull.Value ? " " : Convert.ToString(Dr["NOMBRE"]);
                    dgvLista.Rows[renglon].Cells["PRINCIPIO"].Value = Dr["PRINCIPIO"] == DBNull.Value ? " " : Convert.ToString(Dr["PRINCIPIO"]);
                    dgvLista.Rows[renglon].Cells["STOCK"].Value = Dr["STOCK"] == DBNull.Value ? 0 : Convert.ToDouble(Dr["STOCK"]);
                    dgvLista.Rows[renglon].Cells["PRECIO"].Value = Dr["PRECIO1"] == DBNull.Value ? 0 : Convert.ToDouble(Dr["PRECIO1"]);
                    dgvLista.Rows[renglon].Cells["OFERTA"].Value = Dr["PRECIO2"] == DBNull.Value ? 0 : Convert.ToDouble(Dr["PRECIO2"]);
                }
                Dr.Close();
            }
            else
            {
                panel1.Visible = false;
                dgvLista.Visible = false;
                txtProducto.Focus();
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 | e.KeyChar == 38)
            {
                if (txtProducto.Text.Trim() != string.Empty && txtProducto.Text.All(Char.IsLetter))
                {
                    //myGrid.CurrentCell = myGrid.Rows(1).Cells(1)
                    dgvLista.Focus();
                  }
                else
                {
                    vari = txtProducto.Text.Trim();
                    Cargarproducto();
                }
            }
        }

        private void dgvLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                vari = Convert.ToString(dgvLista.Rows[dgvLista.CurrentRow.Index-1].Cells[2].Value);
                Cargarproducto();
            }
            if (e.KeyChar == 27)
            {
                Cargarproducto();
            }

        }

        public void Cargarproducto()
        {
            //BUSCAR REGISTRO
            int fila = 0;
            int cant = 0;
            int prec = 0;
            int tot = 0;
            int enc = 0;

            foreach (DataGridViewRow row in dgvGrid1.Rows)
            {
                if (row.Cells["CODIGO1"].Value != null)
                {
                    row.Selected = false;
                    fila += 1;
                    string ss = row.Cells["CODIGO1"].Value.ToString();
                    ss = ss.Trim();
                    if (vari == ss)
                    {
                        enc = 1;
                        row.Selected = true;
                        totf -= Convert.ToInt32(row.Cells["TOTAL1"].Value.ToString());
                        cant = row.Cells["CANTIDAD1"].Value.GetHashCode() + 1;
                        prec = Convert.ToInt32(row.Cells["OFERTA1"].Value.ToString());
                        if (prec == 0)
                        {
                            prec = Convert.ToInt32(row.Cells["PRECIO1"].Value.ToString());
                        }
                        tot = prec * cant;
                        totf += tot;
                        break;
                    }
                }
            }
            //
            if (enc != 0)
            {
                dgvGrid1.Rows[fila - 1].Cells["CANTIDAD1"].Value = cant;
                dgvGrid1.Rows[fila - 1].Cells["TOTAL1"].Value = tot;
            }
            else
            {
                com = new SqlCommand("SELECT I.CODIGO,I.NOMBRE,E.CANTIDAD STOCK,CONVERT(numeric(10,0),ROUND(I.PRECIO1*1.19,-1)) PRECIO1,CONVERT(numeric(10,0),ROUND(I.PRECIO2*1.19,-1)) PRECIO2,I.PRINCIPIO,I.FOTO FROM INVENTARIO I LEFT JOIN EXISTENCIA E ON E.CODIGO=I.CODIGO WHERE I.CODIGO = '" + vari + "' ", cn);
                com.ExecuteNonQuery();
                Dr = com.ExecuteReader();
                int regs = 0;
                while (Dr.Read())
                {
                    regs += 1;
                    int renglon = dgvGrid1.Rows.Add();
                    dgvGrid1.Rows[renglon].Cells["Linea1"].Value = Convert.ToString(renglon+1);
                    string vfoto = (string)Convert.ToString(Dr["FOTO"]);
                    if (vfoto.Trim() != "")
                    {
                        if (File.Exists(vfoto))
                        {
                            dgvGrid1.Rows[renglon].Cells["FOTO1"].Value = Image.FromFile(vfoto);
                        }
                    }
                    dgvGrid1.Rows[renglon].Cells["CODIGO1"].Value = Dr["CODIGO"] == DBNull.Value ? " " : Convert.ToString(Dr["CODIGO"]);
                    dgvGrid1.Rows[renglon].Cells["PRODUCTO1"].Value = Dr["NOMBRE"] == DBNull.Value ? " " : Convert.ToString(Dr["NOMBRE"]);
                    dgvGrid1.Rows[renglon].Cells["STOCK1"].Value = Dr["STOCK"] == DBNull.Value ? 0 : Convert.ToDouble(Dr["STOCK"]);
                    dgvGrid1.Rows[renglon].Cells["CANTIDAD1"].Value = 1;
                    dgvGrid1.Rows[renglon].Cells["PRECIO1"].Value = Dr["PRECIO1"] == DBNull.Value ? 0 : Convert.ToDouble(Dr["PRECIO1"]);
                    dgvGrid1.Rows[renglon].Cells["OFERTA1"].Value = Dr["PRECIO2"] == DBNull.Value ? 0 : Convert.ToDouble(Dr["PRECIO2"]);
                    dgvGrid1.Rows[renglon].Cells["TOTAL1"].Value = Dr["PRECIO1"] == DBNull.Value ? 0 : Convert.ToDouble(Dr["PRECIO1"]);
                    prec = (int)Convert.ToDouble(Dr["PRECIO1"]);
                    //MessageBox.Show(prec.ToString());
                    totf = totf + (int)Convert.ToDouble(Dr["PRECIO1"]);
                }
                if (regs == 0)
                {
                    //System.Threading.Thread.Sleep(5000);
                }
                Dr.Close();
            }
            txtTotal.Text = Convert.ToString(totf);
            txtSubTotal.Text = Convert.ToString(Math.Round(totf / 1.19));
            txtIva.Text = Convert.ToString(totf - Math.Round(totf / 1.19));
            txtProducto.Text = " ";
        }

        public void alternarColorData(DataGridView dgv)
        {

            dgvLista.RowsDefaultCellStyle.BackColor = Color.MistyRose;
            dgvLista.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgvLista.EnableHeadersVisualStyles = false;
            dgvLista.ColumnHeadersDefaultCellStyle.BackColor = Color.Firebrick;
            dgvLista.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvGrid1.RowsDefaultCellStyle.BackColor = Color.Azure;
            dgvGrid1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgvGrid1.EnableHeadersVisualStyles = false;
            dgvGrid1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dgvGrid1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        private void btnExistenciaenLocales_Click_1(object sender, EventArgs e)
        {
            existenciaLocales abrirExistencia = new existenciaLocales();
            abrirExistencia.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            formClass abrirFormClass = new formClass();
            abrirFormClass.Show();
        }

        private void btnTicketsEmitidos_Click(object sender, EventArgs e)
        {
            ticketsEmitidos abrirTicketsEmitidos = new ticketsEmitidos();
            abrirTicketsEmitidos.Show();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            iniciarSesion abririniciarSecion = new iniciarSesion();
            abririniciarSecion.ShowDialog();
            label14.Text = "Caja: " + iniciarSesion.ucaja.Trim() + " " + iniciarSesion.unombre.Trim();
            int position = eservidor.IndexOf(";");
            label16.Text = eservidor.Substring(14, position-14);
            txtProducto.ReadOnly = false;
        }

    }
}
