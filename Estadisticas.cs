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
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
        public Estadisticas(Bitmap bitmap)
        {
            this.bitmap = bitmap;
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (bitmap != null)
            {
                e.Graphics.DrawImage(this.bitmap, 0, 0);
                
            }
        }
    }
}
