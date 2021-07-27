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
using Microsoft.Reporting.WinForms;

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

        
    }
}
