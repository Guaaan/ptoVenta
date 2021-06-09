using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptoVenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //cargardatagridview();
            //customizeDesign();
        }

        //abrir dropdown grande tipo panel
        /*private void customizeDesign()
        {
            panelBuscarPersona.Visible = false;
        }
        private void hideBuscarPersona()
        {
            if (panelBuscarPersona.Visible == true)
                panelBuscarPersona.Visible = false;
        }
        private void showBuscarPersona()
        {
            if (panelBuscarPersona.Visible == false)
            {
                hideBuscarPersona();
                panelBuscarPersona.Visible = true;
            }
            else
                panelBuscarPersona.Visible = false;
        }
        private void btnDesplegarBuscar_Click(object sender, EventArgs e)
        {
            showBuscarPersona();
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            alternarColorData(dgvLista);
        }
        /*public void cargardatagridview()
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
        }*/
        public void alternarColorData(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void btnTicketsEmitidos_Click(object sender, EventArgs e)
        {
            ticketsEmitidos abrirTicketsEmitidos = new ticketsEmitidos();
            abrirTicketsEmitidos.Show();

        }
    }

    public class sqlConnection
    {
    }
}
