using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Lab_IPO
{
    public class Cita
    {
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Duracion { get; set; }
        public string Estado { get; set; }

        public string NombreCompletoPaciente { get; set; }

        public string NombreCompletoSanitario { get; set; }

        //// Atributos de paciente
        //public string NombrePaciente;
        //public string ApellidosPaciente;
        //public string TelefonoPaciente;
        //public BitmapImage FotoPerfilPaciente;

        //// Atributos del sanitario
        //public string NombreSanitario;
        //public string ApellidosSanitario;
        //public string TelefonoSanitario;
        //public BitmapImage FotoPerfilSanitario;



        //public string NombreCompletoPaciente
        //{
        //    get
        //    {
        //        return NombrePaciente + " " + ApellidosPaciente; 
        //    }
        //}

        //public string NombreCompletoSanitario
        //{
        //    get
        //    {
        //        return NombreSanitario + " " + ApellidosSanitario;
        //    }
        //}
        public string IdentificacionCita
        {
            get
            {
                return Fecha + " " + Hora;
            }
        }
    }
}
