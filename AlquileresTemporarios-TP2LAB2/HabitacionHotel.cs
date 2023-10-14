﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquileresTemporarios_TP2LAB2
{
    internal class HabitacionHotel:Propiedad
    {
        string nombreHotel;
        int estrellas;
        int tipo;
        int num;

        public HabitacionHotel ( string ubicacion, int cantPersonas, double precio, int[] caracteristicas, string nombreHotel, int num, int tipo) : base(ubicacion, cantPersonas,precio, caracteristicas)
        {
            this.nombreHotel = nombreHotel;
            this.num = num;
            this.tipo = tipo;
        }


    }
}
