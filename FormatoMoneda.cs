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
    public partial class FormatoMoneda : Form
    {
        public FormatoMoneda()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.IdProducto = int.Parse(txtId.Text);
            productos.Nombre = txtNombre.Text;
            productos.Precio = double.Parse(txtPrecio.Text);
        }
    }
}
