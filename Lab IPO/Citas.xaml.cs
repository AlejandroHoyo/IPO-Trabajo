using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para Citas.xaml
    /// </summary>
    public partial class Citas : Page
    {
        private MainMenu mainMenu;
        public Citas(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void ctxCitaAdd_Click(object sender, RoutedEventArgs e)
        {
            mainMenu.frameCitas.Content = new ModificarCitas(mainMenu);
            mainMenu.mainMenuPacientes.IsEnabled = false;
            mainMenu.mainMenuPersonal.IsEnabled = false;
        }
        private void ctxCitaModify_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ctxCitaDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
