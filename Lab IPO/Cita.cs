using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_IPO
{
    public class Cita
    {
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Duracion { get; set; }
        public string Estado { get; set; }
        public string Sanitario { get; set; }
        public string Paciente { get; set; }
    
        //public Plantilla Sanitario { get; set; } // Duda

        // public Paciente Paciente { get; set; } // Duda
        public string IdentificacionCita
        {
            get
            {
                return Fecha + " " + Hora;
            }
        }
    }
}
