using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_IPO
{
    /// <summary>
    /// Lógica de interacción para ModificarCitas.xaml
    /// </summary>
    public partial class ModificarCitas : Page
    {
        private Context context;
        private MainMenu mainMenu;
        private Cita citaElegida;
        private Cita citaTemp;
        public ModificarCitas(Cita citaElegida, Context context, MainMenu mainMenu)
        {
            InitializeComponent();

            this.mainMenu = mainMenu;
            this.context = context;

            // Se está creando uno nuevo 
            if (citaElegida.Fecha == null)
            {
                citaTemp = new Cita();
            }
            else
            {
                citaTemp = new Cita
                {
                    Fecha = citaElegida.Fecha,
                    Hora = citaElegida.Hora,
                    Duracion = citaElegida.Duracion,
                    Estado = citaElegida.Estado,
                    Sanitario = citaElegida.Sanitario,
                    Paciente = citaElegida.Paciente
                };
                int index = citaElegida.Estado.Equals("Completada") ? 0 : 1;
                estadoModificarPersonalComboBox.SelectedIndex = index;
            }

            this.citaElegida = citaElegida;

            DataContext = citaTemp;

        }
       

        private void btnConfirmarCambiosCita_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnBorrarCambiosCita_Click(object sender, RoutedEventArgs e)
        {

        }

    } 
}
