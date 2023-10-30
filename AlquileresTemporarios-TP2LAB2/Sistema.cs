using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace AlquileresTemporarios_TP2LAB2
{
   [Serializable]
    internal class Sistema
    {
        int cantidadReservas = 0;
        List<Propiedad> listaPropiedades = new List<Propiedad>();
        public List<Propiedad> ListaPropiedades
        {
            get { return listaPropiedades; }
        }
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
                exito = true;
            }
            return exito;
        }

        public int ReservarPropiedad(Propiedad propiedad, Cliente cliente, DateTime fechaInicio, DateTime fechaFin, int cantPersonas)
        {
            
            if (ConsultarDisponibilidad(propiedad, fechaInicio, fechaFin)) {
                TimeSpan tiempoReserva = fechaFin - fechaInicio;
                if (propiedad.ToString() == "Casa fin de semana" && fechaInicio.DayOfWeek.ToString() != "Friday") throw new Exception("La fecha de inicio no es un viernes.");

                Reserva reserva = new Reserva(cantidadReservas ,fechaInicio, fechaFin, cantPersonas, propiedad.CalcularPrecio(tiempoReserva.Days), cliente);
                cantidadReservas++;
                propiedad.AgregarReserva(reserva);
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

            foreach (Propiedad propiedad in listaPropiedades)
            {
                if (ConsultarDisponibilidad(propiedad, fechaInicio, fechaFin) && propiedad.Ubicacion[1] == ubicacion[0]
                    && propiedad.Ubicacion[2] == ubicacion[1])
                {
                    if (propiedad.ToString() == "Casa fin de semana")
                    {
                        if (fechaInicio.DayOfWeek.ToString() == "Friday") propiedadesMatch.Add(propiedad);
                    }
                    else
                    {
                        propiedadesMatch.Add(propiedad);
                    }
                }
            }
            return propiedadesMatch; 
        }

       
        private List<Propiedad> ConsultarPropiedades(string provincia, DateTime fechaInicio, DateTime fechaFin)
        {
            List<Propiedad> propiedadesMatch = new List<Propiedad>();
           
            foreach (Propiedad propiedad in listaPropiedades)
            {
                if (ConsultarDisponibilidad(propiedad, fechaInicio, fechaFin) && propiedad.Ubicacion[2] == provincia)
                {
                    if (propiedad.ToString() == "Casa fin de semana")
                    {
                        if (fechaInicio.DayOfWeek.ToString() == "Friday") propiedadesMatch.Add(propiedad);
                    }
                    else
                    {
                        propiedadesMatch.Add(propiedad);
                    }
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
