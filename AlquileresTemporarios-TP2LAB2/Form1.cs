﻿using System;
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
using System.Reflection;

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
            Splash splash = new Splash();
            splash.ShowDialog();

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
                        Propietario propietario;

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

                                    propietario = new Propietario(modalAgregarPropiedad.tbNombrePropietario.Text, Convert.ToInt32(modalAgregarPropiedad.tbDniPropietario.Text));

                                    propiedad = new Casa(ubicacion, Convert.ToInt32(modalAgregarPropiedad.nudCantPersonas.Value),
                                                Convert.ToDouble(modalAgregarPropiedad.tbPrecioXNoche.Text), caracteristicas, modalAgregarPropiedad.tbDescripcion.Text, Convert.ToInt32(modalAgregarPropiedad.nudMinimoDias.Value), propietario);
                                    propiedad.AñadirImagenes(modalAgregarPropiedad.imagenesCargadas);//Se podrían pasar las imagenes en el constructor

                                    sistema.AgregarCasa((Casa)propiedad);
                                    break;
                                case 2:
                                     propietario = new Propietario(modalAgregarPropiedad.tbNombrePropietario.Text, Convert.ToInt32(modalAgregarPropiedad.tbDniPropietario.Text));

                                    propiedad = new CasaFinde(ubicacion, Convert.ToInt32(modalAgregarPropiedad.nudCantPersonas.Value),
                                                Convert.ToDouble(modalAgregarPropiedad.tbPrecioXNoche.Text), caracteristicas, modalAgregarPropiedad.tbDescripcion.Text, Convert.ToInt32(modalAgregarPropiedad.nudMinimoDias.Value), propietario);
                                    propiedad.AñadirImagenes(modalAgregarPropiedad.imagenesCargadas);//Se podrían pasar las imagenes en el constructor

                                    sistema.AgregarCasa((CasaFinde)propiedad);
                                    break;
                            }
                        
                    }
                    catch (ArgumentNullException ex)
                    {
                        MessageBox.Show("Por favor, complete todos los campos.", ex.Message);
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
            modalAgregarPropiedad.Dispose();
        }

        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
            RegistrarCliente cancelarReserva = new RegistrarCliente();
            cancelarReserva.Text = "Eliminar reserva";
            cancelarReserva.lbNombre.Text = "Número de reserva";
            cancelarReserva.btnAceptar.Text = "Aceptar";
            try
            {
                if (cancelarReserva.ShowDialog() == DialogResult.OK)
                {
                    sistema.CancelarReserva(Convert.ToInt32(cancelarReserva.tbNombre.Text), Convert.ToInt32(cancelarReserva.tbDNI.Text));
                    MessageBox.Show("Se ha eliminado la reserva.");
                }
                                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
            cancelarReserva.Dispose();
        }

        private void dgvPropiedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VerPropiedad verPropiedad = new VerPropiedad();
            Propiedad propiedadConfirmar = null;
            if (e.RowIndex >= 0)
            {
                propiedadConfirmar = propiedadesMatch[e.RowIndex];
                RellenarVerPropiedad(verPropiedad, propiedadConfirmar);
            }
            bool salirVerPropiedad = false;
            while (!salirVerPropiedad) 
            {
                DialogResult result = verPropiedad.ShowDialog();
                if (result == DialogResult.OK)
                {                
                    RegistrarCliente registrarCliente = new RegistrarCliente();
                    Cliente cliente;
                    verPropiedad.Show();
                    bool salir = false;
                    
                    while (!salir)
                    {
                        try
                        {
                            if (registrarCliente.ShowDialog() == DialogResult.OK)
                            {
                                //// rellenar confirmacion modal
                                ConfirmacionReserva modalConfirmarReserva = new ConfirmacionReserva();
                                TimeSpan cantDias = fechaHasta.Value.AddHours(1) - fechaDesde.Value;
                                modalConfirmarReserva.lbDetallesReserva.Items.Add("Tipo de propiedad: " + propiedadConfirmar.ToString());
                                modalConfirmarReserva.lbDetallesReserva.Items.Add("Dirección: " + propiedadConfirmar.Ubicacion[0] + ", " + propiedadConfirmar.Ubicacion[1] + ", " + propiedadConfirmar.Ubicacion[2]);
                                if (propiedadConfirmar is HabitacionHotel)
                                {
                                    modalConfirmarReserva.lbDetallesReserva.Items.Add("Número de habitación: " + ((HabitacionHotel)propiedadConfirmar).NumHabitacion + ", tipo de habitación: " + ((HabitacionHotel)propiedadConfirmar).TipoHabitacion);
                                    modalConfirmarReserva.lbDetallesReserva.Items.Add("Cantidad de estrellas: " + ((HabitacionHotel)propiedadConfirmar).CantEstrellas);
                                }
                                modalConfirmarReserva.lbDetallesReserva.Items.Add("Cantidad de huespedes admitidos: " + propiedadConfirmar.CantPersonas);
                                modalConfirmarReserva.lbDetallesReserva.Items.Add("Reserva a nombre de: " + registrarCliente.tbNombre.Text + ", DNI: " + registrarCliente.tbDNI.Text);
                                modalConfirmarReserva.lbDetallesReserva.Items.Add("Fecha y hora de reserva: " + DateTime.Now.ToString());
                                modalConfirmarReserva.lbDetallesReserva.Items.Add("Ingreso el día: " + fechaDesde.Value.ToString());
                                modalConfirmarReserva.lbDetallesReserva.Items.Add("Salida el día: " + fechaHasta.Value.ToString());
                                modalConfirmarReserva.lbDetallesReserva.Items.Add("Precio por día: " + (propiedadConfirmar.CalcularPrecio(cantDias.Days) / cantDias.Days).ToString("$00.00"));
                                modalConfirmarReserva.lbDetallesReserva.Items.Add("Precio total: " + propiedadConfirmar.CalcularPrecio(cantDias.Days).ToString("$00.00"));
                                // fin rellenar confirmacion modal
                                DialogResult resultado = modalConfirmarReserva.ShowDialog();
                                if (resultado == DialogResult.OK)
                                {
                                    try
                                    {
                                        cliente = new Cliente(Convert.ToInt32(registrarCliente.tbDNI.Text), registrarCliente.tbNombre.ToString());
                                        //Hace la reserva
                                        int nroReserva = sistema.ReservarPropiedad(propiedadesMatch[e.RowIndex], cliente, fechaDesde.Value, fechaHasta.Value, Convert.ToInt32(nudCantPersonas.Value));
                                        MessageBox.Show("Se ha registrado el cliente con DNI: " + registrarCliente.tbDNI.Text.ToString() + " con éxito.\n[IMPORTANTE] Su numero de reserva es: " + nroReserva);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                                
                            }
                            salir = true;
                        }
                        catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        
                        
                        }
                    registrarCliente.Dispose();
                    salirVerPropiedad = true;
                    } else if ( result == DialogResult.Yes ) {
                        AgregarPropiedad modificarPropiedad = new AgregarPropiedad();
                        Propiedad propiedad = propiedadesMatch[e.RowIndex];
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
                        if(!(propiedad is HabitacionHotel)) 
                    { 
                        modificarPropiedad.tbNombrePropietario.Text = ((Casa)propiedad).Propietario.Nombre;
                        modificarPropiedad.tbDniPropietario.Text = ((Casa)propiedad).Propietario.Dni.ToString();
                        modificarPropiedad.gbPropietario.Enabled = false;
                    
                    }
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
                    salirVerPropiedad = true;

                }
                else if (result == DialogResult.Retry)
                {
                    Calendario calendario = new Calendario();
                    CompletarCalendario(calendario, propiedadConfirmar);
                    calendario.ShowDialog();
                    calendario.Dispose();
                }
                else if (result == DialogResult.No)
                {
                    DialogResult opcion = MessageBox.Show("¿Está seguro de que desea Eliminar la propiedad?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (opcion == DialogResult.Yes && sistema.EliminarPropiedad(propiedadesMatch[e.RowIndex]))
                    {
                        MessageBox.Show("La propiedad se eliminó con éxito.");
                        salirVerPropiedad = true;
                        dgvPropiedades.Rows.Clear();
                    }
                    else { MessageBox.Show("No se pudo eliminar la propiedad."); }
                } 
                else salirVerPropiedad = true;


            }
            verPropiedad.Dispose();
        }
        private void CompletarCalendario(Calendario calendario, Propiedad propiedad)
        {
            Application.EnableVisualStyles();
            List<DateTime> fechas = new List<DateTime>();
            foreach (Reserva reserva in propiedad.Reservas)
            {
                for (DateTime i = reserva.FechaInicio; i <= reserva.FechaFin; i = i.AddDays(1))
                {
                    fechas.Add(i);
                }
                calendario.mcCalendario.BoldedDates = fechas.ToArray();
            }
        }

        private bool RellenarVerPropiedad(VerPropiedad modal, Propiedad propiedad)
        {
            PictureBox[] listaPBmodal = new PictureBox[] {modal.pbImagen1, modal.pbImagen2, modal.pbImagen3, modal.pbImagen4, modal.pbImagen5 };
            bool exito = false;
            //Agregamos una hora ya que cuando hacemos 2 días nos lo toma como 1 día y 59 minutos
            TimeSpan cantDias = fechaHasta.Value.AddHours(1) - fechaDesde.Value;
            if (propiedad != null)
            {
                for (int i = 0; i < propiedad.ImagenPropiedad.Length; i++)
                {
                    listaPBmodal[i].Image = propiedad.ImagenPropiedad[i];
                }
                if(propiedad is HabitacionHotel)
                {
                    modal.lbCantEstrellas.Text = ((HabitacionHotel)propiedad).CantEstrellas.ToString();
                    modal.lbTipoHab.Text= ((HabitacionHotel)propiedad).TipoHabitacion.ToString();
                }
                else
                {
                    modal.lbCantEstrellas.Visible = false;
                    modal.lbTipoHab.Visible = false;
                    modal.lbHabitacion.Visible = false;
                }
                modal.Text = propiedad.ToString();
                modal.tbDescripcion.Text = propiedad.Descripcion;
                modal.lbPrecioFinal.Text = propiedad.CalcularPrecio(cantDias.Days).ToString("$0.00");
                modal.lbPrecioPorDia.Text = (propiedad.CalcularPrecio(cantDias.Days) / (cantDias.Days)).ToString("$0.00");///propiedad.Precio.ToString("$0.00");
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
            modal.Text = "Consultar reserva";
            modal.tbDNI.Visible= false;
            modal.label2.Visible = false;
            modal.lbNombre.Text = "Número de reserva";
            modalPropiedad.btnModificar.Visible = false;
            modalPropiedad.btnReservar.Visible = false;
            modalPropiedad.btnEliminarPropiedad.Visible = false;
            try
            {
                DialogResult resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {

                    if (modal.tbNombre.Text.Length > 0)
                    {
                        sistema.ConsultarReserva(Convert.ToInt32(modal.tbNombre.Text), out propiedad);


                        if (RellenarVerPropiedad(modalPropiedad, propiedad))
                        {
                            modalPropiedad.ShowDialog();
                        }
                    }


                } 
                
            } 
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        

        private void btnImportarReservas_Click(object sender, EventArgs e)
        {
           /* OpenFileDialog ofd = new OpenFileDialog();
            FileStream archivo;
            StreamReader sr;
            int cantReservas = 0;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    archivo = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(archivo);

                    string[] linea = sr.ReadLine().Split(';');
                    while (linea != null)
                    {
                        

                        linea = sr.ReadLine().Split(';');
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/            
        }
    }
    }

