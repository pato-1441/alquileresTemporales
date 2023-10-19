using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;

namespace AlquileresTemporarios_TP2LAB2
{
    [Serializable]
    internal class Reserva
    {
        static int cantidadReservas = 0;
        int nroReserva;
        DateTime fechaInicio;
        DateTime fechaFin;
        int cantPersonas;
        double costo;
        Cliente cliente; 

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
        }

        public Cliente Cliente { get { return Cliente; } }
        public int NroReserva { get { return nroReserva; } }
        public double Costo
        {
            get { return costo; }
        }

        public Reserva(DateTime fechaInicio, DateTime fechaFin, int cantPerosnas, double costo, Cliente cliente) 
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.cantPersonas = cantPerosnas;
            nroReserva = cantidadReservas;
            cantidadReservas++;
            
        }

       

       
        
    }
}
