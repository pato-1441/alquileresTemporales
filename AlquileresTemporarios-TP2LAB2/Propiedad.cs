using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquileresTemporarios_TP2LAB2
{
    internal  abstract class Propiedad
    {
        string[] ubicacion;
        int cantPersonas;
        protected double precio;
        bool[] caracteristicas;
        bool disponibilidad=true;
        Image imagenPropiedad;
        List<Reserva> reservas;

        public Propiedad(string[] ubicacion, int cantPersonas, double precio, bool[] caracteristicas)
        {
            this.ubicacion = ubicacion;
            this.cantPersonas = cantPersonas;
            this.precio = precio;
            this.caracteristicas = caracteristicas;
        }

        public Image ImagenPropiedad { get { return imagenPropiedad; } set { this.imagenPropiedad = value; } }

        public abstract double CalcularPrecio(int cantDias);

        public bool AgregarReserva(Reserva reserva)
        {
            bool exito = true;
            if (reservas.Contains(reserva))
                exito = false;
            else reservas.Add(reserva);
            return exito;
            //Agregar al calendario, que todavia no sabemos que hace
        }
        public bool QuitarReserva(int nroReserva, int dni) { 
            bool exito = false;
            foreach(Reserva reserva in reservas)
            {
                if (nroReserva == reserva.NroReserva && dni == reserva.Cliente.Dni) {
                    reservas.Remove(reserva);
                    exito = true;
                }
            }
            return exito;
        }
        public Reserva DevolverReserva(int nroReserva)
        {
            Reserva reserva = null;
            bool encontrado = false;
            int cont = 0;
            while (!encontrado && cont < reservas.Count)
            {
                if (reservas[cont].NroReserva == nroReserva)
                {
                    reserva = reservas[cont];
                    encontrado = true;
                }
                cont++;
            }
            return reserva;
        }


    }
}
