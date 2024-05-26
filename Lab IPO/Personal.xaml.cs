using System;
using System.Collections;
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
    /// Lógica de interacción para Personal.xaml
    /// </summary>
    public partial class Staff : Page
    {
        private MainMenu mainMenu;
        private Context context; 

        public Staff(MainMenu mainMenu, Context context)
        {
            InitializeComponent();

            this.context = context;
            this.mainMenu = mainMenu;
            personalList.ItemsSource = context.ListadoPersonal;

            // Primer elemento seleccionado
            personalList.SelectedIndex = 0; 

        }

        public Plantilla PlantillaSeleccionado
        {
            get
            {
                return (Plantilla)personalList.SelectedItem;
            }
        }

        private void ctxPersonalAdd_Click(object sender, RoutedEventArgs e)
        {
            mainMenu.framePersonal.Content = new ModificarPersonal(new Plantilla(), context, mainMenu);
            mainMenu.mainMenuCitas.IsEnabled = false;
            mainMenu.mainMenuPacientes.IsEnabled = false;
           
        }
        private void ctxPersonalModify_Click(object sender, RoutedEventArgs e)
        {
            mainMenu.framePersonal.Content = new ModificarPersonal(PlantillaSeleccionado, context, mainMenu);
            mainMenu.mainMenuCitas.IsEnabled = false;
            mainMenu.mainMenuPacientes.IsEnabled = false;
        }
        private void ctxPersonalDelete_Click(object sender, RoutedEventArgs e)
        {
            int removeIndex = personalList.SelectedIndex;

            if (removeIndex == -1)
            {
                return;
            }

            var question = Helper.ShowAdvertencia("¿Estás seguro de que quiere eliminar al personal'" + PlantillaSeleccionado.NombreCompleto + "'?", "Verificar confirmación");
            if (question != DialogResult.OK)
                return;

            // Eliminar las citas que tengan asociados un personal sanitario (TODO)

            //foreach (Cita cita in ctx.ListadoCitas)
            //{
            //    // Completar para cuando no exista el tema
            //}


            // Eliminar un personal de la lista 
            context.ListadoPersonal = context.ListadoPersonal.Where(personal => !personal.NombreCompleto.Equals(PlantillaSeleccionado.NombreCompleto)).ToList();
            personalList.ItemsSource = context.ListadoPersonal;

            if (context.ListadoPersonal.Count == 0)
            {
                ctxPersonalModify.IsEnabled = false;
                ctxPersonalDelete.IsEnabled = false;
     
            }
            else
            // Para que me indica un índice cuando se elemine uno
            {
                personalList.SelectedIndex = Math.Min(removeIndex, context.ListadoPersonal.Count - 1);
            }

        }
        //private void DeshabilitarListas()
        ////{
        ////    //Helper.ShowWarning("Hola", "Verificar confirmación");
        ////    if (PlantillaSeleccionado.TipoPersonal.Equals("Limpiza"))
        ////    {
                
        ////        atendidosList.IsEnabled = false;
        ////        citasPrevistasList.IsEnabled = false;

        ////    }

        ////}

        private void comboBox_TipoPersonal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateListaPersonal();
            
        }
        private void listaPersonal_SelectionChanged(object sender, RoutedEventArgs e)
        {
            UpdateListaPersonal();
        }

        public void UpdateListaPersonal()
        {
            if (personalList == null)
            {
                return;
            }
            if (personalList.SelectedIndex == -1)
            {
                personalList.SelectedIndex = 0;
            }

            if (tipoPersonalComboBox.SelectedIndex == 1)
            {
                if (personalList.SelectedIndex == -1)
                {
                    personalList.SelectedIndex = 0;
                }
                personalList.ItemsSource = context.ListadoPersonal.Where(personal => personal.TipoPersonal.Equals("Sanitario")).ToList();
            }
            else if ( tipoPersonalComboBox.SelectedIndex == 2)
            {
                if (personalList.SelectedIndex == -1)
                {
                    personalList.SelectedIndex = 0;
                }
                personalList.ItemsSource = context.ListadoPersonal.Where(personal => personal.TipoPersonal.Equals("Limpieza")).ToList();
            }
            else if (tipoPersonalComboBox.SelectedIndex == 0 && context != null) 
            {
                personalList.ItemsSource = context.ListadoPersonal;
            }

        }
   

    }
}
