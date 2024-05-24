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
    /// Lógica de interacción para Personal.xaml
    /// </summary>
    public partial class Personal : Page
    {
        private MainMenu mainMenu;

        public Personal(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void ctxPersonalAdd_Click(object sender, RoutedEventArgs e)
        {
            mainMenu.framePersonal.Content = new ModificarPersonal(mainMenu);
            mainMenu.mainMenuCitas.IsEnabled = false;
            mainMenu.mainMenuPacientes.IsEnabled = false;
        }
        private void ctxPersonalModify_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ctxPersonalDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
