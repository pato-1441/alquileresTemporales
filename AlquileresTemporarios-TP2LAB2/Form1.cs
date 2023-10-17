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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sistema sistema;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            sistema = new Sistema();            
        }

        private void fechaDesde_ValueChanged(object sender, EventArgs e)
        {
            fechaHasta.MinDate = fechaDesde.Value;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarPropiedad_Click(object sender, EventArgs e)
        {
            AgregarPropiedad modalAgregarPropiedad = new AgregarPropiedad();
            bool exito = false;
           

            if (modalAgregarPropiedad.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int tipoPropiedad = modalAgregarPropiedad.cmbTipoPropiedad.SelectedIndex;
                string[] ubicacion = { modalAgregarPropiedad.tbDireccion.Text, modalAgregarPropiedad.tbLocalidad.Text, modalAgregarPropiedad.cmbProvincias.SelectedItem.ToString() };
                bool[] caracteristicas = {modalAgregarPropiedad.cbCochera.Checked, modalAgregarPropiedad.cbPileta.Checked,
                                                  modalAgregarPropiedad.cbWifi.Checked, modalAgregarPropiedad.cbLimpieza.Checked,
                                                  modalAgregarPropiedad.cbDesayuno.Checked, modalAgregarPropiedad.cbMascotas.Checked};

                Propiedad propiedad;

                
                    switch (tipoPropiedad)
                    {
                        case 0:
                            propiedad = new HabitacionHotel(ubicacion, Convert.ToInt32(modalAgregarPropiedad.nudCantPersonas.Value),
                                            Convert.ToDouble(modalAgregarPropiedad.tbPrecioXNoche.Text), caracteristicas, modalAgregarPropiedad.tbDescripcion.Text, modalAgregarPropiedad.tbNombreHotel.Text,
                                            Convert.ToInt32(modalAgregarPropiedad.tbNumHabitacion.Text), Convert.ToInt32(modalAgregarPropiedad.cmbTipoHabitacion.SelectedIndex),
                                            Convert.ToInt32((modalAgregarPropiedad.cmbCantEstrellas.SelectedIndex)) + 2);
                            propiedad.AñadirImagenes(modalAgregarPropiedad.pbImagenPropiedad1.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad2.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad3.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad4.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad5.Image);
                            sistema.AgregarHotel((HabitacionHotel)propiedad);
                            dgvPropiedades.Columns.Add("colImagen", "Imagen");
                            dgvPropiedades.Columns[0].Width = 50;
                            dgvPropiedades.Rows.Add(propiedad.ImagenPropiedad[0]);
                            break;
                        case 1:
                            propiedad = new Casa(ubicacion, Convert.ToInt32(modalAgregarPropiedad.nudCantPersonas.Value),
                                        Convert.ToDouble(modalAgregarPropiedad.tbPrecioXNoche.Text), caracteristicas, modalAgregarPropiedad.tbDescripcion.Text, Convert.ToInt32(modalAgregarPropiedad.nudMinimoDias.Value));
                            propiedad.AñadirImagenes(modalAgregarPropiedad.pbImagenPropiedad1.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad2.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad3.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad4.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad5.Image);
                            sistema.AgregarCasa((Casa)propiedad);
                            dgvPropiedades.Columns.Add("colImagen", "Imagen");
                            dgvPropiedades.Columns[0].Width = 150;

                            dgvPropiedades.Rows.Add(propiedad.ImagenPropiedad[0]);
                            break;
                        case 2:
                            propiedad = new CasaFinde(ubicacion, Convert.ToInt32(modalAgregarPropiedad.nudCantPersonas.Value),
                                        Convert.ToDouble(modalAgregarPropiedad.tbPrecioXNoche.Text), caracteristicas, modalAgregarPropiedad.tbDescripcion.Text, Convert.ToInt32(modalAgregarPropiedad.nudMinimoDias.Value));
                            propiedad.AñadirImagenes(modalAgregarPropiedad.pbImagenPropiedad1.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad2.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad3.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad4.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad5.Image);
                            sistema.AgregarCasa((CasaFinde)propiedad);

                            DataGridViewRow fila = new DataGridViewRow();
                            DataGridViewImageCell columna = new DataGridViewImageCell();
                            columna.Value = propiedad.ImagenPropiedad[0];
                            fila.Cells.Add(columna);
                            dgvPropiedades.Rows.Add(fila);

                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                }
            
            }
        }

        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
        RegistrarCliente cancelarReserva = new RegistrarCliente();
         cancelarReserva.Text = "Cancelar Reserva";
         cancelarReserva.lbNombre.Text = "Número Reserva";
         cancelarReserva.button1.Text = "Aceptar";
         if (cancelarReserva.ShowDialog() == DialogResult.OK)
         {
             try
             {
                 sistema.CancelarReserva(Convert.ToInt32(cancelarReserva.tbNombre), Convert.ToInt32(cancelarReserva.tbDNI));
             }
             catch (Exception ex)
             {
                    MessageBox.Show("No se pudo realizar.");
             }

         }
         cancelarReserva.Dispose();

        }


    }
}
