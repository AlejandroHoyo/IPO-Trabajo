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
    /// Lógica de interacción para ModificarPersonal.xaml
    /// </summary>
    public partial class ModificarPersonal : Page
    {
        private MainMenu mainMenu;
        private Context context;
        private Plantilla plantillaElegido;
        private Plantilla plantillaTemp; 
        public ModificarPersonal(Plantilla plantillaElegido, Context context, MainMenu mainMenu)
        {
            InitializeComponent();

            this.mainMenu = mainMenu;
            this.context = context;

            // Se está creando uno nuevo 
           
            if (plantillaElegido.Nombre == null)
            {
                plantillaTemp = new Plantilla
                {
                    // La imagen es la default
                   FotoPerfil = new BitmapImage(new Uri("Assets/Icons/user.png", UriKind.Relative))

                };
             } else
            {
                plantillaTemp = new Plantilla
                {
                    Nombre = plantillaElegido.Nombre,
                    Apellidos = plantillaElegido.Apellidos,
                    Telefono = plantillaElegido.Telefono,
                    Edad = plantillaElegido.Edad,
                    TipoPersonal = plantillaElegido.TipoPersonal,
                    FotoPerfil = plantillaElegido.FotoPerfil,
                    Logo = plantillaElegido.Logo
                };

                int index = plantillaElegido.TipoPersonal.Equals("Sanitario") ? 0 : 1;
                tipoModificarPersonalTextbox.SelectedIndex = index;
            }

            this.plantillaElegido = plantillaElegido;
            
            DataContext = plantillaTemp;
        }
        private bool ComprobarEspaciosVacios(string campo, System.Windows.Controls.TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                Helper.ShowError("El campo '" + campo + "' no tiene que estar vacío", "Error de formato");
                return false;
            }
            return true;
        }
        private void HacerCambios()
        {
            plantillaTemp.TipoPersonal = tipoModificarPersonalTextbox.SelectedIndex == 0 ? "Sanitario" : "Limpieza";
            string pathLogo = plantillaTemp.TipoPersonal.Equals("Sanitario") ? "Assets/Icons/farmacia.png" : "Assets/Icons/escoba.png";
            plantillaTemp.Logo = new BitmapImage(new Uri(pathLogo, UriKind.Relative));
            int referencia = context.ListadoPersonal.FindIndex(plantilla => plantilla.NombreCompleto.Equals(plantillaElegido.NombreCompleto));
            if (referencia != -1) {
                context.ListadoPersonal[referencia] = plantillaTemp;
            }
            else
            {
                context.ListadoPersonal.Add(plantillaTemp);
            }
        }
        private bool ComprobarTodos()
        {
            return ComprobarEspaciosVacios("Nombre", nombreModificarPersonalTextbox) && ComprobarEspaciosVacios("Apellidos", apellidosModificarPersonalTextbox) &&
                ComprobarEspaciosVacios("Telefono", telefonoModificarPersonalTextbox) && ComprobarEspaciosVacios("Edad", edadModificarPersonalTextbox);


        }
        private void btnCambiarFotoPersonal_Click(object sender, RoutedEventArgs e)
        {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "Images|*.png;*.gif;*.jpg;*.jpeg"; 
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var bitmap = new BitmapImage(new Uri(openDialog.FileName, UriKind.Absolute));
                    imagenPefil.Source = bitmap;
                    plantillaTemp.FotoPerfil = bitmap;
                }
                catch
                {
                    Helper.ShowError("No ha sido posbile cargar la imagen", "Error :(");
                }
            }

    }
        private void btnConfirmarCambiosPersonal_Click(object sender, RoutedEventArgs e)
        {
            if (!ComprobarTodos())
            {
                return;
            }

            var question = Helper.ShowAdvertencia("¿Seguro que quieres aceptar los cambios?", "Aceptar cambios");
            if (question == DialogResult.Cancel)
                return;
            HacerCambios();

            var list = mainMenu.personalPage.personalList;
            list.Items.Refresh();
            list.SelectedIndex = context.ListadoPersonal.FindIndex(plantila => plantila.NombreCompleto.Equals(plantillaTemp.NombreCompleto));
            list.Focus();

            mainMenu.framePersonal.Content = mainMenu.personalPage;
            mainMenu.mainMenuCitas.IsEnabled = true;
            mainMenu.mainMenuPacientes.IsEnabled = true;
            list.Items.Refresh();
            mainMenu.personalPage.ctxPersonalModify.IsEnabled = true;
            mainMenu.personalPage.ctxPersonalDelete.IsEnabled = true;
        }
        private void btnBorrarCambiosPersonal_Click(object sender, RoutedEventArgs e)
        {
            var question = Helper.ShowAdvertencia("¿Seguro que quiere borrar los cambios?", "Borrar cambios");
            if (question == DialogResult.Cancel)
                return;
            mainMenu.mainMenuCitas.IsEnabled = true;
            mainMenu.mainMenuPacientes.IsEnabled = true;
            mainMenu.framePersonal.Content = mainMenu.personalPage;
        }
    }
}
