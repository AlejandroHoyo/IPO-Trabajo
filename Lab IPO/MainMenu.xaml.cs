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
using System.Windows.Shapes;

namespace Lab_IPO
{
    /// <summary>
    /// Lógica de interacción para MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

       private void Logout_Click(object sender, RoutedEventArgs e)  // Close all windows and show the login screen again
        {
            MainWindow main = new MainWindow();
            main.Show();
            main.Update();
            foreach (Window window in Application.Current.Windows)
            {
               if (window != main)
                {
                    window.Close();
                }
            }
        }

        protected override void OnInitialized(EventArgs e)  // Update information when the window is oppened
        {
            base.OnInitialized(e);
            Update();
        }

        private void Dates_Click(object sender, RoutedEventArgs e)
        {
            Citas dates = new Citas();  // I know everithing is in english inside beside this window but renaming it requires to redo it again
            dates.Show();
            dates.Update();  // TODO: Implement the Update() method in Citas
        }

        private void Patients_Click(Object sender, RoutedEventArgs e)
        {
            Patients patients = new Patients();
            patients.Show();
            patients.Update();  // TODO: Implement the Update() method in Patients 
        }

        private void Staff_Click(object sender, RoutedEventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            staff.Update();  // TODO: Implement the Update() method in Staff
        }

        public void Update()  // TODO: Find user and update information accordingly
        {

        }
    }
}
