using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquileresTemporarios_TP2LAB2
{
    internal class Reserva
    {
        DateTime fechaInicio;
        DateTime fechaFin;
        int cantPersonas;
        double costo;

        public double Costo
        {
            get { return costo; }
        }

        public Reserva(DateTime fechaInicio, DateTime fechaFin, int cantPerosnas, double costo) 
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.cantPersonas = cantPerosnas;
            
        }

       

       
        
    }
}
