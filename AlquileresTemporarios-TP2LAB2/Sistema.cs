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
    internal class Sistema
    {
        int cantPropiedades = 0;
        int cantidadReservas = 0;
        List<Propiedad> listaPropiedades = new List<Propiedad>();
        public List<Propiedad> ListaPropiedades
        {
            get { return listaPropiedades; }
        }

        public int IdPropiedad { get { return cantPropiedades; } }
        public int CodigoReserva 
        { 
            get { return cantidadReservas; }
            set { cantidadReservas += value; }
        }
       
        public bool AgregarCasa(Casa casa)
        {
            bool exito = false;
            if (!listaPropiedades.Contains(casa))
            {
                listaPropiedades.Add(casa);
                cantPropiedades++;
                exito = true;   
            }
            return exito;
        }

        public bool AgregarHotel(HabitacionHotel hotel)
        {
            bool exito = false;
            if (!listaPropiedades.Contains(hotel))
            {
                listaPropiedades.Add(hotel);
                cantPropiedades++;
                exito = true;
            }
            return exito;
        }

        public int ReservarPropiedad(Propiedad propiedad, Cliente cliente, DateTime fechaInicio, DateTime fechaFin, int cantPersonas)
        {
            
            if (ConsultarDisponibilidad(propiedad, fechaInicio, fechaFin)) {
                TimeSpan tiempoReserva = fechaFin - fechaInicio;
                Reserva reserva;
                if (propiedad.ToString() == "Casa fin de semana" && fechaInicio.DayOfWeek.ToString() != "Friday") throw new Exception("La fecha de inicio no es un viernes.");
                try
                {
                    reserva = new Reserva(cantidadReservas, propiedad.IdPropiedad, fechaInicio, fechaFin, cantPersonas, propiedad.CalcularPrecio(tiempoReserva.Days), cliente);
                    cantidadReservas++;
                    propiedad.AgregarReserva(reserva);
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                
            }
            return cantidadReservas-1;
        }

        public bool CancelarReserva(int numReserva, int dni)
        {
            bool exito = false;
            Propiedad propiedad;
            if (ConsultarReserva(numReserva, out propiedad) != null)
            {
                if (!propiedad.QuitarReserva(numReserva, dni)) throw new Exception("Los datos ingresados no poseen permisos.");
                else exito = true;
            }
            else { throw new Exception("No existe la reserva."); }
            return exito;
        }
        public Reserva ConsultarReserva(int numReserva, out Propiedad propiedad)
        {
            Reserva unaReserva = null;
            propiedad = null;
            bool encontrada = false;
            int cont = 0;
            while (!encontrada && cont < listaPropiedades.Count)
            {
                unaReserva = listaPropiedades[cont].DevolverReserva(numReserva);
                if (unaReserva != null)
                {
                    encontrada = true;
                    propiedad = listaPropiedades[cont];                   
                }
                cont++;
            }
            return unaReserva;
        }
        private bool ConsultarDisponibilidad(Propiedad propiedad, DateTime fechaInicio, DateTime fechaFin)
        {
            bool exito = true;
            //if(propiedad.Reservas.Count>0)
            foreach (Reserva reserva in propiedad.Reservas)
            {
                if (!(fechaFin < reserva.FechaInicio || fechaInicio > reserva.FechaFin)) exito = false;
            }
            return exito;
        }

        private  List<Propiedad> ConsultarPropiedades(string []ubicacion, DateTime fechaInicio, DateTime fechaFin)
        {
            List<Propiedad> propiedadesMatch = new List<Propiedad>();
            TimeSpan cantDias = fechaFin - fechaInicio;

            foreach (Propiedad propiedad in listaPropiedades)
            {
                if (ConsultarDisponibilidad(propiedad, fechaInicio, fechaFin) && propiedad.Ubicacion[1] == ubicacion[0]
                    && propiedad.Ubicacion[2] == ubicacion[1])
                {
                    if (propiedad.ToString() == "Casa fin de semana")
                    {
                        if (fechaInicio.DayOfWeek.ToString() == "Friday" && fechaFin.DayOfWeek.ToString() == "Sunday" && cantDias.Days == 2) propiedadesMatch.Add(propiedad);
                    }
                    else if(propiedad.ToString() == "Casa")
                    {
                        if (cantDias.Days >= ((Casa)propiedad).MinimoDias) propiedadesMatch.Add(propiedad);
                    }else propiedadesMatch.Add(propiedad);
                }
            }
            return propiedadesMatch; 
        }

       
        private List<Propiedad> ConsultarPropiedades(string provincia, DateTime fechaInicio, DateTime fechaFin)
        {
            List<Propiedad> propiedadesMatch = new List<Propiedad>();
            TimeSpan cantDias = fechaFin - fechaInicio;
            foreach (Propiedad propiedad in listaPropiedades)
            {
                if (ConsultarDisponibilidad(propiedad, fechaInicio, fechaFin) && propiedad.Ubicacion[2] == provincia)
                {
                    if (propiedad.ToString() == "Casa fin de semana")
                    {
                        if (fechaInicio.DayOfWeek.ToString() == "Friday" && fechaFin.DayOfWeek.ToString()== "Sunday" && cantDias.Days==2) propiedadesMatch.Add(propiedad);
                    }
                    else if(propiedad.ToString() == "Casa")
                    {
                        if(cantDias.Days>= ((Casa)propiedad).MinimoDias)propiedadesMatch.Add(propiedad);
                    }else propiedadesMatch.Add(propiedad);
                }
            }
            return propiedadesMatch;
        }

        
        private List<Propiedad> ConsultarPropiedades(string[] ubicacion, DateTime fechaInicio, DateTime fechaFin, int cantPersonas)
        {
            List<Propiedad> propiedadesMatch = new List<Propiedad>();
            List<Propiedad> propiedadesMatchAux = new List<Propiedad>();

           if (ubicacion[0] != "") propiedadesMatchAux = ConsultarPropiedades(ubicacion, fechaInicio, fechaFin);
            else propiedadesMatchAux = ConsultarPropiedades(ubicacion[1], fechaInicio, fechaFin);

            foreach (Propiedad propiedad in propiedadesMatchAux)
            {
                if(propiedad.CantPersonas == cantPersonas)
                {
                    propiedadesMatch.Add(propiedad) ;
                }
            }

            return propiedadesMatch;
        }

        public List<Propiedad> ConsultarPropiedades (string[] ubicacion, DateTime fechaInicio, DateTime fechaFin, int cantPersonas, bool[] especificaciones)
        {
            List<Propiedad> propiedadesMatch = ConsultarPropiedades(ubicacion, fechaInicio, fechaFin, cantPersonas);            
            List<Propiedad> propiedadesMatchBusqueda = ConsultarPropiedades(ubicacion, fechaInicio, fechaFin, cantPersonas);
            
            foreach (Propiedad propiedad in propiedadesMatchBusqueda)
            {
                for(int i =0; i<6; i++)
                {
                    if (especificaciones[i] == true && propiedad.Caracteristicas[i] == false) propiedadesMatch.Remove(propiedad); 
                }
            }
            return propiedadesMatch;

        }
        public bool ModificarPropiedad(Propiedad propiedad, double nuevoPrecio, string nuevaDescripcion, bool[] caracteristicas, int cantPersonas, int diasMinimos)
        {
            bool exito = false;
            try
            {
                propiedad.ModificarPropiedad(nuevoPrecio, nuevaDescripcion, caracteristicas, cantPersonas);
                if (propiedad.ToString() == "Casa") ((Casa)propiedad).MinimoDias = diasMinimos;
                exito = true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return exito;
        }
        public bool EliminarPropiedad(Propiedad propiedad)
        {
            bool exito = false;
            if(listaPropiedades.Contains(propiedad))
            {
                listaPropiedades.Remove(propiedad);
                exito = true;
            }
            return exito;
        }

        public void ImportarReservas(string path, out int cantReservas)
        {            
            FileStream archivo = null;
            StreamReader sr = null;
            cantReservas = 0;            
            try
            {
                archivo = new FileStream(path, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(archivo);

                string lineaEntera = sr.ReadLine();
                string[] linea;

                while (lineaEntera != null)
                {
                    linea = lineaEntera.Split(';');
                    foreach (Propiedad prop in listaPropiedades)
                    {
                        if (linea.Length == 8)
                        {
                            if (prop.IdPropiedad.ToString() == linea[1])
                            {
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
                                prop.AgregarReserva(reserva);
                                cantReservas++;
                            }
                        }
                        else
                        {
                            throw new ArgumentException();
                        }
                            
                    }
                    lineaEntera = sr.ReadLine();                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (archivo != null && sr != null)
                {
                    sr.Dispose();
                    archivo.Close();
                }
            }
            
        }

        public void ExportarReservas(string path)
        {
            FileStream archivo = null;
            StreamWriter sr = null;
            try
            {
                archivo = new FileStream(path, FileMode.Create, FileAccess.Write);
                sr = new StreamWriter(archivo);

                foreach (Propiedad prop in listaPropiedades)
                {
                    foreach (Reserva reserva in prop.Reservas)
                    {
                        sr.WriteLine(reserva.NroReserva + ";" + reserva.IdPropiedad + ";" + reserva.FechaInicio + ";" + reserva.FechaFin
                                     + ";" + reserva.CantPersonas + ";" + reserva.Costo + ";" + reserva.Cliente.Dni + ";" + reserva.Cliente.Nombre);
                    }
                }
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (archivo != null && sr != null)
                {
                    sr.Dispose();
                    archivo.Close();
                }                
            }
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
