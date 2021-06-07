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
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelBuscarPersona.Visible = false;
        }
        private void hideBuscarPersona()
        {
            if (panelBuscarPersona.Visible == true)
                panelBuscarPersona.Visible = false;
        }
        private void showBuscarPersona()
        {
            if (panelBuscarPersona.Visible == false)
            {
                hideBuscarPersona();
                panelBuscarPersona.Visible = true;
            }
            else
                panelBuscarPersona.Visible = false;
        }
        private void btnDesplegarBuscar_Click(object sender, EventArgs e)
        {
            showBuscarPersona();
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
        private void btnExistenciaenLocales_Click_1(object sender, EventArgs e)
        {
            existenciaLocales abrirExistencia = new existenciaLocales();
            abrirExistencia.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            formClass abrirFormClass = new formClass();
            abrirFormClass.Show();
        }

        private void btnTicketsEmitidos_Click(object sender, EventArgs e)
        {
            ticketsEmitidos abrirTicketsEmitidos = new ticketsEmitidos();
            abrirTicketsEmitidos.Show();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            devoluciones abrirDevoluciones = new devoluciones();
            abrirDevoluciones.Show();
        }

        private void btnReciboIngreso_Click(object sender, EventArgs e)
        {
            ingresoCaja abrirIngreso = new ingresoCaja();
            abrirIngreso.Show();
        }

        private void btnEgresoCaja_Click(object sender, EventArgs e)
        {
            egresoCaja abrirEgreso = new egresoCaja();
            abrirEgreso.Show();
        }

        private void btnCargarPrecio_Click(object sender, EventArgs e)
        {
            cambiarPrecio abrirCambiarPrecio = new cambiarPrecio();
            abrirCambiarPrecio.Show();
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            sistema abrirSistema = new sistema();
            abrirSistema.Show();
        }

        private void btnAbrirCajon_Click(object sender, EventArgs e)
        {
            abrirCajon abrirClaveCajon = new abrirCajon();
            abrirClaveCajon.Show();
        }

        private void btnProductoFaltante_Click(object sender, EventArgs e)
        {
            productoFaltante abrirProductoFaltante = new productoFaltante();
            abrirProductoFaltante.Show();
        }

        private void btnDescripciónFarmacologica_Click(object sender, EventArgs e)
        {
            descripcionFarmacologica abrirDescripcionFarmacologica = new descripcionFarmacologica();
            abrirDescripcionFarmacologica.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ventas abrirVentas = new ventas();
            abrirVentas.Show();
        }

        private void btnProductosNoVendidos_Click(object sender, EventArgs e)
        {
            productosNoVendidos abrirProductosNoVendidos = new productosNoVendidos();
            abrirProductosNoVendidos.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar abrirBuscar = new Buscar();
            abrirBuscar.Show();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            existenciaLocales abrirExistencias = new existenciaLocales();
            abrirExistencias.Show();
        }
    }
}
