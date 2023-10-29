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
using System.Xml.XPath;

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

            fechaHasta.MinDate = fechaDesde.Value.AddDays(1);
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
            fechaHasta.MinDate = fechaDesde.Value.AddDays(1);
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
            bool salir = false;
            while (!salir)
            {
                DialogResult resultado = modalAgregarPropiedad.ShowDialog();
                if (resultado == DialogResult.OK)
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
                    catch (ArgumentNullException ex)
                    {
                        MessageBox.Show("Por favor, complete todos los campos.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        
                    }
                    salir = true;
                }
                else if (resultado == DialogResult.Abort)
                {
                    MessageBox.Show("No se completaron todos los campos.");
                }else if(resultado == DialogResult.Cancel)
                {
                    salir = true;
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
            DialogResult result = verPropiedad.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                    RegistrarCliente registrarCliente = new RegistrarCliente();
                    Cliente cliente;
                    verPropiedad.Show();
                    if (registrarCliente.ShowDialog() == DialogResult.OK)
                    {
                        DialogResult resultado = MessageBox.Show("Seguro que desea reservar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            try
                            {
                                cliente = new Cliente(Convert.ToInt32(registrarCliente.tbDNI.Text), registrarCliente.tbNombre.ToString());
                                int nroReserva = sistema.ReservarPropiedad(propiedadesMatch[e.RowIndex], cliente, fechaDesde.Value, fechaHasta.Value, Convert.ToInt32(nudCantPersonas.Value));
                                MessageBox.Show("Se ha registrado el cliente con DNI: " + registrarCliente.tbDNI.Text.ToString() + " con éxito.\n[IMPORTANTE] Su numero de reserva es: " + nroReserva);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    registrarCliente.Dispose();
                }else if(result== DialogResult.Yes)
                        {
                AgregarPropiedad modificarPropiedad = new AgregarPropiedad();
                Propiedad propiedad = sistema.ListaPropiedades[e.RowIndex];
                int tipoPropiedad;
                if (propiedad.ToString() == "Hotel") tipoPropiedad = 0;
                else if (propiedad.ToString() == "Casa") tipoPropiedad = 1;
                else tipoPropiedad = 2;
                foreach(object obj in modificarPropiedad.Controls)
                {
                    if (obj is ComboBox) ((ComboBox)obj).Enabled = false;
                    else if(obj is TextBox) ((TextBox)obj).Enabled = false;
                }
                modificarPropiedad.cmbTipoPropiedad.Text = propiedad.ToString();
                modificarPropiedad.cmbProvincias.Text = propiedad.Ubicacion[2];
                modificarPropiedad.tbLocalidad.Text = propiedad.Ubicacion[1];
                modificarPropiedad.tbDireccion.Text = propiedad.Ubicacion[0];
                modificarPropiedad.nudCantPersonas.Value = propiedad.CantPersonas;
                modificarPropiedad.tbPrecioXNoche.Enabled = true;
                modificarPropiedad.tbPrecioXNoche.Text= propiedad.Precio.ToString("0.00");
                if (tipoPropiedad == 1)
                {
                    modificarPropiedad.gbCasa.Enabled = true;
                    modificarPropiedad.nudMinimoDias.Value = ((Casa)propiedad).MinimoDias;
                }
                modificarPropiedad.tbDescripcion.Enabled = true;
                modificarPropiedad.tbDescripcion.Text = propiedad.Descripcion;
                modificarPropiedad.cantImagenesCargadas = propiedad.ImagenPropiedad.Count();
                modificarPropiedad.btnSeleccionarImagen.Enabled = false;
                bool salir = false;

                while (!salir) 
                {
                    DialogResult resultadoValidacion = modificarPropiedad.ShowDialog();
                    if (resultadoValidacion == DialogResult.OK)
                    {
                        bool[] nuevasCaracteristicas = new bool[] { modificarPropiedad.cbCochera.Checked, modificarPropiedad.cbPileta.Checked, modificarPropiedad.cbWifi.Checked, modificarPropiedad.cbLimpieza.Checked, modificarPropiedad.cbDesayuno.Checked, modificarPropiedad.cbMascotas.Checked };
                        try
                        {
                            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea modificar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (resultado == DialogResult.Yes)
                            {
                                sistema.ModificarPropiedad(propiedad, Convert.ToDouble(modificarPropiedad.tbPrecioXNoche.Text), modificarPropiedad.tbDescripcion.Text, nuevasCaracteristicas, Convert.ToInt32(modificarPropiedad.nudCantPersonas.Value), Convert.ToInt32(modificarPropiedad.nudMinimoDias.Value));
                                dgvPropiedades.Rows.Clear();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally { salir= true;}

                    }
                    else if (resultadoValidacion == DialogResult.Abort)
                    {
                        MessageBox.Show("Por favor, complete todos los campos.");
                    }else { salir= true;}
                }
                
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
                modal.Text = propiedad.ToString();
                modal.tbDescripcion.Text = propiedad.Descripcion;
                modal.lbPrecio.Text = propiedad.Precio.ToString("$0.00");
                string[] direccion = propiedad.Ubicacion[0].Split(' ');
                string direccionFinal = "";
                foreach (string dir in direccion)
                    direccionFinal += dir[0].ToString().ToUpper() + dir.Substring(1).ToLower() + " ";
                string ciudad = propiedad.Ubicacion[1].ToLower();
                modal.lbUbicacion.Text = direccionFinal.Substring(0, direccionFinal.Length - 1) + ", " + ciudad[0].ToString().ToUpper() + ciudad.Substring(1) + ", " + propiedad.Ubicacion[2];
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
            modalPropiedad.btnModificar.Visible = false;
            modalPropiedad.btnReservar.Visible = false;
            if (modal.ShowDialog() == DialogResult.OK)
            {
                sistema.ConsultarReserva(Convert.ToInt32(modal.tbNombre.Text), out propiedad);
                try
                {
                    if (RellenarVerPropiedad(modalPropiedad, propiedad))
                    {
                        modalPropiedad.ShowDialog();
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

