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
    public partial class iniciarSesion : MaterialSkin.Controls.MaterialForm
    {

        SqlCommand com;
        SqlDataReader ur;
        public static string ucodigo = "";
        public static string unombre = "";
        public static string uperfil = "";
        public static string ucaja = "";

        public iniciarSesion()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue800, Primary.LightBlue400, Accent.LightBlue100, TextShade.WHITE);
            //this.Opacity = 0.9;
            SqlConnection connect = new SqlConnection("Server=Server-Vicuna/Vicuna database=; user=sa; password=;");
            
        }

        private void iniciarSesion_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM USUARIOS ORDER BY NOMBRE", Form1.cn);
            da.Fill(ds, "USUARIOS");
            comboBox1.DataSource = ds.Tables[0].DefaultView;
            comboBox1.ValueMember = "CODIGO";
        }

        private void iniciarSesion_Shown(object sender, EventArgs e)
        {
            Screen scr = Screen.FromPoint(Location);
            int al = scr.WorkingArea.Height + 10;
            this.Height = al;
            for (int i = Width * -1; i < -10;)

            {
                i = (int)(i + 0.5);
                Location = new Point(i, 0);
            }
        }

        

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Application.Exit();
                this.Close();
            }
            if (e.KeyChar == 13)
            {
                txtRut1.Focus();
            }

        }

        private void txtRut1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Application.Exit();
                this.Close();
            }
            if (e.KeyChar == 13)
            {
                string vclave = txtRut1.Text.Trim();
                string vuser = comboBox1.Text.Trim();
                if (String.IsNullOrEmpty(vuser) | String.IsNullOrEmpty(vclave))
                {
                    txtRut1.Text = "";
                    txtRut1.Focus();
                }
                else
                {
                    string uclave = " ";
                    unombre = " ";
                    ucodigo = " ";
                    uperfil = " ";
                    ucaja = " ";

                    com = new SqlCommand("SELECT TOP 1 * FROM USUARIOS WHERE CODIGO = '" + vuser + "' AND DPTO = '" + vclave + "' ", Form1.cn);
                    com.ExecuteNonQuery();
                    ur = com.ExecuteReader();
                    while (ur.Read())
                    {

                        uclave = Convert.ToString(ur["DPTO"]);
                        unombre = Convert.ToString(ur["NOMBRE"]);
                        ucodigo = Convert.ToString(ur["CODIGO"]);
                        uperfil = Convert.ToString(ur["CPERFIL"]);
                        ucaja = Convert.ToString(ur["CAJA"]);
                    }
                    ur.Close();
                    if (vclave.Trim() == uclave.Trim())
                    {
                        this.Close();
                    }
                    else
                    {
                        txtRut1.Text = "";
                        txtRut1.Focus();
                    }
                }
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            byte[] MisDatos = new byte[0];

            com.
        }
    }
}