using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AlquileresTemporarios_TP2LAB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sistema sistema;
        List<Propiedad> propiedadesMatch;

        string archivoInicial = Application.StartupPath + "\\sistema.bin";
        BinaryFormatter datosBinarios = new BinaryFormatter();
        private void Form1_Load(object sender, EventArgs e)
        {


            FileStream archivo = null;
            try
            {
                if (File.Exists(archivoInicial))
                {
                    archivo = new FileStream(archivoInicial, FileMode.Open, FileAccess.Read);
                    sistema = datosBinarios.Deserialize(archivo) as Sistema;
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (archivo != null) archivo.Close();
            }

            if (sistema == null)
                sistema = new Sistema();
        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (File.Exists(archivoInicial)) File.Delete(archivoInicial);
            FileStream archivo = null;

            try
            {
                archivo = new FileStream(archivoInicial, FileMode.Create, FileAccess.Write);
                datosBinarios.Serialize(archivo, sistema);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                if(archivo!=null) archivo.Close();
            }
           
        }


        private void fechaDesde_ValueChanged(object sender, EventArgs e)
        {
            fechaHasta.MinDate = fechaDesde.Value;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvPropiedades.Rows) { 
            dgvPropiedades.Rows.Remove(fila);
            }
            bool[] especificaciones = new bool[] { cbCochera.Checked, cbPileta.Checked, cbWifi.Checked, cbLimpieza.Checked, cbDesayuno.Checked, cbMascotas.Checked };
            string[] ubicaciones = new string[] { tbUbicacion.Text.ToUpper(), cbUbicacionBuscar.SelectedItem.ToString() };
            propiedadesMatch = sistema.ConsultarPropiedades(ubicaciones, fechaDesde.Value, fechaHasta.Value, Convert.ToInt32(nudCantPersonas.Value), especificaciones);
            for (int i = 0; i < propiedadesMatch.Count; i++)
            {
                DataGridViewRow fila = CrearFilaPropiedad(propiedadesMatch[i].ToString(), propiedadesMatch[i].Caracteristicas, propiedadesMatch[i].Ubicacion[0], propiedadesMatch[i].Descripcion, propiedadesMatch[i].CantPersonas.ToString(), propiedadesMatch[i].Precio.ToString("$0.00"));
                dgvPropiedades.Rows.Add(fila);
            }

        }

        //agregas las propiedades al dataGrid
        private DataGridViewRow CrearFilaPropiedad(string tipoPropiedad, bool[] caracteristicas, string ubicacion, string descripcion, string cantPersonas, string precio)
        {
            DataGridViewRow fila = new DataGridViewRow();
            string propCaracteristicas = "";
            for (int i = 0; i < caracteristicas.Length; i++)
            {
                if (caracteristicas[i])
                {
                    switch (i)
                    {
                        case 0:
                            propCaracteristicas += "Cochera \n";
                            break;
                        case 1:
                            propCaracteristicas += "Pileta \n";
                            break;
                        case 2:
                            propCaracteristicas += "Wi-Fi \n";
                            break;
                        case 3:
                            propCaracteristicas += "Limpieza \n";
                            break;
                        case 4:
                            propCaracteristicas += "Desayuno \n";
                            break;
                        case 5:
                            propCaracteristicas += "Mascotas \n";
                            break;
                    }
                }
            }
            string[] propiedadAtributos = { tipoPropiedad, propCaracteristicas, ubicacion, descripcion, cantPersonas, precio };
            for (int i = 0; i < 6; i++)
            {
                DataGridViewCell columna = new DataGridViewTextBoxCell();
                columna.Value = propiedadAtributos[i];
                fila.Cells.Add(columna);
            }
            fila.Height = 20;
            return fila;
        }

        private void btnAgregarPropiedad_Click(object sender, EventArgs e)
        {
            AgregarPropiedad modalAgregarPropiedad = new AgregarPropiedad();


            if (modalAgregarPropiedad.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int tipoPropiedad = modalAgregarPropiedad.cmbTipoPropiedad.SelectedIndex;
                    string[] ubicacion = { modalAgregarPropiedad.tbDireccion.Text.ToUpper(), modalAgregarPropiedad.tbLocalidad.Text.ToUpper(), modalAgregarPropiedad.cmbProvincias.SelectedItem.ToString() };
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
                            propiedad.AñadirImagenes(modalAgregarPropiedad.imagenesCargadas);
                                /*propiedad.AñadirImagenes(modalAgregarPropiedad.pbImagenPropiedad1.Image,
                                                        modalAgregarPropiedad.pbImagenPropiedad2.Image,
                                                        modalAgregarPropiedad.pbImagenPropiedad3.Image,
                                                        modalAgregarPropiedad.pbImagenPropiedad4.Image,
                                                        modalAgregarPropiedad.pbImagenPropiedad5.Image);*/
                            
                            sistema.AgregarHotel((HabitacionHotel)propiedad);

                           /* DataGridViewRow filaHotel = CrearFilaPropiedad("Hotel", caracteristicas, modalAgregarPropiedad.tbLocalidad.Text, modalAgregarPropiedad.tbDescripcion.Text, modalAgregarPropiedad.nudCantPersonas.Value.ToString(), ("$" + modalAgregarPropiedad.tbPrecioXNoche.Text));
                            dgvPropiedades.Rows.Add(filaHotel);*/
                            break;
                        case 1:
                            propiedad = new Casa(ubicacion, Convert.ToInt32(modalAgregarPropiedad.nudCantPersonas.Value),
                                        Convert.ToDouble(modalAgregarPropiedad.tbPrecioXNoche.Text), caracteristicas, modalAgregarPropiedad.tbDescripcion.Text, Convert.ToInt32(modalAgregarPropiedad.nudMinimoDias.Value));
                            propiedad.AñadirImagenes(modalAgregarPropiedad.imagenesCargadas);
                            /*propiedad.AñadirImagenes(modalAgregarPropiedad.pbImagenPropiedad1.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad2.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad3.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad4.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad5.Image);*/

                            sistema.AgregarCasa((Casa)propiedad);

                            /*DataGridViewRow filaCasa = CrearFilaPropiedad("Casa", caracteristicas, modalAgregarPropiedad.tbLocalidad.Text, modalAgregarPropiedad.tbDescripcion.Text, modalAgregarPropiedad.nudCantPersonas.Value.ToString(), ("$" + modalAgregarPropiedad.tbPrecioXNoche.Text));
                            dgvPropiedades.Rows.Add(filaCasa);*/
                            break;
                        case 2:
                            propiedad = new CasaFinde(ubicacion, Convert.ToInt32(modalAgregarPropiedad.nudCantPersonas.Value),
                                        Convert.ToDouble(modalAgregarPropiedad.tbPrecioXNoche.Text), caracteristicas, modalAgregarPropiedad.tbDescripcion.Text, Convert.ToInt32(modalAgregarPropiedad.nudMinimoDias.Value));
                            propiedad.AñadirImagenes(modalAgregarPropiedad.imagenesCargadas);
                            /*propiedad.AñadirImagenes(modalAgregarPropiedad.pbImagenPropiedad1.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad2.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad3.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad4.Image,
                                                    modalAgregarPropiedad.pbImagenPropiedad5.Image);*/

                            sistema.AgregarCasa((CasaFinde)propiedad);

                            /*DataGridViewRow filaCasaFinde = CrearFilaPropiedad("Casa finde", caracteristicas, modalAgregarPropiedad.tbLocalidad.Text.ToUpper(), modalAgregarPropiedad.tbDescripcion.Text, modalAgregarPropiedad.nudCantPersonas.Value.ToString(), ("$" + modalAgregarPropiedad.tbPrecioXNoche.Text));
                            dgvPropiedades.Rows.Add(filaCasaFinde);*/
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                    MessageBox.Show(ex.Message);
                }

            }
            cancelarReserva.Dispose();

        }



        private void dgvPropiedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VerPropiedad verPropiedad = new VerPropiedad();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPropiedades.Rows[e.RowIndex];

                verPropiedad.lbUbicacion.Text = row.Cells["ColUbicacion"].Value.ToString();
                verPropiedad.lbPrecio.Text = row.Cells["colPrecio"].Value.ToString();
                verPropiedad.tbDescripcion.Text = row.Cells["colDescripcion"].Value.ToString();
                switch (propiedadesMatch[e.RowIndex].ImagenPropiedad.Length)
                {
                    case 0:
                        break;
                    case 1:
                        verPropiedad.pbImagen1.Image = sistema.ListaPropiedades[e.RowIndex].ImagenPropiedad[0];
                        break;
                    case 2:
                        verPropiedad.pbImagen1.Image = sistema.ListaPropiedades[e.RowIndex].ImagenPropiedad[0];
                        verPropiedad.pbImagen2.Image = sistema.ListaPropiedades[e.RowIndex].ImagenPropiedad[1];
                        break;
                    case 3:
                        verPropiedad.pbImagen1.Image = sistema.ListaPropiedades[e.RowIndex].ImagenPropiedad[0];
                        verPropiedad.pbImagen2.Image = sistema.ListaPropiedades[e.RowIndex].ImagenPropiedad[1];
                        verPropiedad.pbImagen3.Image = sistema.ListaPropiedades[e.RowIndex].ImagenPropiedad[2];
                        break;
                    case 4:
                        verPropiedad.pbImagen1.Image = sistema.ListaPropiedades[e.RowIndex].ImagenPropiedad[0];
                        verPropiedad.pbImagen2.Image = sistema.ListaPropiedades[e.RowIndex].ImagenPropiedad[1];
                        verPropiedad.pbImagen3.Image = sistema.ListaPropiedades[e.RowIndex].ImagenPropiedad[2];
                        verPropiedad.pbImagen4.Image = sistema.ListaPropiedades[e.RowIndex].ImagenPropiedad[3];
                        break;
                    case 5:
                        verPropiedad.pbImagen1.Image = sistema.ListaPropiedades[e.RowIndex].ImagenPropiedad[0];
                        verPropiedad.pbImagen2.Image = sistema.ListaPropiedades[e.RowIndex].ImagenPropiedad[1];
                        verPropiedad.pbImagen3.Image = sistema.ListaPropiedades[e.RowIndex].ImagenPropiedad[2];
                        verPropiedad.pbImagen4.Image = sistema.ListaPropiedades[e.RowIndex].ImagenPropiedad[3];
                        verPropiedad.pbImagen5.Image = sistema.ListaPropiedades[e.RowIndex].ImagenPropiedad[4];
                        break;

                }

                /*verPropiedad.pbImagen1.
                verPropiedad.pbImagen1.
                verPropiedad.pbImagen1.
                verPropiedad.pbImagen1.*/

                string[] caracteristicas = row.Cells["colCaracteristicas"].Value.ToString().Split('\n');

                foreach (string c in caracteristicas)
                {
                    verPropiedad.lbCaracteristicas.Items.Add(c);

                }

            }

            if (verPropiedad.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se pudo!");
            }
            else verPropiedad.Dispose();
        }
    }
}
