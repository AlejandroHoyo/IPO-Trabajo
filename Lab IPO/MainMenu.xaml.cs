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
        public Staff personalPage;
        public Citas citasPage;
        public Pacientes pacientesPage;
        public Context context;

        public MainMenu()
        {
            InitializeComponent();

            Context context = new Context();

            personalPage = new Staff(this, context);
            citasPage = new Citas(this, context);
            pacientesPage = new Pacientes(this, context);

            framePersonal.Content = personalPage;
            frameCitas.Content = citasPage;
            framePacientes.Content = pacientesPage;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAyuda_Click(object sender, RoutedEventArgs e)
        {
            {
                Helper.ShowAyuda(
                    "Las instrucciones sobre cómo se debe de usar la interfaz se encuentran en el siguiente enlace: <url>");
            }
        }
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            Helper.ShowInformacion("Aplicación realizada por Alejandro del Hoyo y Sergio Pozuelo\n" +
                "Versión Definitiva\n" +
                "Es simplemente un prototipo para una clínica fisioterapeútica ");
        }

        private bool isClosing = false;
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)  // Kidnap the closing function to change it's action
        {
            if (!isClosing)
            {
                e.Cancel = true;
                isClosing = true;

                Dispatcher.BeginInvoke((Action)(() =>  // Call me Gordon Ramsay because im cooking some spaguetti
                {
                    var result = Helper.ShowAdvertencia("¿Está seguro de que desea cerrar sesión?", "Cerrar Sesión");

                    if (result != System.Windows.Forms.DialogResult.OK)
                    {
                        isClosing = false;
                        return;
                    }
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
    }
}
