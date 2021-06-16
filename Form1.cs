using System;
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

        public object Procedimientos { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alternarColorData(dgvLista);
            //cargardatagridview();
            cargarconexion();
        }

        public void cargarconexion()
        {
            cn = new SqlConnection("Data Source = SERVER-GEMINIS1\\GEMINIS; initial Catalog = SAES_ADMINISTRATIVOFD; user id = sa; password = FG12345");
            cn.Open(); 
            dgvLista.Rows.Clear();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            controlProducto();
        }

        private void controlProducto()
        {
            if (txtProducto.Text.Trim() != string.Empty && txtProducto.Text.All(Char.IsLetter))
            {
                dgvLista.Rows.Clear();
                string vari = txtProducto.Text.Trim();
                com = new SqlCommand("SELECT I.CODIGO,I.NOMBRE,E.CANTIDAD STOCK,I.PRECIO1 FROM INVENTARIO I LEFT JOIN EXISTENCIA E ON E.CODIGO=I.CODIGO WHERE I.NOMBRE LIKE '"+vari+"%' ORDER BY I.NOMBRE",cn);
                com.ExecuteNonQuery();
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    int renglon = dgvLista.Rows.Add();
                    dgvLista.Rows[renglon].Cells["CODIGO"].Value =  dr.GetString(dr.GetOrdinal("CODIGO"));
                    dgvLista.Rows[renglon].Cells["PRODUCTO"].Value = dr.GetString(dr.GetOrdinal("NOMBRE"));
                    dgvLista.Rows[renglon].Cells["STOCK"].Value = dr.GetValue(dr.GetOrdinal("STOCK"));
                    dgvLista.Rows[renglon].Cells["PRECIO"].Value = dr.GetValue(dr.GetOrdinal("PRECIO1"));

                }
                dr.Close();
            }
            else
            {
                txtProducto.Focus();
            }
        }

        public void cargardatagridview()
        {
            //declaramos la cadena  de conexion
            string cadenaconexion = @"Data Source = 10.147.18.168\GEMINIS2; initial Catalog = SAES_ADMINISTRATIVOFD; user id = sa; password = 12345";
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
            dgv.RowsDefaultCellStyle.BackColor = Color.Azure;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
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

        private void txtSubTotal_Leave(object sender, EventArgs e)
        {
            
        }

        private void textIva_Leave(object sender, EventArgs e)
        {

        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {

        }

        private void btnCambiarFotodgv_Click(object sender, EventArgs e)
        {
            AgregarFoto abrirAgregarFoto = new AgregarFoto();
            abrirAgregarFoto.Show();
        }
    }
}
