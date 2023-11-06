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
        int nroReserva;
        int idPropiedad;
        DateTime fechaInicio;
        DateTime fechaFin;
        int cantPersonas;
        double costo;
        Cliente cliente; 

        public int CantPersonas { get { return cantPersonas; } }
        public int IdPropiedad { get { return idPropiedad; } }
        public DateTime FechaInicio
        {
            get { return fechaInicio; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
        }

        public Cliente Cliente { get { return cliente; } }
        public int NroReserva { get { return nroReserva; } }
        public double Costo
        {
            get { return costo; }
        }

        public Reserva(int codigo, DateTime fechaInicio, DateTime fechaFin, int cantPersonas, double costo, Cliente cliente, int idPropiedad) 
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.cantPersonas = cantPersonas;
            this.cliente = cliente;
            this.costo = costo;
            nroReserva = codigo;          
            this.idPropiedad = idPropiedad;
        }
    }
}
