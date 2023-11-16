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
using System.Globalization;

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
        
        public double TotalRecaudado() {
            double totalRecaudado = 0;
            foreach(Reserva reserva in reservas) {
                totalRecaudado += reserva.Costo;
            }
            return totalRecaudado;
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

        public bool ImportarCalendario()
        {
            FileStream calendario = null;
            StreamReader sr = null;
            OpenFileDialog opf = null;
            bool exito = true;
            try
            {
                // Reserva(int codigo, int idPropiedad, DateTime fechaInicio, DateTime fechaFin, int cantPersonas, double costo, Cliente cliente)
                Reserva reserva = null;
                Cliente cliente = null;
                int idProp, nroReserva, cantPersonas;
                double costo;

                opf = new OpenFileDialog();
                if (opf.ShowDialog() == DialogResult.OK)
                {

                    calendario = new FileStream(opf.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(calendario);
                    string lineaEntera = sr.ReadLine();
                    string[] linea;

                    if (lineaEntera != null) linea = lineaEntera.Split(',');
                    else throw new Exception("El archivo está vació");

                    idProp = Convert.ToInt32(linea[1].Trim());
                    lineaEntera = sr.ReadLine();


                    while (lineaEntera != null)
                    {
                        linea = lineaEntera.Split(',');
                        nroReserva = Convert.ToInt32(linea[0].Trim());
                        string fechaEntrada = linea[1].Trim();
                        string fechaSalida = linea[2].Trim();
                        DateTime fechaInicio = DateTime.ParseExact(fechaEntrada, "d/M/yyyy H:mm:ss", CultureInfo.InvariantCulture);
                        DateTime nuevaFechaInicio = new DateTime(fechaInicio.Year, fechaInicio.Month, fechaInicio.Day,
                                                                         fechaInicio.Hour, fechaInicio.Minute, fechaInicio.Second);
                        DateTime fechaFinal = DateTime.ParseExact(fechaSalida, "d/M/yyyy H:mm:ss", CultureInfo.InvariantCulture);
                        DateTime nuevaFechaFin = new DateTime(fechaFinal.Year, fechaFinal.Month, fechaFinal.Day,
                                                                     fechaFinal.Hour, fechaFinal.Minute, fechaFinal.Second);
                        cliente = new Cliente(Convert.ToInt32(linea[4].Trim()), linea[3].Trim());
                        cantPersonas = Convert.ToInt32(linea[5].Trim());
                        costo = Convert.ToDouble(linea[6].Trim());
                        

                        


                        bool reservaExiste = false;
                        // linea = reserva.NroReserva.ToString() + ", " + reserva.FechaInicio.ToString() + ", " + reserva.FechaFin.ToString() + ", " + reserva.Cliente.Nombre.ToString() []3+ ", " + reserva.Cliente.Dni.ToString() + ", " + reserva.CantPersonas.ToString() + " " + reserva.Costo.ToString("$00,00");

                        foreach (Reserva existeReserva in reservas)
                        {
                            if (existeReserva.NroReserva == nroReserva)
                            {
                                reservaExiste = true;
                            }
/*(existeReserva.IdPropiedad == this.id && (fechaInicio >= existeReserva.FechaInicio && fechaInicio <= existeReserva.FechaFin) ||
                                (fechaFinal >= existeReserva.FechaInicio && fechaFinal <= existeReserva.FechaFin))*/
                            // Verificar si hay reservas en las mismas fechas para las mismas propiedades
                            if (existeReserva.IdPropiedad == this.id && !((fechaFinal<existeReserva.FechaInicio && fechaInicio<fechaFinal)||(fechaInicio>existeReserva.FechaFin && fechaFinal>fechaInicio))) 
                            {
                                reservaExiste = true;
                            }
                        }

                        // Si no existe, crea la reserva y la agrega a la lista
                        if (!reservaExiste)
                        {
                            if (nuevaFechaInicio >= DateTime.Now && nuevaFechaFin > nuevaFechaInicio)
                                reserva = new Reserva(nroReserva, idProp, nuevaFechaInicio, nuevaFechaFin, cantPersonas, costo, cliente);
                            else exito = false;
                               reservas.Add(reserva);
                        }
                        lineaEntera = sr.ReadLine();
                    }
                    

                }


            }
            catch (Exception ex)
            {
                exito = false;
                throw new Exception(ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (calendario != null) calendario.Dispose();
            }
            return exito;
        }
        public void ExportarCalendario()
        {
            FileStream calendario = null;
            StreamWriter sw = null;
            string ruta = Application.StartupPath + "/calendario" + this.id.ToString() + ".txt";
            try
            {
                calendario = new FileStream(ruta, FileMode.Create, FileAccess.Write);
                string linea = this.ToString() + ", " + this.IdPropiedad.ToString();
                sw = new StreamWriter(calendario);
                sw.WriteLine(linea);
                foreach (Reserva reserva in reservas)
                {
                    linea = reserva.NroReserva.ToString() + ", " + reserva.FechaInicio.ToString() + ", " + reserva.FechaFin.ToString() + ", " + reserva.Cliente.Nombre.ToString() + ", " + reserva.Cliente.Dni.ToString() + ", " + reserva.CantPersonas.ToString() + ", " + reserva.Costo.ToString();
                    sw.WriteLine(linea);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (sw != null) sw.Close();
                if (calendario != null) calendario.Dispose();
            }
        }

    }
}
