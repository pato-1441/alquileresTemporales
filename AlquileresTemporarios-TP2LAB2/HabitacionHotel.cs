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
        int cantEstrellas, tipo, numHabitacion;
        string[] tipoHabitacion = new string[] {"Simple","Doble","Triple"};
        string[] cantEstrellasString = new string[] { "✮✮", "✮✮✮" };

        public string CantEstrellas { get { return cantEstrellasString[cantEstrellas-2]; } }
        public string TipoHabitacion { get { return tipoHabitacion[tipo]; } }
        public int NumHabitacion { get {  return numHabitacion; } }

        public HabitacionHotel (string[] ubicacion, int cantPersonas, double precio, bool[] caracteristicas, string descripcion, string nombreHotel, int numHabitacion, int tipo, int cantEstrellas) : base (ubicacion, cantPersonas,precio, caracteristicas, descripcion)
        {
            this.nombreHotel = nombreHotel;
            this.numHabitacion = numHabitacion;
            this.tipo = tipo;
            this.cantEstrellas = cantEstrellas;
        }
        public override double CalcularPrecio(int cantDias) {
            double precioFinal = cantDias * base.Precio;

            //doble
            if (tipo == 1) precioFinal += (precioFinal * 0.80);
            //triple
            else if (tipo == 2) precioFinal += (precioFinal * 1.5);
            //tres estrellas
            if (cantEstrellas == 3) precioFinal += (precioFinal * 0.40);

            //suma comision de 3%
            return precioFinal += (precioFinal * 0.3);
        }
        public override string ToString()
        {
            return "Hotel";
        }
        
        
        }
}
