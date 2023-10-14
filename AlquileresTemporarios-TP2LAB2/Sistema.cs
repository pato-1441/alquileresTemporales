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
            if ()
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
            //ConsultarReserva
            return true;
        }
        public bool ConsultarReserva(int numReserva)
        {
            return false;
        }
        public bool ConsultarDisponibilidad(Propiedad propiedad, DateTime fecha)
        {
            return true;
        }

        public List<Propiedad> ConsultarPropiedades(string ubicacion)
        {
            return List<Propiedad>;
        }

        public List<Propiedad> ConsultarPropiedades(string ubicacion, int cantPersonas)
        {
           
        }

        public List<Propiedad> ConsultarPropiedades (string ubicacion, int cantPeronsas, int[] especificaciones)
        {

        }


    }
}
