using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquileresTemporarios_TP2LAB2
{
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "") throw new Exception("No se completaron los datos");

            if (tbDNI.Visible) { 
                if (tbDNI.Text == "") throw new Exception("No se completaron los datos");

                Regex verificarDni = new Regex(@"^[0-9]{8}$");
                if (!verificarDni.IsMatch(tbDNI.Text.ToString())) throw new Exception("El DNI no es válido");
            }
        }
    }
}
