﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquileresTemporarios_TP2LAB2
{
    [Serializable]
    internal class Usuario
    {
        string nombre;
        string contraseña;
        string tipo;

        public string Nombre
        {
            get { return nombre; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
        }
        public Usuario(string nombre, string contraseña, string tipo)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.tipo = tipo;
        }
    }
}
