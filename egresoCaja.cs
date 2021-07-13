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
using MaterialSkin;

namespace ptoVenta
{
    public partial class egresoCaja : MaterialSkin.Controls.MaterialForm
    {
        SqlCommand com;
        SqlDataReader dr;

        public egresoCaja()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue800, Primary.LightBlue400, Accent.LightBlue100, TextShade.WHITE);
        }

        private void egresoCaja_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CONCEPTOS ORDER BY NOMBRE", Form1.cn);
            da.Fill(ds, "CONCEPTOS");
            comboBox1.DataSource = ds.Tables[0].DefaultView;
            comboBox1.ValueMember = "NOMBRE";

            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM CLIENTES ORDER BY NOMBRE", Form1.cn);
            da2.Fill(ds2, "CLIENTES");
            comboBox2.DataSource = ds2.Tables[0].DefaultView;
            comboBox2.ValueMember = "NOMBRE";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
