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
            //customizeDesign();
        }

        //abrir dropdown grande tipo panel
        /*private void customizeDesign()
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
        }*/
        
        
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

        
    }
}
