﻿using System;
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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BitmapImage imagCheck = new BitmapImage(new Uri("/Assets/Icons/correct.png", UriKind.Relative));
        private BitmapImage imagCross = new BitmapImage(new Uri("/Assets/Icons/incorrect.png", UriKind.Relative));
        private string usuario = "";
        private string password = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private Boolean ComprobarEntrada(string valorIntroducido, string valorCorrecto,
            Control componenteEntrada, Image imagenFeedBack)
        {
            Boolean valido = false;
            if (valorIntroducido.Equals(valorCorrecto))
            {
              
                componenteEntrada.BorderBrush = Brushes.Green;
                componenteEntrada.Background = Brushes.LightGreen;
                imagenFeedBack.Source = imagCheck;
                valido = true;
            }
            else
            {
                // marcamos borde en rojo
                componenteEntrada.BorderBrush = Brushes.Red;
                componenteEntrada.Background = Brushes.LightCoral;
                // imagen al lado de la entrada de usuario --> cross
                imagenFeedBack.Source = imagCross;
                valido = false;
            }
            return valido;
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.Return)
            {
                if (ComprobarEntrada(txtUsuario.Text, usuario,
                txtUsuario, imgCheckUsuario))
                {
                    // habilitar entrada de contraseña y pasarle el foco
                    passContrasena.IsEnabled = true;
                    passContrasena.Focus();
                    // deshabilitar entrada de login
                    txtUsuario.IsEnabled = false;
                }
            }
        }

        private void btnLogin_Enter(object sender, RoutedEventArgs e)
        {
            // La comprobación ya lleva implícita que las entradas
            // estén vacías
            if (ComprobarEntrada(txtUsuario.Text, usuario,
            txtUsuario, imgCheckUsuario)
            &&
            ComprobarEntrada(passContrasena.Password, password,
            passContrasena, ImgCheckPassword))
            {
                MainMenu menu = new MainMenu();
                menu.Show();
                if (RembemberMe.IsChecked.Value == true)
                    Application.Current.Resources["current_user"] = txtUsuario.Text;
                else
                {
                    Application.Current.Resources["current_user"] = "";
                }
                this.Hide();
            }

        }
        public void Update() // Call whenever the menu logs out
        {
            if (RembemberMe.IsChecked.HasValue)
            {
                txtUsuario.Text = (string)Application.Current.FindResource("current_user");
                Application.Current.Resources["current_user"] = txtUsuario.Text;
            }

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAyuda_Click(object sender, RoutedEventArgs e)
        {
            {
                Helper.ShowAyuda(
                    "Poner vídeo y algunas instrucciones.");
            }
        }
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            Helper.ShowInformacion("Aplicación realizada por Alejandro del Hoyo y Sergio Pozuelo\n" +
                "Versión 0.1.0\n\n" +
                "Es simplemente un prototipo para una clínica fisioterapeútica ");
        }

    }
}
    





