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
            int cantFilas = dgvPropiedades.Rows.Count;
            for (int i =0;i< cantFilas;i++) {
                dgvPropiedades.Rows.Remove(dgvPropiedades.Rows[0]);
            }
            bool[] especificaciones = new bool[] { cbCochera.Checked, cbPileta.Checked, cbWifi.Checked, cbLimpieza.Checked, cbDesayuno.Checked, cbMascotas.Checked };
            string provincia = null;
            if (cbUbicacionBuscar.SelectedItem != null)
                provincia = cbUbicacionBuscar.SelectedItem.ToString();
            string[] ubicaciones = new string[] { tbUbicacion.Text.ToUpper(), provincia };
            propiedadesMatch = sistema.ConsultarPropiedades(ubicaciones, fechaDesde.Value, fechaHasta.Value, Convert.ToInt32(nudCantPersonas.Value), especificaciones);
            foreach (Propiedad propiedad in propiedadesMatch)
            {
                DataGridViewRow fila = CrearFilaPropiedad(propiedad.ToString(), propiedad.Caracteristicas, propiedad.Ubicacion[0], propiedad.Descripcion, propiedad.CantPersonas.ToString(), propiedad.Precio.ToString("$0.00"));
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
                            propiedad.AñadirImagenes(modalAgregarPropiedad.imagenesCargadas);//Se podrían pasar las imagenes en el constructor
                            
                            sistema.AgregarHotel((HabitacionHotel)propiedad);
                            break;
                        case 1:
                            propiedad = new Casa(ubicacion, Convert.ToInt32(modalAgregarPropiedad.nudCantPersonas.Value),
                                        Convert.ToDouble(modalAgregarPropiedad.tbPrecioXNoche.Text), caracteristicas, modalAgregarPropiedad.tbDescripcion.Text, Convert.ToInt32(modalAgregarPropiedad.nudMinimoDias.Value));
                            propiedad.AñadirImagenes(modalAgregarPropiedad.imagenesCargadas);//Se podrían pasar las imagenes en el constructor

                            sistema.AgregarCasa((Casa)propiedad);
                            break;
                        case 2:
                            propiedad = new CasaFinde(ubicacion, Convert.ToInt32(modalAgregarPropiedad.nudCantPersonas.Value),
                                        Convert.ToDouble(modalAgregarPropiedad.tbPrecioXNoche.Text), caracteristicas, modalAgregarPropiedad.tbDescripcion.Text, Convert.ToInt32(modalAgregarPropiedad.nudMinimoDias.Value));
                            propiedad.AñadirImagenes(modalAgregarPropiedad.imagenesCargadas);//Se podrían pasar las imagenes en el constructor

                            sistema.AgregarCasa((CasaFinde)propiedad);
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
            cancelarReserva.btnAceptar.Text = "Aceptar";
            if (cancelarReserva.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sistema.CancelarReserva(Convert.ToInt32(cancelarReserva.tbNombre.Text), Convert.ToInt32(cancelarReserva.tbDNI.Text));
                    MessageBox.Show("Se ha eliminado la reserva.");                    
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
                RellenarVerPropiedad(verPropiedad, propiedadesMatch[e.RowIndex]);
            }

            if (verPropiedad.ShowDialog() == DialogResult.OK)
            {
                
                RegistrarCliente registrarCliente = new RegistrarCliente();
                Cliente cliente;
                verPropiedad.Show();
                if(registrarCliente.ShowDialog() == DialogResult.OK)
                {
                    DialogResult resultado = MessageBox.Show("Seguro que desea reservar?", "Confirmación",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {
                            cliente = new Cliente(Convert.ToInt32(registrarCliente.tbDNI.Text), registrarCliente.tbNombre.ToString());
                            int nroReserva = sistema.ReservarPropiedad(propiedadesMatch[e.RowIndex], cliente, fechaDesde.Value, fechaHasta.Value, Convert.ToInt32(nudCantPersonas.Value));
                            MessageBox.Show("Se ha registrado el cliente con DNI: " + registrarCliente.tbDNI.Text.ToString() + " con éxito.\n[IMPORTANTE] Su numero de reserva es: "+ nroReserva);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                registrarCliente.Dispose();
            }
            verPropiedad.Dispose();
        }

        private bool RellenarVerPropiedad(VerPropiedad modal, Propiedad propiedad)
        {
            PictureBox[] listaPBmodal = new PictureBox[] {modal.pbImagen1, modal.pbImagen2, modal.pbImagen3, modal.pbImagen4, modal.pbImagen5 };
            bool exito = false;
            for(int i = 0; i < propiedad.ImagenPropiedad.Length; i++)
            {
                listaPBmodal[i].Image = propiedad.ImagenPropiedad[i];
            }
            if (propiedad != null)
            {
                modal.tbDescripcion.Text = propiedad.Descripcion;
                modal.lbPrecio.Text = propiedad.Precio.ToString();
                modal.lbUbicacion.Text = propiedad.Ubicacion[0] + ", " + propiedad.Ubicacion[1] + ", " + propiedad.Ubicacion[2];
                string[] enumerador = new string[] { "Cochera", "Pileta", "Wi-Fi", "Limpieza", "Desayuno", "Mascotas" };
                for (int i = 0; i < propiedad.Caracteristicas.Length; i++)
                {
                    if (propiedad.Caracteristicas[i])
                        modal.lbCaracteristicas.Items.Add(enumerador[i]);
                }
                exito = true;
            }
            else throw new Exception("No existe una reserva con ese número.");
            return exito;
        }

        private void btnConsultarReserva_Click(object sender, EventArgs e)
        {
            RegistrarCliente modal = new RegistrarCliente();
            VerPropiedad modalPropiedad = new VerPropiedad();
            Propiedad propiedad = null;
            modal.tbDNI.Visible= false;
            modal.label2.Visible = false;
            modal.lbNombre.Text = "Número de reserva";
            if (modal.ShowDialog() == DialogResult.OK)
            {
                sistema.ConsultarReserva(Convert.ToInt32(modal.tbNombre.Text), out propiedad);
                try
                {
                    if (RellenarVerPropiedad(modalPropiedad, propiedad))
                    {
                        modalPropiedad.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("No se pudo encontrar una reserva.");
            }
        }
    }

