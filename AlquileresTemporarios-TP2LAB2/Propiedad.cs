using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization;
using System.Runtime.InteropServices.WindowsRuntime;
using System.IO;
using System.Windows.Forms;

namespace AlquileresTemporarios_TP2LAB2 
{
    [Serializable]
    internal  abstract class Propiedad
    {
        int id;
        string[] ubicacion;
        int cantPersonas;
        protected double precio;
        string descripcion;
        bool[] caracteristicas;
        Image[] imagenesPropiedad;
        List<Reserva> reservas;
        
        public int IdPropiedad { get { return id; } }
        public double Precio { get { return precio; } }
        public int CantPersonas
        {
            get { return cantPersonas; }
        }
        

        public string[] Ubicacion
        {
            get { return ubicacion; }
        }

        public bool[] Caracteristicas
        {
            get { return caracteristicas; }
        }

        public List<Reserva> Reservas
        {
            get { return reservas; }
        }

        public Propiedad(string[] ubicacion, int cantPersonas, double precio, bool[] caracteristicas, string descripcion, int id)
        {
            reservas = new List<Reserva>();
            this.ubicacion = ubicacion;
            this.cantPersonas = cantPersonas;
            this.precio = precio;
            this.caracteristicas = caracteristicas;
            this.descripcion = descripcion;
            this.id = id;
        }

        public Image[] ImagenPropiedad { get { return imagenesPropiedad; } }
        public string Descripcion { get { return descripcion; } }
        public void AñadirImagenes(List<Image> listaImagenes)
        {
            imagenesPropiedad=new Image[listaImagenes.Count];
            for(int i = 0; i < imagenesPropiedad.Count(); i++)
            {
                imagenesPropiedad[i] = listaImagenes[i];
            }
        }
        

        public abstract double CalcularPrecio(int cantDias);

        public bool AgregarReserva(Reserva reserva)
        {
            bool exito = true;
            if (reservas.Contains(reserva))
                exito = false;
            else reservas.Add(reserva);
            return exito;
            
        }

        public bool QuitarReserva(int nroReserva, int dni) { 
            bool exito = false;
            List<Reserva> reservasBuscadas=new List<Reserva>();
            foreach (Reserva reserva in reservas)
            {
                reservasBuscadas.Add(reserva);
            }            
            foreach(Reserva reserva in reservasBuscadas)
            {
                if (nroReserva == reserva.NroReserva && dni == reserva.Cliente.Dni) {
                    reserva.Cliente.QuitarReserva(reserva.NroReserva);
                    reservas.Remove(reserva);
                    exito = true;
                }
            }
            return exito;
        }
        public Reserva DevolverReserva(int nroReserva)
        {
            Reserva reserva = null;
            bool encontrado = false;
            int cont = 0;
            while (!encontrado && cont < reservas.Count)
            {
                if (reservas[cont].NroReserva == nroReserva)
                {
                    reserva = reservas[cont];
                    encontrado = true;
                }
                cont++;
            }
            return reserva;
        }
        public bool ModificarPropiedad(double nuevoPrecio, string nuevaDescripcion, bool[] caracteristicas, int cantPersonas)
        {
            bool exito = false;
            try
            {
                precio = nuevoPrecio;
                descripcion = nuevaDescripcion;
                this.caracteristicas = caracteristicas;
                this.cantPersonas = cantPersonas;
                exito = true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return exito;
        }

        public void ExportarCalendario()
        {
            FileStream calendario = null;
            StreamWriter sw = null;
            string ruta = Application.StartupPath + "/calendario.txt";
            try
            {
                calendario = new FileStream(ruta, FileMode.Create, FileAccess.Write);
                string linea = this.ToString() + this.IdPropiedad.ToString();
                sw = new StreamWriter(linea);
                foreach (Reserva reserva in reservas)
                {
                    linea = "Desde: " + reserva.FechaInicio.ToShortTimeString() + ", Hasta: " + reserva.FechaFin.ToShortTimeString() + ", nro de reserva: " + reserva.NroReserva;
                    sw.WriteLine(linea);
                }
            }
            catch (Exception e) 
            { 
                throw new Exception (e.Message);
            }
            finally
            {
                if (sw != null) sw.Close();
                if(calendario != null) calendario.Dispose();
            }
        }

    }
}
