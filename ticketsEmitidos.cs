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

    public partial class ticketsEmitidos : MaterialSkin.Controls.MaterialForm
    {
        SqlCommand com;
        SqlDataReader dr;

        private DateTime fec1 = DateTime.Now;
        private DateTime fec2 = DateTime.Now;
        private string comsql1, comsql2;
        public static string vnum;

        public ticketsEmitidos()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue800, Primary.LightBlue400, Accent.LightBlue100, TextShade.WHITE);

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            calendarioTicketsE abrirCalendarioTickets = new calendarioTicketsE();
            abrirCalendarioTickets.Show();
        }

        private void ticketsEmitidos_Load(object sender, EventArgs e)
        {
            int anc = dgvGrid1.Width;
            int ancp = 0;
            for (int a = 0; a < 10; a++)
            {
                ancp = ancp + dgvGrid1.Columns[a].Width;
            }
            anc = (anc - ancp) - 100;
            dgvGrid1.Columns[5].Width = dgvGrid1.Columns[5].Width + anc;

            dgvGrid1.RowsDefaultCellStyle.BackColor = Color.Azure;
            dgvGrid1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgvGrid1.EnableHeadersVisualStyles = false;
            dgvGrid1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dgvGrid1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            cargaboletas();
        }

        private void cargaboletas()
        {
            fec2 = fec1.AddDays(+1);
            fec1 = fec1.AddDays(-30);
            string f1 = fec1.ToString("yyyyMMdd");
            string f2 = fec2.ToString("yyyyMMdd");
            comsql1 = "SELECT F.NUMERO,C.NOMBRE,M.FECHA,M.CODIGO,M.DESCRIP,M.CANTIDAD,M.MONTOFINAL FROM CAJAS C RIGHT JOIN FACTURAS F ON C.CODIGO = F.CAJAPERTUR ";
            comsql2 = comsql1 + "LEFT JOIN MFACTURAS M ON M.NUMERO = F.NUMERO WHERE F.STATUS=2 AND M.FECHA>'" + f1 + "' AND M.FECHA<'" + f2 + "' ORDER BY F.FECHA DESC ";
            com = new SqlCommand(comsql2, Form1.cn);
            com.ExecuteNonQuery();
            dr = com.ExecuteReader();
            dgvGrid1.Rows.Clear();
            int fila=0;
            while (dr.Read())
            {
                fila ++;
                int renglon = dgvGrid1.Rows.Add();
                dgvGrid1.Rows[renglon].Cells["Numero"].Value = Convert.ToString(dr["NUMERO"]).Trim();
                dgvGrid1.Rows[renglon].Cells["Caja"].Value = Convert.ToString(dr["NOMBRE"]).Trim();
                dgvGrid1.Rows[renglon].Cells["Fecha"].Value = Convert.ToString(dr["FECHA"]).Trim();
                dgvGrid1.Rows[renglon].Cells["Codigo"].Value = Convert.ToString(dr["CODIGO"]).Trim();
                dgvGrid1.Rows[renglon].Cells["Producto"].Value = Convert.ToString(dr["DESCRIP"]).Trim();
                dgvGrid1.Rows[renglon].Cells["Cantidad"].Value = Convert.ToString(dr["CANTIDAD"]).Trim();
                dgvGrid1.Rows[renglon].Cells["Precio"].Value = dr["MONTOFINAL"] == DBNull.Value ? 0 : Convert.ToDouble(dr["MONTOFINAL"]);
            }
            dr.Close();
            textBox1.Text = fila.ToString("N0");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fec1 = dateTimePicker1.Value;
            cargaboletas();
        }

        private void dgvGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrid1.Rows.Count > 0)
            {
                if (dgvGrid1.CurrentCell.ColumnIndex == 9)
                {
                    vnum = dgvGrid1.CurrentRow.Cells["NUMERO"].Value.ToString();
                            //Reportes abrirReporte = new Reportes();
                    //AddOwnedForm(abrirReporte);
                            //abrirReporte.Show();
                }
                if (dgvGrid1.CurrentCell.ColumnIndex == 10)
                {
                    vnum = dgvGrid1.CurrentRow.Cells["NUMERO"].Value.ToString();
                    devoluciones abrirFormClass = new devoluciones();
                    abrirFormClass.ShowDialog();
                }
            }
        }

        private void dgvGrid1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ticketsEmitidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
