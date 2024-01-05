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
    /// Lógica de interacción para Staff.xaml
    /// </summary>
    public partial class Staff : Window
    {
        public Staff()
        {
            InitializeComponent();
        }
        protected override void OnInitialized(EventArgs e)  // Update information when the window is oppened
        {
            base.OnInitialized(e);
            Update();
        }

        public void Update()
        {
            // TODO: Update the data in the combobox
        }

        private void User_SelectionChanged(object sender, SelectionChangedEventArgs e) // TODO: Change the data when the combobox changes
        {

        }
    }
}
