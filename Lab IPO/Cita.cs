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

        // Atributos de paciente
        public string NombrePaciente { get; set; }
        public string ApellidosPaciente { get; set; }
        public string TelefonoPaciente { get; set; }
        public BitmapImage FotoPerfilPaciente { get; set; }

        // Atributos del sanitario
        public string NombreSanitario { get; set; }
        public string ApellidosSanitario { get; set; }
        public string TelefonoSanitario { get; set; }
        public BitmapImage FotoPerfilSanitario { get; set; }

        public string NombreCompletoPaciente
        {
            get
            {
                return NombrePaciente + " " + ApellidosPaciente;
            }
        }
        public string NombreCompletoSanitario
        {
            get
            {
                return NombreSanitario + " " + ApellidosSanitario;
            }
        }
        public string IdentificacionCita
        {
            get
            {
                return Fecha + " " + Hora;
            }
        }
    }
}
