using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;


namespace AlquileresTemporarios_TP2LAB2
    
{
    [Serializable]
    internal class Casa :Propiedad
    {
        int minimoDias;      
        public Casa(string[] ubicacion, int cantPersonas, double precio, bool[] caracteristicas, string descripcion, int minimoDias): base (ubicacion, cantPersonas,precio, caracteristicas,descripcion)
        {
            this.minimoDias = minimoDias;
        }
        public int MinimoDias
        {
            get { return minimoDias; }
            set { if (value >= 0) minimoDias = value;
                else throw new Exception("La cantidad de días no es válida. Tiene que ser mayor o igual a cero.");
                }
        }
        public override double CalcularPrecio(int cantDias)
        {
            double precioFinal = 0;
            int diasDescuento = 0;
            
            diasDescuento= cantDias - minimoDias;
            precioFinal = minimoDias * base.precio + (diasDescuento* (base.precio * 0.90));
            

            return precioFinal;
        }
        public override string ToString()
        {
            return "Casa";
        }
    }
}
