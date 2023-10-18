﻿using System;
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
        string descripcion;
        bool[] caracteristicas;
        bool disponibilidad=true;
        Image[] imagenesPropiedad= new Image[5];
        List<Reserva> reservas;


        public int CantPersonas
        {
            get { return cantPersonas; }
        }

        public string[] Ubicacion
        {
            get { return ubicacion; }
        }

        public bool[] Caracteristicas
        {
            get { return caracteristicas; }
        }

        public Propiedad(string[] ubicacion, int cantPersonas, double precio, bool[] caracteristicas, string descripcion)
        {
            this.ubicacion = ubicacion;
            this.cantPersonas = cantPersonas;
            this.precio = precio;
            this.caracteristicas = caracteristicas;
            this.descripcion = descripcion;
        }

        public Image[] ImagenPropiedad { get { return imagenesPropiedad; } }
        public string Descripcion { get { return descripcion; } }
        public void AñadirImagenes(Image imagen1, Image imagen2, Image imagen3 ,Image imagen4, Image imagen5)
        {
            imagenesPropiedad[0]= imagen1;
            imagenesPropiedad[1]= imagen2;
            imagenesPropiedad[2] = imagen3;
            imagenesPropiedad[3] = imagen4; 
            imagenesPropiedad[4] = imagen5;
        }

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
