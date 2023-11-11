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
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public Cliente (int dni, string nombre)
        {
            this.nombre = nombre;
            Regex verificarDni = new Regex(@"^[0-9]{8}$");
            if (!verificarDni.IsMatch(dni.ToString())) throw new ControlDeUsuarioException();
            {
                this.dni = dni;
            }            
        }
    }
}
