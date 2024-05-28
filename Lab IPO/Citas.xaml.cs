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
    /// Lógica de interacción para Citas.xaml
    /// </summary>
    public partial class Citas : Page
    {
        private MainMenu mainMenu;
        private Context context;
        public Citas(MainMenu mainMenu, Context context)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            this.context = context;
            citasList.ItemsSource = context.ListadoCitas;
            // Primer elemento seleccionado
            citasList.SelectedIndex = 0; 
        }
        public Cita CitaSeleccionada
        {
            get
            {
                return (Cita)citasList.SelectedItem;
            }
        }

        private void ctxCitaAdd_Click(object sender, RoutedEventArgs e)
        {
            mainMenu.frameCitas.Content = new ModificarCitas(new Cita(), context, mainMenu);
            mainMenu.mainMenuPacientes.IsEnabled = false;
            mainMenu.mainMenuPersonal.IsEnabled = false;
        }
        private void ctxCitaModify_Click(object sender, RoutedEventArgs e)
        {
            mainMenu.frameCitas.Content = new ModificarCitas(CitaSeleccionada, context, mainMenu);
            mainMenu.mainMenuPacientes.IsEnabled = false;
            mainMenu.mainMenuPersonal.IsEnabled = false;
        }
        private void ctxCitaDelete_Click(object sender, RoutedEventArgs e)
        {
            int removeIndex = citasList.SelectedIndex;

            if (removeIndex == -1)
            {
                return;
            }
            var question = Helper.ShowAdvertencia("¿Estás seguro de que quiere eliminar la cita'" + CitaSeleccionada.IdentificacionCita + "'?", "Verificar confirmación");
            if (question != DialogResult.OK)
                return;

            // Eliminar una cita de la lista
            context.ListadoCitas = context.ListadoCitas.Where(cita => !cita.IdentificacionCita.Equals(CitaSeleccionada.IdentificacionCita)).ToList();
            citasList.ItemsSource = context.ListadoCitas;


            foreach (Paciente paciente in context.ListadoPacientes)
            {
                paciente.Citas = context.ListadoCitas.FindAll((cita => cita.NombreCompletoPaciente.Equals(paciente.NombreCompleto)));
            }
            mainMenu.pacientesPage.ActualizarListaCitas();

            foreach (Plantilla doctor in context.ListadoPersonal)
            {
                doctor.Citas = context.ListadoCitas.FindAll((cita => cita.NombreCompletoSanitario.Equals(doctor.NombreCompleto)));
            }
            mainMenu.personalPage.ActualizarListaCitasPrevistas();
            mainMenu.personalPage.ActualizarListaPacientesAtendidos();

            if (context.ListadoCitas.Count == 0)
            {

                ctxCitaModify.IsEnabled = false;
                ctxCitaDelete.IsEnabled = false;

            }
            else
                // Para que me indica un índice cuando se elemine uno
            {
                citasList.SelectedIndex = Math.Min(removeIndex, context.ListadoPersonal.Count - 1);
            }
        }


        private void HyperLinkPaciente_Click(object sender, RoutedEventArgs e)
        {
            mainMenu.tabularControl.SelectedIndex = 0;

            Pacientes pacientesPagina = mainMenu.pacientesPage;
            int pacienteIndex = context.ListadoPacientes.FindIndex(paciente => paciente.NombreCompleto.Equals(CitaSeleccionada.NombreCompletoPaciente));
            pacientesPagina.pacientesList.SelectedIndex = pacienteIndex; 
        }
        private void HyperLinkSanitario_Click(Object sender, RoutedEventArgs e)
        {
            mainMenu.tabularControl.SelectedIndex = 1;

            Staff personalPagina = mainMenu.personalPage;
            int personalIndex = context.ListadoPersonal.FindIndex(sanitario => sanitario.NombreCompleto.Equals(CitaSeleccionada.NombreCompletoSanitario));
            personalPagina.personalList.SelectedIndex = personalIndex;
        }
        public void UpdateListaCitas()
        {
            if (citasList == null)
            {
                return;
            }
            if (citasList.SelectedIndex == -1)
            {
                citasList.SelectedIndex = 0;
            }

            if (tipoCitaComboBox.SelectedIndex == 1)
            {
                if (citasList.SelectedIndex == -1)
                {
                    citasList.SelectedIndex = 0;
                }
                citasList.ItemsSource = context.ListadoCitas.Where(cita => cita.Estado.Equals("Completada")).ToList();
            }
            else if (tipoCitaComboBox.SelectedIndex == 2)
            {
                if (citasList.SelectedIndex == -1)
                {
                    citasList.SelectedIndex = 0;
                }
                citasList.ItemsSource = context.ListadoCitas.Where(cita => cita.Estado.Equals("Pendiente")).ToList();
            }
            else if (tipoCitaComboBox.SelectedIndex == 0 && context != null)
            {
                citasList.ItemsSource = context.ListadoCitas;
            }

        }
         private void comboBox_TipoCita_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateListaCitas();

        }
        private void listaCita_SelectionChanged(object sender, RoutedEventArgs e)
        {
            UpdateListaCitas();
        }

    }
}

