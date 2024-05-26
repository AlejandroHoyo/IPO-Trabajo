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
        public string NombreCompletoPaciente{ get; set; }
        public string NombreCompletoSanitario{ get; set; }

        public Plantilla Doctor { get; set; } // Duda

        public Paciente Cliente { get; set; } // Duda
        public string IdentificacionCita
        {
            get
            {
                return Fecha + " " + Hora;
            }
        }
    }
}
