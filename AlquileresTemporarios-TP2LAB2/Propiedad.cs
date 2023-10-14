using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquileresTemporarios_TP2LAB2
{
    internal class Propiedad
    {
        string ubicacion;
        int cantPersonas;
        double precio;
        int[] caracteristicas;
        bool disponibilidad=true;

        public Propiedad(string ubicacion, int cantPersonas, double precio, int[] caracteristicas)
        {
            this.ubicacion = ubicacion;
            this.cantPersonas = cantPersonas;
            this.precio = precio;
            this.caracteristicas = caracteristicas;
        }


    }
}
