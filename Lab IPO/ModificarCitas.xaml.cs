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
    /// Lógica de interacción para ModificarCitas.xaml
    /// </summary>
    public partial class ModificarCitas : Page
    {
        private MainMenu mainMenu;
        public ModificarCitas(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void btnConfirmarCambiosCita_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnBorrarCambiosCita_Click(object sender, RoutedEventArgs e)
        {

        }

    } 
}
