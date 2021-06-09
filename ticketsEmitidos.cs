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
    public partial class ticketsEmitidos : Form
    {
        public ticketsEmitidos()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            calendarioTicketsE abrirCalendarioTickets = new calendarioTicketsE();
            abrirCalendarioTickets.Show();
        }
    }
}
