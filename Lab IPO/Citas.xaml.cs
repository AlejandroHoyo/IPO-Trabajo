using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_IPO
{
    /// <summary>
    /// Lógica de interacción para Citas.xaml
    /// </summary>
    public partial class Citas : Page
    {
        private MainMenu mainMenu;
        private Context context;
        public Citas(MainMenu mainMenu, Context context)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            this.context = context;
        }

        public Cita CitaSeleccionada
        {
            get
            {
                return (Cita)citasList.SelectedItem;
            }
        }

        private void ctxCitaAdd_Click(object sender, RoutedEventArgs e)
        {
            mainMenu.frameCitas.Content = new ModificarCitas(new Cita(), context, mainMenu);
            mainMenu.mainMenuPacientes.IsEnabled = false;
            mainMenu.mainMenuPersonal.IsEnabled = false;
        }
        private void ctxCitaModify_Click(object sender, RoutedEventArgs e)
        {
            mainMenu.frameCitas.Content = new ModificarCitas(CitaSeleccionada, context, mainMenu);
            mainMenu.mainMenuPacientes.IsEnabled = false;
            mainMenu.mainMenuPersonal.IsEnabled = false;
        }
        private void ctxCitaDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
