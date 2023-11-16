using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace AlquileresTemporarios_TP2LAB2
{
    [Serializable]
    internal class Sistema: IExportar {
        int cantPropiedades = 0;
        int cantidadReservas = 0;
        List<Propiedad> listaPropiedades = new List<Propiedad>();
        List<Cliente> listaClientes = new List<Cliente>();
        Usuario usuarioActual;
        /// List<Usuario> listaUsuarios = new List<Usuario>();
        public List<Propiedad> ListaPropiedades {
            get { return listaPropiedades; }
        }
        public string TipoUsuario {
            get { return usuarioActual.Tipo; }
        }
        public int IdPropiedad { get { return cantPropiedades; } }
        public int CodigoReserva {
            get { return cantidadReservas; }
            set { cantidadReservas += value; }
        }
        public void CambiarUsuario(string tipo, string nombre, string contraseña) {
            if(tipo == "administrador" || tipo == "empleado") {
                usuarioActual = new Usuario(nombre, contraseña, tipo);
            } else throw new Exception("El tipo de usuario no es un tipo válido.");

        }
        public bool AgregarCasa(Casa casa) {
            bool exito = false;
            if(!listaPropiedades.Contains(casa)) {
                listaPropiedades.Add(casa);
                cantPropiedades++;
                exito = true;
            }
            return exito;
        }

        public bool AgregarHotel(HabitacionHotel hotel) {
            bool exito = false;
            if(!listaPropiedades.Contains(hotel)) {
                listaPropiedades.Add(hotel);
                cantPropiedades++;
                exito = true;
            }
            return exito;
        }

        public int ReservarPropiedad(Propiedad propiedad, Cliente cliente, DateTime fechaInicio, DateTime fechaFin, int cantPersonas) {

            if(ConsultarDisponibilidad(propiedad, fechaInicio, fechaFin)) {
                TimeSpan tiempoReserva = fechaFin - fechaInicio;
                Reserva reserva;
                Cliente clienteReserva;
                if(propiedad.ToString() == "Casa fin de semana" && fechaInicio.DayOfWeek.ToString() != "Friday") throw new Exception("La fecha de inicio no es un viernes.");
                try {

                    clienteReserva = BuscarCliente(cliente.Dni);
                    if(clienteReserva == null) {
                        clienteReserva = cliente;
                    }
                    reserva = new Reserva(cantidadReservas, propiedad.IdPropiedad, fechaInicio, fechaFin, cantPersonas, propiedad.CalcularPrecio(tiempoReserva.Days), clienteReserva);
                    cantidadReservas++;
                    propiedad.AgregarReserva(reserva);
                    if(!(listaClientes.Contains(clienteReserva))) listaClientes.Add(reserva.Cliente);
                    cliente.AgregarReserva(reserva.NroReserva);

                } catch(Exception ex) {
                    throw new Exception(ex.Message);
                }

            }
            return cantidadReservas - 1;
        }

        public bool CancelarReserva(int numReserva, int dni) {
            bool exito = false;
            Propiedad propiedad;
            if(ConsultarReserva(numReserva, out propiedad) != null) {
                if(!propiedad.QuitarReserva(numReserva, dni)) throw new Exception("Los datos ingresados no poseen permisos.");
                else exito = true;
            } else { throw new Exception("No existe la reserva."); }
            return exito;
        }
        public Reserva ConsultarReserva(int numReserva, out Propiedad propiedad) {
            Reserva unaReserva = null;
            propiedad = null;
            bool encontrada = false;
            int cont = 0;
            while(!encontrada && cont < listaPropiedades.Count) {
                unaReserva = listaPropiedades[cont].DevolverReserva(numReserva);
                if(unaReserva != null) {
                    encontrada = true;
                    propiedad = listaPropiedades[cont];
                }
                cont++;
            }
            return unaReserva;
        }
        private bool ConsultarDisponibilidad(Propiedad propiedad, DateTime fechaInicio, DateTime fechaFin) {
            bool exito = true;
            //if(propiedad.Reservas.Count>0)
            foreach(Reserva reserva in propiedad.Reservas) {
                if(!(fechaFin < reserva.FechaInicio || fechaInicio > reserva.FechaFin)) exito = false;
            }
            return exito;
        }

        private List<Propiedad> ConsultarPropiedades(string[] ubicacion, DateTime fechaInicio, DateTime fechaFin) {
            List<Propiedad> propiedadesMatch = new List<Propiedad>();
            TimeSpan cantDias = fechaFin - fechaInicio;

            foreach(Propiedad propiedad in listaPropiedades) {
                if(ConsultarDisponibilidad(propiedad, fechaInicio, fechaFin) && propiedad.Ubicacion[1] == ubicacion[0]
                    && propiedad.Ubicacion[2] == ubicacion[1]) {
                    if(propiedad.ToString() == "Casa fin de semana") {
                        if(fechaInicio.DayOfWeek.ToString() == "Friday" && fechaFin.DayOfWeek.ToString() == "Sunday" && cantDias.Days == 2) propiedadesMatch.Add(propiedad);
                    } else if(propiedad.ToString() == "Casa") {
                        if(cantDias.Days >= ((Casa)propiedad).MinimoDias) propiedadesMatch.Add(propiedad);
                    } else propiedadesMatch.Add(propiedad);
                }
            }
            return propiedadesMatch;
        }


        private List<Propiedad> ConsultarPropiedades(string provincia, DateTime fechaInicio, DateTime fechaFin) {
            List<Propiedad> propiedadesMatch = new List<Propiedad>();
            TimeSpan cantDias = fechaFin - fechaInicio;
            foreach(Propiedad propiedad in listaPropiedades) {
                if(ConsultarDisponibilidad(propiedad, fechaInicio, fechaFin) && propiedad.Ubicacion[2] == provincia) {
                    if(propiedad.ToString() == "Casa fin de semana") {
                        if(fechaInicio.DayOfWeek.ToString() == "Friday" && fechaFin.DayOfWeek.ToString() == "Sunday" && cantDias.Days == 2) propiedadesMatch.Add(propiedad);
                    } else if(propiedad.ToString() == "Casa") {
                        if(cantDias.Days >= ((Casa)propiedad).MinimoDias) propiedadesMatch.Add(propiedad);
                    } else propiedadesMatch.Add(propiedad);
                }
            }
            return propiedadesMatch;
        }


        private List<Propiedad> ConsultarPropiedades(string[] ubicacion, DateTime fechaInicio, DateTime fechaFin, int cantPersonas) {
            List<Propiedad> propiedadesMatch = new List<Propiedad>();
            List<Propiedad> propiedadesMatchAux = new List<Propiedad>();

            if(ubicacion[0] != "") propiedadesMatchAux = ConsultarPropiedades(ubicacion, fechaInicio, fechaFin);
            else propiedadesMatchAux = ConsultarPropiedades(ubicacion[1], fechaInicio, fechaFin);

            foreach(Propiedad propiedad in propiedadesMatchAux) {
                if(propiedad.CantPersonas == cantPersonas) {
                    propiedadesMatch.Add(propiedad);
                }
            }

            return propiedadesMatch;
        }

        public List<Propiedad> ConsultarPropiedades(string[] ubicacion, DateTime fechaInicio, DateTime fechaFin, int cantPersonas, bool[] especificaciones) {
            List<Propiedad> propiedadesMatch = ConsultarPropiedades(ubicacion, fechaInicio, fechaFin, cantPersonas);
            List<Propiedad> propiedadesMatchBusqueda = ConsultarPropiedades(ubicacion, fechaInicio, fechaFin, cantPersonas);

            foreach(Propiedad propiedad in propiedadesMatchBusqueda) {
                for(int i = 0; i < 6; i++) {
                    if(especificaciones[i] == true && propiedad.Caracteristicas[i] == false) propiedadesMatch.Remove(propiedad);
                }
            }
            if(propiedadesMatch.Count == 0 && cantPersonas < 20) {
                propiedadesMatch = ConsultarPropiedades(ubicacion, fechaInicio, fechaFin, cantPersonas + 1, especificaciones);
            }
            return propiedadesMatch;

        }
        public bool ModificarPropiedad(Propiedad propiedad, double nuevoPrecio, string nuevaDescripcion, bool[] caracteristicas, int cantPersonas, int diasMinimos) {
            bool exito = false;
            try {
                propiedad.ModificarPropiedad(nuevoPrecio, nuevaDescripcion, caracteristicas, cantPersonas);
                if(propiedad.ToString() == "Casa") ((Casa)propiedad).MinimoDias = diasMinimos;
                exito = true;
            } catch(Exception ex) {
                throw new Exception(ex.Message);
            }
            return exito;
        }
        public bool EliminarPropiedad(Propiedad propiedad) {
            bool exito = false;
            if(listaPropiedades.Contains(propiedad)) {
                listaPropiedades.Remove(propiedad);
                exito = true;
            }
            return exito;
        }

        public void ImportarReservas(string path, out int cantReservas) {
            FileStream archivo = null;
            StreamReader sr = null;
            cantReservas = 0;
            bool exito = true;
            try {
                archivo = new FileStream(path, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(archivo);

                string lineaEntera = sr.ReadLine();
                string[] linea;

                while(lineaEntera != null) {
                    linea = lineaEntera.Split(';');
                    foreach(Propiedad prop in listaPropiedades) {
                        exito = true;
                        if(linea.Length == 8) {
                            if(prop.IdPropiedad.ToString() == linea[1]) {
                                //string[] fechaSeparada = linea[2].Split('/', ' ', ':');
                                string entradaFechaInicio = linea[2];
                                DateTime fechaInicio = DateTime.ParseExact(entradaFechaInicio, "d/M/yyyy H:mm:ss", CultureInfo.InvariantCulture);
                                DateTime nuevaFechaInicio = new DateTime(fechaInicio.Year, fechaInicio.Month, fechaInicio.Day,
                                                                         fechaInicio.Hour, fechaInicio.Minute, fechaInicio.Second);

                                string entradaFechaFin = linea[3];
                                DateTime fechaFin = DateTime.ParseExact(entradaFechaFin, "d/M/yyyy H:mm:ss", CultureInfo.InvariantCulture);
                                DateTime nuevaFechaFin = new DateTime(fechaFin.Year, fechaFin.Month, fechaFin.Day,
                                                                      fechaFin.Hour, fechaFin.Minute, fechaFin.Second);

                                Cliente cliente = new Cliente(Convert.ToInt32(linea[6]), linea[7]);
                                Reserva reserva = new Reserva(Convert.ToInt32(linea[0]), Convert.ToInt32(linea[1]), nuevaFechaInicio, nuevaFechaFin, Convert.ToInt32(linea[4]), Convert.ToDouble(linea[5]), cliente);


                                foreach(Reserva reservaVieja in prop.Reservas) {
                                    if(!(nuevaFechaFin < reservaVieja.FechaInicio) || (nuevaFechaInicio > reservaVieja.FechaFin)) {
                                        exito = false;
                                    }
                                }
                                if(exito) {
                                    prop.AgregarReserva(reserva);

                                    cantReservas++;
                                    cantidadReservas++;

                                }

                            }
                        } else {
                            throw new ArgumentException();
                        }

                    }
                    lineaEntera = sr.ReadLine();
                }
            } catch(Exception ex) {
                throw new Exception(ex.Message);
            } finally {
                if(archivo != null && sr != null) {
                    sr.Dispose();
                    archivo.Close();
                }
            }

        }

        public void ExportarReservas(string path) {

            FileStream archivo = null;
            StreamWriter sr = null;
            try {
                archivo = new FileStream(path, FileMode.Create, FileAccess.Write);
                sr = new StreamWriter(archivo);

                foreach(Propiedad prop in listaPropiedades) {
                    foreach(Reserva reserva in prop.Reservas) {
                        sr.WriteLine(reserva.NroReserva + ";" + reserva.IdPropiedad + ";" + reserva.FechaInicio + ";" + reserva.FechaFin
                                     + ";" + reserva.CantPersonas + ";" + reserva.Costo + ";" + reserva.Cliente.Dni + ";" + reserva.Cliente.Nombre);
                    }
                }
            } catch(Exception ex) {
                throw new Exception(ex.Message);
            } finally {
                if(archivo != null && sr != null) {
                    sr.Dispose();
                    archivo.Close();
                }
            }
        }

        public Cliente BuscarCliente(int dni) {
            Cliente clienteEncontrado = null;
            foreach(Cliente cliente in listaClientes) {
                if(cliente.Dni == dni) {
                    clienteEncontrado = cliente;
                }
            }
            return clienteEncontrado;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context) {
            throw new NotImplementedException();
        }

        public void Exportar(string ruta) {
            FileStream fs = null;
            StreamWriter sw = null;
            try {

                fs = new FileStream(ruta, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine("Reservas al: " + DateTime.Now.ToString());
                string linea;
                foreach(Cliente cliente in listaClientes) {
                    linea = cliente.Dni.ToString() + ";" + cliente.Nombre.ToString();
                    sw.WriteLine(linea);
                    foreach(int id in cliente.IdReserva) {
                        foreach(Propiedad propiedad in listaPropiedades) {
                            foreach(Reserva reserva in propiedad.Reservas) {
                                if(reserva.Cliente.Dni == cliente.Dni) {
                                    linea = propiedad.IdPropiedad.ToString() + ";" + reserva.FechaInicio.ToString() + ";" + reserva.FechaFin.ToString();
                                    sw.WriteLine(linea);
                                }
                            }
                        }
                    }
                }

            } catch(Exception ex) {
                throw new Exception(ex.Message);
            } finally {
                if(sw != null) sw.Close();
                if(fs != null) fs.Dispose();
            }
        }

        public double[] GraficosPropiedades(out double[] porcentajeHuespedes) {
            double[] porcentajes = new double[] { 0, 0 };
            int cont = 0;

            porcentajeHuespedes = new double[7];
            for(int i = 0; i < porcentajeHuespedes.Length; i++) porcentajeHuespedes[i] = 0;

            foreach(Propiedad propiedad in listaPropiedades) {
                foreach(Reserva reserva in propiedad.Reservas) {
                    if(reserva.CantPersonas > 0) {
                        if(reserva.CantPersonas < 6)
                            porcentajeHuespedes[reserva.CantPersonas - 1]++;
                        else porcentajeHuespedes[5]++;

                    } else throw new Exception("La cantidad de Personas no es válida.");

                    if(propiedad is HabitacionHotel) porcentajes[0]++;
                    else porcentajes[1]++;
                    cont++;
                }
            }
            for(int i = 0; i < porcentajes.Length; i++) {
                porcentajes[i] = (double)porcentajes[i] / cont;
            }
            for(int i = 0; i < porcentajeHuespedes.Length; i++) {
                porcentajeHuespedes[i] = (double)porcentajeHuespedes[i] / cont;
            }
            return porcentajes;
        }

        public void agregarUsuario(string nombre, string contraseña, string tipo) {
            string ruta = Application.StartupPath + "/usuarios.txt";
            FileStream fs = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs);
            string[] linea;
            while(!sr.EndOfStream) {
                linea = sr.ReadLine().Split(';');
                if(linea[0] == nombre) {
                    sw.Close();
                    sr.Close();
                    fs.Dispose();
                    throw new Exception("El nombre de usuario que eligió ya" +
                                        " está siendo utilizado por otra persona");
                }
            }
            sw.WriteLine(nombre + ";" + contraseña + ";" + tipo + ";");
            sw.Close();
            sr.Close();
            fs.Dispose();
        }
        public bool cambiarContraseña(string contraseñaNueva) {
            string ruta = Application.StartupPath + "/usuarios.txt";
            FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string[] texto = sr.ReadToEnd().Split(';');
            string parte = texto[0];
            int cont = -1;
            bool encontrado = false;
            while(!encontrado && cont < texto.Length) {
                cont++;
                parte = parte.Replace("\r", "");
                parte = parte.Replace("\n", "");
                if(cont % 3 == 0) {
                    //texto[cont] = parte;
                    if(parte == this.usuarioActual.Nombre) {
                        texto[cont + 1] = contraseñaNueva;
                        encontrado = true;
                    }
                }
                if(cont < texto.Length)
                    parte = texto[cont + 1];
            }
            sr.Close();
            fs.Dispose();

            fs = new FileStream(ruta, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for(int i = 0; i < ((texto.Length - 1) / 3); i++) {
                for(int j = 0; j < 3; j++) {
                    sw.Write(texto[(i * 3) + j] + ";");
                }
                //sw.WriteLine();
            }
            sw.Close();
            fs.Dispose();
            return encontrado;

        }

        public void ExportarRecaudacionPropiedad(string path) {
            FileStream archivo = null;
            StreamWriter sw = null;
            try {
                archivo = new FileStream(path+".txt", FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(archivo);

                foreach(Propiedad prop in listaPropiedades) {
                   sw.WriteLine(prop.IdPropiedad + ";" + prop.TotalRecaudado());
                }
            } catch(Exception ex) {
                throw new Exception(ex.Message);
            } finally {
                if(archivo != null && sw != null) {
                    sw.Dispose();
                    archivo.Close();
                }
            }
        }
    
    }

    
}
