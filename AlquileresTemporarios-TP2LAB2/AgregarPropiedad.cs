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
        int cantImagenesCargadas = 0;
        public List<Image> imagenesCargadas=new List<Image>();
        
        private void cbTipoPropiedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPropiedad.SelectedIndex == 0)
            {
                gbCasa.Enabled = false;
                gbHotel.Enabled = true;
                cbDesayuno.Enabled = false;
                cbDesayuno.Checked = true;

            } else if (cmbTipoPropiedad.SelectedIndex == 1)
            {
                gbHotel.Enabled = false;
                gbCasa.Enabled = true;
                cbDesayuno.Enabled = true;
                cbDesayuno.Checked = false;
            }
            else
            {
                gbHotel.Enabled = false;
                gbCasa.Enabled = false;
                cbDesayuno.Enabled = true;
                cbDesayuno.Checked = false;
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImagen = new OpenFileDialog();
            if (ofdImagen.ShowDialog() == DialogResult.OK)
            {
                switch (cantImagenesCargadas)
                {
                    case 0:
                        pbImagenPropiedad1.Image = Image.FromFile(ofdImagen.FileName);
                        imagenesCargadas.Add(Image.FromFile(ofdImagen.FileName));
                        cantImagenesCargadas++;
                        break;
                    case 1:
                        pbImagenPropiedad2.Image = Image.FromFile(ofdImagen.FileName);
                        imagenesCargadas.Add(Image.FromFile(ofdImagen.FileName));
                        cantImagenesCargadas++;
                        break;
                    case 2:
                        pbImagenPropiedad3.Image = Image.FromFile(ofdImagen.FileName);
                        imagenesCargadas.Add(Image.FromFile(ofdImagen.FileName));
                        cantImagenesCargadas++;
                        break;
                    case 3:
                        pbImagenPropiedad4.Image = Image.FromFile(ofdImagen.FileName);
                        imagenesCargadas.Add(Image.FromFile(ofdImagen.FileName));
                        cantImagenesCargadas++;
                        break;
                    case 4:
                        pbImagenPropiedad5.Image = Image.FromFile(ofdImagen.FileName);
                        imagenesCargadas.Add(Image.FromFile(ofdImagen.FileName));
                        cantImagenesCargadas++;
                        btnSeleccionarImagen.Enabled = false;
                        break;
                }
                
            }
        }
    }
}
