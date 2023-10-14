using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquileresTemporarios_TP2LAB2
{
    internal class Casa :Propiedad
    {
        public Casa(string ubicacion, int cantPersonas, double precio, int[] caracteristicas): base(ubicacion, cantPersonas,precio, caracteristicas){

        }
    }
}
