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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alternarColorData(dgvLista);
        }
        public void alternarColorData(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void btnTicketsEmitidos_Click(object sender, EventArgs e)
        {
            ticketsEmitidos abrirTicketsE = new ticketsEmitidos();
            abrirTicketsE.Show();

        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            devoluciones abrirDevoluciones = new devoluciones();
            abrirDevoluciones.Show();
        }

        private void btnRdeIngreso_Click(object sender, EventArgs e)
        {
            ingresoCaja abrirIngreso = new ingresoCaja();
            abrirIngreso.Show();
        }

        private void btnEgresoCaja_Click(object sender, EventArgs e)
        {
            egresoCaja abrirEgreso = new egresoCaja();
            abrirEgreso.Show();
        }

        private void btnCambiarPrecio_Click(object sender, EventArgs e)
        {
            cambiarPrecio abrirCambiarPrecio = new cambiarPrecio();
            abrirCambiarPrecio.Show();
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            sistema abrirSistema = new sistema();
            abrirSistema.Show();
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDescripcionFarmacologica_Click(object sender, EventArgs e)
        {
            descripcionFarmacologica abrirDescripción = new descripcionFarmacologica();
            abrirDescripción.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar abrirBuscar = new Buscar();
            abrirBuscar.Show();
        }

        private void btnProductoFaltante_Click(object sender, EventArgs e)
        {
            productoFaltante abrirProductoFaltante = new productoFaltante();
            abrirProductoFaltante.Show();
        }

        private void btnProductosnoVendidos_Click(object sender, EventArgs e)
        {
            productosNoVendidos abrirNoVendidos = new productosNoVendidos();
            abrirNoVendidos.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ventas abrirVentas = new ventas();
            abrirVentas.Show();
        }
        private void btnExistenciaenLocales_Click_1(object sender, EventArgs e)
        {
            existenciaLocales abrirExistencia = new existenciaLocales();
            abrirExistencia.Show();
        }
    }
}
