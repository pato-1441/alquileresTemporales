using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquileresTemporarios_TP2LAB2
{
    internal class Casa :Propiedad
    {
        int minimoDias;      
        public Casa(string[] ubicacion, int cantPersonas, double precio, bool[] caracteristicas, int minimoDias): base(ubicacion, cantPersonas,precio, caracteristicas)
        {
            this.minimoDias = minimoDias;
        }

        public override double CalcularPrecio(int cantDias)
        {
            double precioFinal=0;
            int diasDescuento = 0;
            if(cantDias<minimoDias)
            {
                precioFinal = -1;
            }
            else 
            {
                diasDescuento= cantDias - minimoDias;
                precioFinal = minimoDias * base.precio + (diasDescuento* (base.precio *0.90));
            }

            return precioFinal;
        }
    }
}
