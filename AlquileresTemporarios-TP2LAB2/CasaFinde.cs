using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquileresTemporarios_TP2LAB2
{
    internal class CasaFinde: Casa
    {

        public CasaFinde(string[] ubicacion, int cantPersonas, double precio, bool[] caracteristicas, int minimoDias) : base(ubicacion, cantPersonas, precio, caracteristicas, minimoDias) { 
        
        }

        public override double CalcularPrecio(int cantDias)
        {
            double precioFinal = 0;

            if (cantDias == 2)
                precioFinal = base.precio * cantDias;
            else precioFinal = -1;

            return precioFinal;
        }

    }
}
