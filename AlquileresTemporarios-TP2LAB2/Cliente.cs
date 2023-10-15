using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquileresTemporarios_TP2LAB2
{
    internal class Cliente
    {
        int dni;
        string nombre;
        public int Dni { get { return dni; } }
        public Cliente (int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }
    }
}
