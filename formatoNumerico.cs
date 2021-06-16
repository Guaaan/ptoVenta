using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptoVenta
{
    public class formatoNumerico
    {
        public void FormatoMoneda(TextBox xTBox)
        {
            if (xTBox.Text == string.Empty)
            {
                return;
            }
            else
            {
                decimal Monto;
                Monto = Convert.ToDecimal(xTBox.Text);
                xTBox.Text = Monto.ToString("N2");
            }
        }
    }
}
