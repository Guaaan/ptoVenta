using MaterialSkin;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ptoVenta
{
    public partial class Reporte : MaterialSkin.Controls.MaterialForm
    {
        public Reporte()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue800, Primary.LightBlue400, Accent.LightBlue100, TextShade.WHITE);
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            this.reportViewer.RefreshReport();

            //Array que contendrá los parámetros
            ReportParameter[] parameters = new ReportParameter[2];
            //Establecemos el valor de los parámetros
            parameters[0] = new ReportParameter("par0", "value_par0");
            parameters[1] = new ReportParameter("par1", "value_par1");
            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer.LocalReport.SetParameters(parameters);
            this.reportViewer.RefreshReport();
        }
    }
}
