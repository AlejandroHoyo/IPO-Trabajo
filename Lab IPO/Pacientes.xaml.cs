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
    /// Lógica de interacción para Pacientes.xaml
    /// </summary>
    public partial class Pacientes : Page
    {
        private MainMenu mainMenu;
        public Pacientes(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void btnImagenesPaciente_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ctxPacienteAdd_Click(object sender, RoutedEventArgs e)
        {
            mainMenu.framePacientes.Content = new ModificarPacientes(mainMenu);
            mainMenu.mainMenuCitas.IsEnabled = false;
            mainMenu.mainMenuPersonal.IsEnabled = false;
        }
        private void ctxPacienteModify_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ctxPacienteDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
