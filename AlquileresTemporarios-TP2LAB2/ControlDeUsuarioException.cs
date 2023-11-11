using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquileresTemporarios_TP2LAB2
{
    internal class ControlDeUsuarioException:Exception
    {
        public ControlDeUsuarioException() : base("El dni no es válido") { }
        public ControlDeUsuarioException(string message) : base(message) { }
        public ControlDeUsuarioException(string message,  Exception innerException) : base(message, innerException) { }

    }
}
