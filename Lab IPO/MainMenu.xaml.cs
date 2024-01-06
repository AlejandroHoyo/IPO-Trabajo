using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        // Public windows
        Citas dates = new Citas();
        Patients patients = new Patients();
        Staff staff = new Staff();


        public MainMenu()
        {
            InitializeComponent();
        }


        private bool isClosing = false;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (!isClosing)
            {
                e.Cancel = true;
                isClosing = true;

                Dispatcher.BeginInvoke((Action)(() =>  // Call me Gordon Ramsay because im cooking some spaguetti
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                    main.Update();

                    foreach (Window window in Application.Current.Windows)
                    {
                        if (window != main || window == this)
                        {
                            window.Close();
                        }
                    }

                    isClosing = false;
                }));
            }
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


        protected override void OnInitialized(EventArgs e)  // Update information when the window is opened
        {
            base.OnInitialized(e);
            Update();
        }

        private void Dates_Click(object sender, RoutedEventArgs e)
        {
            dates.Show();
            dates.Update();  // TODO: Implement the Update() method in Citas
            dates.Focus();
        }

        private void Patients_Click(Object sender, RoutedEventArgs e)
        {
            patients.Show();
            patients.Update();  // TODO: Implement the Update() method in Patients 
            patients.Focus();
        }

        private void Staff_Click(object sender, RoutedEventArgs e)
        {
            staff.Show();
            staff.Update();  // TODO: Implement the Update() method in Staff
            staff.Focus();
        }

        public void Update()  // TODO: Find user and update information accordingly
        {

        }
    }
}
