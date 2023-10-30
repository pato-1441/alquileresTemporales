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
        public int cantImagenesCargadas = 0;
        public List<Image> imagenesCargadas=new List<Image>();
        
        private void cbTipoPropiedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPropiedad.SelectedIndex == 0)
            {
                gbCasa.Enabled = false;
                gbHotel.Enabled = true;
                cbDesayuno.Enabled = false;
                cbDesayuno.Checked = true;
                gbPropietario.Enabled = false;

            } else if (cmbTipoPropiedad.SelectedIndex == 1)
            {
                gbHotel.Enabled = false;
                gbCasa.Enabled = true;
                cbDesayuno.Enabled = true;
                cbDesayuno.Checked = false;
                gbPropietario.Enabled = true;
            }
            else
            {
                gbHotel.Enabled = false;
                gbCasa.Enabled = false;
                cbDesayuno.Enabled = true;
                cbDesayuno.Checked = false;
                gbPropietario.Enabled = true;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cantImagenesCargadas <= 0 || cantImagenesCargadas > 5)
            {
                this.DialogResult = DialogResult.Abort;
            }
            else
            {
                foreach (Object obj in this.Controls)
                {
                    if (obj is ComboBox && ((ComboBox)obj).Enabled == true && ((ComboBox)obj).SelectedIndex < 0)
                    {
                        this.DialogResult = DialogResult.Abort;
                    }
                    else if (obj is TextBox && ((TextBox)obj).Enabled == true && ((TextBox)obj).Text == "")
                    {
                        this.DialogResult = DialogResult.Abort;
                    }
                    else if (obj is GroupBox && ((GroupBox)obj).Enabled == true)
                    {
                        foreach (Object obj2 in ((GroupBox)obj).Controls)
                        {
                            if (obj2 is ComboBox && ((ComboBox)obj2).Enabled == true && ((ComboBox)obj2).SelectedIndex < 0)
                            {
                                this.DialogResult = DialogResult.Abort;
                            }
                            else if (obj2 is TextBox && ((TextBox)obj2).Enabled == true && ((TextBox)obj2).Text == "")
                            {
                                this.DialogResult = DialogResult.Abort;
                            }
                        }
                    }
                }
            }
        }
    }
}
