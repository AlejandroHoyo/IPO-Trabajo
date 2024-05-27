using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Lab_IPO
{
    public class Plantilla
    {
         public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }

        public BitmapImage FotoPerfil { get; set; }
        public string Edad { get; set; }
        public string TipoPersonal { get; set; }
        public BitmapImage Logo { get; set; }

        public List<Cita> Citas { get; set; }
        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + Apellidos;
            }
        }
    }
}
