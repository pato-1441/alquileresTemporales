using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace AlquileresTemporarios_TP2LAB2
{
    [Serializable]
    internal class Propietario
    {
        string nombre;
        int dni;

        public string Nombre { get { return nombre;} }
        public int Dni { get {  return dni;} }

        public Propietario(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }
    }
}
