using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquileresTemporarios_TP2LAB2
{
    internal  abstract class Propiedad
    {
        string ubicacion;
        int cantPersonas;
       protected double precio;
        int[] caracteristicas;
        bool disponibilidad=true;
        List<Reserva> reservas;

        public Propiedad(string ubicacion, int cantPersonas, double precio, int[] caracteristicas)
        {
            this.ubicacion = ubicacion;
            this.cantPersonas = cantPersonas;
            this.precio = precio;
            this.caracteristicas = caracteristicas;
        }

        public abstract double CalcularPrecio(int cantDias);

        public void AgregarReserva(Reserva reserva)
        {
            reservas.Add(reserva);
            //Agregar al calendario, que todavia no sabemos que hace
        }
        

    }
}
