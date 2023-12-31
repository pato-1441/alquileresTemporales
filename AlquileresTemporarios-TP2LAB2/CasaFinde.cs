﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;

namespace AlquileresTemporarios_TP2LAB2
{
    [Serializable]
    internal class CasaFinde: Casa
    {
        

        public CasaFinde(string[] ubicacion, int cantPersonas, double precio, bool[] caracteristicas, string descripcion, int minimoDias, Propietario propietario, int id) : base(ubicacion, cantPersonas, precio, caracteristicas, descripcion, minimoDias, propietario, id) {
            //minimoDias = 3;
        }

        public override double CalcularPrecio(int cantDias)
        {
            double precioFinal = 0;
            if (cantDias == 2)
                precioFinal = base.precio * cantDias;
            else throw new Exception("La cantidad de Días no es correcta.");

            return precioFinal;
        }
        public override string ToString()
        {
            return "Casa fin de semana";
        }
    }
}
