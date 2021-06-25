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
            //declaramos la cadena  de conexion
            string cadenaconexion = @"Data Source = 10.147.18.245\GEMINIS; initial Catalog = SAES_ADMINISTRATIVOFD; user id = sa; password = 12345";
            //variable de tipo Sqlconnection
            SqlConnection con = new SqlConnection();
            //variable de tipo Sqlcommand
            SqlCommand comando = new SqlCommand();
            //variable SqlDataReader para leer los datos
            SqlDataReader dr;
            con.ConnectionString = cadenaconexion;
            comando.Connection = con;
            //declaramos el comando para realizar la busqueda
            comando.CommandText = "SELECT top 50 * FROM inventario";
            //especificamos que es de tipo Text
            comando.CommandType = CommandType.Text;
            //se abre la conexion
            con.Open();
            //limpiamos los renglones de la datagridview
            dgvLista.Rows.Clear();
            //a la variable DataReader asignamos  el la variable de tipo SqlCommand
            dr = comando.ExecuteReader();
            //el ciclo while se ejecutará mientras lea registros en la tabla
            while (dr.Read())
            {
                //variable de tipo entero para ir enumerando los la filas del datagridview
                int renglon = dgvLista.Rows.Add();
                // especificamos en que fila se mostrará cada registro
                // nombredeldatagrid.filas[numerodefila].celdas[nombredelacelda].valor=
                // dr.tipodedatosalmacenado(dr.getordinal(nombredelcampo_en_la_base_de_datos)conviertelo_a_string_sino_es_del_tipo_string);
                dgvLista.Rows[renglon].Cells["CODIGO"].Value = dr.GetString(dr.GetOrdinal("CODIGO"));
                dgvLista.Rows[renglon].Cells["NOMBRE"].Value = dr.GetString(dr.GetOrdinal("NOMBRE"));
                dgvLista.Rows[renglon].Cells["GRUPO"].Value = dr.GetString(dr.GetOrdinal("GRUPO"));
            }
            //cierra la conexión
            con.Close();
        }
        public void alternarColorData(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        public void Cargarproducto()
        {
            //BUSCAR REGISTRO
            int fila = 0;
            int cant = 0;
            int prec = 0;
            int tot = 0;
            int enc = 0;

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
