using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquileresTemporarios_TP2LAB2
{
    public partial class AgregarPropiedad : Form
    {
        public AgregarPropiedad()
        {
            InitializeComponent();
        }

        private void cbTipoPropiedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPropiedad.SelectedIndex == 0)
            {
                gbCasa.Enabled = false;
                gbHotel.Enabled = true;
                cbDesayuno.Enabled = false;
                cbDesayuno.Checked = true;

            } else if (cmbTipoPropiedad.SelectedIndex == 1 || cmbTipoPropiedad.SelectedIndex == 2)
            {
                gbHotel.Enabled = false;
                gbCasa.Enabled = true;
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImagen = new OpenFileDialog();
            if (ofdImagen.ShowDialog() == DialogResult.OK)
            {
                pbImagenPropiedad.Image = Image.FromFile(ofdImagen.FileName);
            }
        }
    }
}
