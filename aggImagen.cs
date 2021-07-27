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
    public partial class aggImagen : MaterialSkin.Controls.MaterialForm
    {

        public aggImagen()
        {
            InitializeComponent();
            
        }

        public void aggImagen_Load(object sender, EventArgs e)
        {
            string Fabian = "Fabian";
            string Hugo = "Hugo";
            string Alejandro = "Alejandro";


            cbListaFotos.Items.Add(Fabian);
            cbListaFotos.Items.Add(Hugo);
            cbListaFotos.Items.Add(Alejandro);
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFile.ShowDialog();
                if (this.openFile.FileName.Equals("") == false)
                {
                    pictureBox.Load(this.openFile.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbListaFotos.SelectedIndex == 1)
            {
                //pictureBox.Image =
            }
            


        }
    }
}
