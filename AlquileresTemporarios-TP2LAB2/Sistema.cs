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
          
            return true;
        }

        public bool AgregarHotel(HabitacionHotel hotel)
        {
            return true;
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
        public bool ConsultarDisponibilidad(Propiedad propiedad, DateTime fecha)
        {
            return true;
        }

       /* public List<Propiedad> ConsultarPropiedades(string ubicacion)
        {
            return List<Propiedad>; 
        }*/

        /*public List<Propiedad> ConsultarPropiedades(string ubicacion, int cantPersonas)
        {
           
        }

        public List<Propiedad> ConsultarPropiedades (string ubicacion, int cantPeronsas, int[] especificaciones)
        {

        }
        */
    }
}
