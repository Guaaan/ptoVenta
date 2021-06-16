using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//no hay gran cosa que importar aqui, si no me equivoco el único import que no trae por defecto es el de abajo
using System.Windows.Forms;

namespace ptoVenta
{
    public partial class AgregarFoto : Form
    {
        public AgregarFoto()
        {
            InitializeComponent();
        }
        private void AgregarFoto_Load(object sender, EventArgs e)
        {
            dgvFoto.DataSource = ClsConexiones.EjecutarQuery("select * from usuario", ptbImagen.Image);
            int cont = dgvFoto.RowCount;
            for (int i = 0; i < cont; i++)
            {
                dgvFoto.Rows[i].Height = 120;
            }
        }
        public void btnGuardar_Click(object sender, EventArgs e)
        {
            ClsConexiones.EjecutarQuery("INSERT INTO `db_imagen`.`imagen` (`idImagen`, `Nombre`, `Imagen`) VALUES (@Imagen)", ptbImagen.Image);


            dgvFoto.DataSource = ClsConexiones.EjecutarQuery("select * from imagen", ptbImagen.Image);
            int cont = dgvFoto.RowCount;
            for (int i = 0; i < cont; i++)
            {
                dgvFoto.Rows[i].Height = 120;
            }
        }

        public OpenFileDialog examinar = new OpenFileDialog();
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            examinar.Filter = "image files|*.jpg; *.png;";
            DialogResult r = examinar.ShowDialog();
            if (r == DialogResult.Abort)
            {
                return;
            }
            if (r == DialogResult.Cancel)
            {
                return;
            }
            
            ptbImagen.Image = Image.FromFile(examinar.FileName);
        }

        
    }
}
