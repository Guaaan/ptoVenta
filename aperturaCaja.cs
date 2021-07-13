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
    public partial class aperturaCaja : MaterialSkin.Controls.MaterialForm
    {
        public aperturaCaja()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue800, Primary.LightBlue400, Accent.LightBlue100, TextShade.WHITE);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if ((int)Convert.ToDouble(TextBox1.Text) > 0)
                {
                    Form1.montoape = (int)Convert.ToDouble(TextBox1.Text);
                    this.Close();
                }
            }
            if (e.KeyChar == 27)
            {
                this.Close();
            }
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
            }
        }

    }
}

