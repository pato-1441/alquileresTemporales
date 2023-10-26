using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;

namespace AlquileresTemporarios_TP2LAB2
{
    [Serializable]
    internal class HabitacionHotel:Propiedad
    {
        string nombreHotel;
        int cantEstrellas;
        int tipo;
        int numHabitacion;

        public HabitacionHotel (string[] ubicacion, int cantPersonas, double precio, bool[] caracteristicas, string descripcion, string nombreHotel, int numHabitacion, int tipo, int cantEstrellas) : base (ubicacion, cantPersonas,precio, caracteristicas, descripcion)
        {
            this.nombreHotel = nombreHotel;
            this.numHabitacion = numHabitacion;
            this.tipo = tipo;
            this.cantEstrellas = cantEstrellas;
        }
        public override double CalcularPrecio(int cantDias) {
            double precioFinal=0;
            precioFinal = cantDias * base.precio;
            return precioFinal;
        }
        public override string ToString()
        {
            return "Hotel";
        }
        
        
        }
}
