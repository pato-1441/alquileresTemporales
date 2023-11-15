using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.XPath;
using System.Reflection;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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
        VerPropiedad verPropiedad;
        ConfirmacionReserva modalConfirmarReserva;
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
            ssLFechaInicio.Text = DateTime.Today.ToShortDateString();
            ssInicio.Items[1].Alignment = (ToolStripItemAlignment)1;

            //Gestion de Usuarios

            InicioSesion inicio = new InicioSesion();
            FileStream archivoUsuarios = null;
            StreamReader sr = null;
            bool usuarioCorrecto = false;
            string tipo = null;
            string ruta = Application.StartupPath + "/usuarios.txt";
            try
            {
                while (!usuarioCorrecto)
                {
                    archivoUsuarios = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(archivoUsuarios);
                    string lineaEntera = sr.ReadLine();
                    string[] linea;
                
                    inicio.tbContraseña.Text = "";
                    if (inicio.ShowDialog() == DialogResult.OK)
                    {
                        while (lineaEntera != null && usuarioCorrecto == false)
                        {
                            linea = lineaEntera.Split(';');
                            if (linea[0] == inicio.tbNombreUsuario.Text && linea[1] == inicio.tbContraseña.Text)
                            {
                                usuarioCorrecto = true;
                                tipo = linea[2];
                            }

                            lineaEntera = sr.ReadLine();

                        }
                        if (usuarioCorrecto)
                        {
                            if (tipo != "administrador")
                            {
                                EsEmpleado();
                            }
                            else sslInicio.Text += ": Administrador";
                        }
                        else MessageBox.Show("Usuario o contraseña incorrectos");

                    }
                    else Close();
                }
                //nombre;Contraseña;tipo
                sistema.CambiarUsuario(tipo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(sr != null) sr.Close();
                if(archivoUsuarios !=null) archivoUsuarios.Dispose();
            }
            

        }

      

        private void EsEmpleado()
        {
            btnAgregarPropiedad.Visible = false;
            btnEliminarReserva.Visible = false;
            sslInicio.Text += ": Empleado";
         //   verPropiedad.btnEliminarPropiedad.Visible = false;
         //   verPropiedad.btnModificar.Visible = false;
            
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
                                                    Convert.ToInt32((modalAgregarPropiedad.cmbCantEstrellas.SelectedIndex)) + 2, sistema.IdPropiedad);
                                    propiedad.AñadirImagenes(modalAgregarPropiedad.imagenesCargadas);//Se podrían pasar las imagenes en el constructor

                                    sistema.AgregarHotel((HabitacionHotel)propiedad);
                                    break;
                                case 1:

                                    propietario = new Propietario(modalAgregarPropiedad.tbNombrePropietario.Text, Convert.ToInt32(modalAgregarPropiedad.tbDniPropietario.Text));

                                    propiedad = new Casa(ubicacion, Convert.ToInt32(modalAgregarPropiedad.nudCantPersonas.Value),
                                                Convert.ToDouble(modalAgregarPropiedad.tbPrecioXNoche.Text), caracteristicas, modalAgregarPropiedad.tbDescripcion.Text,
                                                Convert.ToInt32(modalAgregarPropiedad.nudMinimoDias.Value), propietario, sistema.IdPropiedad);
                                    propiedad.AñadirImagenes(modalAgregarPropiedad.imagenesCargadas);//Se podrían pasar las imagenes en el constructor

                                    sistema.AgregarCasa((Casa)propiedad);
                                    break;
                                case 2:
                                     propietario = new Propietario(modalAgregarPropiedad.tbNombrePropietario.Text, Convert.ToInt32(modalAgregarPropiedad.tbDniPropietario.Text));

                                    propiedad = new CasaFinde(ubicacion, Convert.ToInt32(modalAgregarPropiedad.nudCantPersonas.Value),
                                                Convert.ToDouble(modalAgregarPropiedad.tbPrecioXNoche.Text), caracteristicas, modalAgregarPropiedad.tbDescripcion.Text,
                                                Convert.ToInt32(modalAgregarPropiedad.nudMinimoDias.Value), propietario, sistema.IdPropiedad);
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

        List<string> huespedes = new List<string>();
        private void dgvPropiedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            verPropiedad = new VerPropiedad();
            Propiedad propiedadConfirmar = null;
            if (sistema.TipoUsuario == "empleado")
            {
                verPropiedad.btnEliminarPropiedad.Visible = false;
                verPropiedad.btnModificar.Visible = false;
            }
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
                                cliente = new Cliente(Convert.ToInt32(registrarCliente.tbDNI.Text), registrarCliente.tbNombre.Text.ToString());
                                //// rellenar confirmacion modal
                                modalConfirmarReserva = new ConfirmacionReserva();
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
                                        //Hace la reserva
                                        int nroReserva = sistema.ReservarPropiedad(propiedadesMatch[e.RowIndex], cliente, fechaDesde.Value, fechaHasta.Value, Convert.ToInt32(nudCantPersonas.Value));
                                        RegistrarHuesped modalHuesped = new RegistrarHuesped();
                                        for(int i = 0; i < nudCantPersonas.Value-1; i++)
                                        {
                                            if (modalHuesped.ShowDialog() == DialogResult.OK)
                                            {
                                                huespedes.Add("Nombre: "+ modalHuesped.tbNombre.Text+
                                                            ", DNI: "+ modalHuesped.tbDNI.Text+
                                                            ", Fec. Nacimiento: " + modalHuesped.dtpFecNacimiento.Value.ToShortDateString());
                                            }
                                        }
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
                        modificarPropiedad.sslAgregarPropiedad.Text = "Modifique la propiedad";
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
                else if (result == DialogResult.Ignore)
                {
                    Calendario calendario = new Calendario();
                    CompletarCalendario(calendario, propiedadConfirmar);
                    if(calendario.ShowDialog()== DialogResult.No)
                    {
                        propiedadConfirmar.ExportarCalendario();
                        MessageBox.Show("Exportacion exitosa");
                    }
                    else if (calendario.ShowDialog() == DialogResult.Yes)
                    {
                        propiedadConfirmar.ImportarCalendario();
                    }
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
        private bool RellenarVerPropiedadReserva(VerPropiedad modal, Propiedad propiedad, Reserva reserva) 
        {
            bool exito = false;
            exito=RellenarVerPropiedad(modal, propiedad);
            TimeSpan cantDias = reserva.FechaFin.AddHours(1) - reserva.FechaInicio;
            try {
            modal.lbPrecioFinal.Text = propiedad.CalcularPrecio(cantDias.Days).ToString("$0.00");
            modal.lbPrecioPorDia.Text = (propiedad.CalcularPrecio(cantDias.Days) / (cantDias.Days)).ToString("$0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                exito = false;
            }
            return exito;
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
                if (!((propiedad is CasaFinde) && cantDias.Days != 2))
                {
                    modal.lbPrecioFinal.Text = propiedad.CalcularPrecio(cantDias.Days).ToString("$0.00");
                    modal.lbPrecioPorDia.Text = (propiedad.CalcularPrecio(cantDias.Days) / (cantDias.Days)).ToString("$0.00");///propiedad.Precio.ToString("$0.00");
                }
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
            modalPropiedad.btnCalendario.Visible = false;
            modalPropiedad.btnModificar.Visible = false;
            modalPropiedad.btnReservar.Visible = false;
            modalPropiedad.btnEliminarPropiedad.Visible = false;
            modalPropiedad.btnImprimir.Visible = true;
            modal.sslAgregarCliente.Text = "Consulte la reserva";
            try
            {
                DialogResult resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {

                    if (modal.tbNombre.Text.Length > 0)
                    {
                        Reserva reserva= sistema.ConsultarReserva(Convert.ToInt32(modal.tbNombre.Text), out propiedad);


                        if (RellenarVerPropiedadReserva(modalPropiedad, propiedad, reserva))
                        {
                           // modalPropiedad.ShowDialog();
                            if (modalPropiedad.ShowDialog() == DialogResult.Retry)
                            {
                                imagenPropiedad = propiedad.ImagenPropiedad[0];
                                itemsImpresion = new List<string>();

                                // Agregar elementos a la lista
                                itemsImpresion.Add("Propiedad: " + propiedad.ToString());
                                itemsImpresion.Add(propiedad.Ubicacion[0].ToString()+", "+ propiedad.Ubicacion[1].ToString() + ", " + propiedad.Ubicacion[2].ToString());

                                if (propiedad is HabitacionHotel)
                                {
                                    itemsImpresion.Add("Tipo de habitación: " + ((HabitacionHotel)propiedad).TipoHabitacion);
                                    itemsImpresion.Add("Cantidad de estrellas: " + ((HabitacionHotel)propiedad).CantEstrellas.ToString());
                                }

                                itemsImpresion.Add("Cantidad de personas admitidas: " + propiedad.CantPersonas.ToString());
                                itemsImpresion.Add("Cliente: " + reserva.Cliente.Nombre.ToString()+ " DNI: "+ reserva.Cliente.Dni.ToString());
                                itemsImpresion.Add("Fecha de inicio: " + reserva.FechaInicio.ToString());
                                itemsImpresion.Add("Fecha de fin: " + reserva.FechaFin.ToString());
                                itemsImpresion.Add("Costo total: " + reserva.Costo.ToString("$00.00"));
                                for(int i = 0; i< huespedes.Count; i++)
                                {
                                    if (i == 0) itemsImpresion.Add("Huespedes:");
                                    itemsImpresion.Add(huespedes[i]);
                                }
                                if(printDialog1.ShowDialog()==DialogResult.OK) printDocument1.Print();
                            }
                        }
                    }


                } 
                
            } 
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        

        private void btnImportarReservas_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "/reservas.txt";
            int cantReservas;
            try
            {
            sistema.ImportarReservas(path, out cantReservas);
            MessageBox.Show(cantReservas + " reservas importadas con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void btnExportarReservas_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "/reservas.txt";
            try
            {
                sistema.ExportarReservas(path);
                MessageBox.Show("Reservas exportadas con éxito.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exportarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = null;
            try
            {
                sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    sistema.Exportar(sfd.FileName);
                    MessageBox.Show("Se han exportado los clientes con sus reservas.");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NavegadorWeb modal = new NavegadorWeb();
            modal.ShowDialog();
        }

        string textoActual;
        Brush relleno;
        Pen borde;
        List<string> itemsImpresion;
        Image imagenPropiedad = null;
        bool lineaFinal = false;
        private int paginaActual = 0;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fuente = new Font("Arial", 14, FontStyle.Regular);
            Font fuenteTitulos = new Font("Arial", 18, FontStyle.Bold);
            Image icono = AlquileresTemporarios_TP2LAB2.Properties.Resources.iconoAlquileres;
            e.Graphics.DrawImage(icono, 50, 50, 100, 100);
            if (imagenPropiedad != null) e.Graphics.DrawImage(imagenPropiedad, 50, 200, 300, 225);
            textoActual = "Alquileres temporarios";
            SizeF tamañoLinea;
            tamañoLinea = e.Graphics.MeasureString(textoActual, fuenteTitulos);

            // Dibuja el título
            e.Graphics.DrawString(textoActual, fuenteTitulos, relleno, new PointF(175, 82));

            // Imprime "Original" en la primera página y "Copia" en las páginas siguientes
            string marcaPagina;
            if (paginaActual == 0)
            {
                marcaPagina = "Original";
            } else
            {
                marcaPagina = "Copia";
            }
            e.Graphics.DrawString(marcaPagina, fuente, relleno, new PointF(175, 112));

            float posY = 450;
            float posX;
            int renglon = 0;            

            posY += tamañoLinea.Height + 2;

            while (renglon < itemsImpresion.Count && posY < e.MarginBounds.Bottom)
            {
                textoActual = itemsImpresion[renglon];
                tamañoLinea = e.Graphics.MeasureString(textoActual, fuente);

                posX = 50;
                e.Graphics.DrawString(textoActual, fuente, relleno, new PointF(posX, posY));
                posY = posY + tamañoLinea.Height + 2;
                renglon++;
            }

            if (renglon < itemsImpresion.Count || paginaActual == 0)
            {
                e.HasMorePages = true;
                paginaActual++;
            }
            else
            {
                e.HasMorePages = false;
                paginaActual = 0;  
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            relleno = new SolidBrush(Color.Black);
            borde = new Pen(Color.Black);

            paginaActual = 0;  
        }

        private void printDocument1_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {
            lineaFinal = false;
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            huespedes.Clear();
            itemsImpresion.Clear();
        }

        private void propiedadesReservadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas estadisticas = new Estadisticas();

        }

        
    }
    }

