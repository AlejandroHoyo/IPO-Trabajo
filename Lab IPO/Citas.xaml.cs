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
    /// Lógica de interacción para Citas.xaml
    /// </summary>
    public partial class Citas : Window
    {
        public Citas()
        {
            InitializeComponent();
        }

        protected override void OnInitialized(EventArgs e)  // Update information when the window is oppened
        {
            base.OnInitialized(e);
            Update();
        }

        public void Update()  // Update the screen
        {

        }

        public void Clean_Click(object sender, RoutedEventArgs e)
        {
            Fecha.SelectedDate = DateTime.Today;  // Reset to today's date as it can't be empty
            Cliente.Clear();
            Doctor.Clear();
        }

        public void Modify_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Change current date values to what there is on the fields (Date is identifies by the, well... date)
        }

        public void Save_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Create a new date object with the information in the fields
        }
    }
}
