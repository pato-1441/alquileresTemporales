using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquileresTemporarios_TP2LAB2
{
    internal class Sistema
    {
        List<Propiedad> listaPropiedades; 

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

        public int ReservarPropiedad(Propiedad propiedad, Cliente cliente)
        {
            return 3;
        }

        public bool CancelarReserva(int numReserva, int dni)
        {
            bool exito = false;
            Propiedad propiedad;
            if (ConsultarReserva(numReserva, out propiedad) != null)
            {
                if (!propiedad.QuitarReserva(numReserva, dni)) throw new Exception("No existe la reserva.");
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
            while (!encontrada || cont < listaPropiedades.Count)
            {
                if (listaPropiedades[cont].DevolverReserva(numReserva) != null)
                {
                    encontrada = true;
                    propiedad = listaPropiedades[cont];
                }
                cont++;
            }
            return unaReserva;
        }
        public bool ConsultarDisponibilidad(Propiedad propiedad, DateTime fechaInicio, DateTime fechaFin)
        {
            return true;
        }

        public List<Propiedad> ConsultarPropiedades(string []ubicacion, DateTime fechaInicio, DateTime fechaFin)
        {
            List<Propiedad> propiedadesMatch = new List<Propiedad>();

            foreach (Propiedad propiedad in listaPropiedades)
            {
                if (ConsultarDisponibilidad(propiedad, fechaInicio, fechaFin) && propiedad.Ubicacion[1] == ubicacion[1]
                    && propiedad.Ubicacion[2] == ubicacion[2])
                {
                   propiedadesMatch.Add(propiedad);
                }
            }
            return propiedadesMatch; 
        }

        /*public List<Propiedad> ConsultarPropiedades(string ubicacion, int cantPersonas)
        {
           
        }

        public List<Propiedad> ConsultarPropiedades (string ubicacion, int cantPeronsas, int[] especificaciones)
        {

        }
        */
    }
}
