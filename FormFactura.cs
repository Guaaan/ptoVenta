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
    public partial class FormFactura : MaterialSkin.Controls.MaterialForm
    {
        public FormFactura()
        {
            InitializeComponent();
        }

        private void btn_Cobrar_Click(object sender, EventArgs e)
        {
            LocalReport localReport = new LocalReport();
            localReport.ReportPath = Application.StartupPath + "\\Reportes.rdlc";
            localReport.PrintToPrinter();
        }
    }
}
