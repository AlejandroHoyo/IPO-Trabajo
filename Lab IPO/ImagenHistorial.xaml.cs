using System;
using System.Collections.Generic;
using System.IO;
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




namespace Lab_IPO
{
    /// <summary>
    /// Lógica de interacción para ImagenHistorial.xaml
    /// </summary>
    public partial class ImagenHistorial : Window
    {
        public MainMenu mainMenu;
        public ImagenHistorial(MainMenu mainMenu)
        {   
            InitializeComponent();
            this.mainMenu = mainMenu;
        }
        public void btnCargarFoto_Click(object sender, RoutedEventArgs e)
        {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "Images|*.png;*.gif;*.jpg;*.jpeg";
            string currentFolder = Directory.GetCurrentDirectory();
            string parentFolder = Directory.GetParent(currentFolder).FullName;
            string imagesFolder = Directory.GetParent(parentFolder).FullName;
            string defintiveFolder = Path.Combine(imagesFolder, "data");
            openDialog.InitialDirectory = defintiveFolder;
            openDialog.ShowDialog();
            try
            {
                var bitmap = new BitmapImage(new Uri(openDialog.FileName, UriKind.Absolute));
                imagenHistorial.Source = bitmap;
               
            }
            catch
            {
                Helper.ShowError("No ha sido posbile cargar la imagen", "Error :(");
            }
        }
        public void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainMenu.IsEnabled = true;
        }

    }

}

