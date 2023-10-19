using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Runtime.Serialization.Formatters;

namespace AlquileresTemporarios_TP2LAB2
{
    [Serializable]
    internal class Cliente
    {
        int dni;
        string nombre;
        public int Dni
        {
            get { return dni; }
            private set
            {
                Regex verificarDni = new Regex(@"^\\d{1,2}.?\\d{3}.?\\d{3}$");
                if (!verificarDni.IsMatch(value.ToString())) throw new Exception("El DNI no es válido");
            }
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public Cliente (int dni, string nombre)
        {
            this.dni = Dni;
            this.nombre = nombre;
        }
    }
}
