using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
    /// Lógica de interacción para Pacientes.xaml
    /// </summary>
    public partial class Pacientes : Page
    {
        private Context context;
        private MainMenu mainMenu;
        public Pacientes(MainMenu mainMenu, Context context)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            this.context = context;

            pacientesList.ItemsSource = context.ListadoPacientes;
            // De forma predeterminada se elige el elemento 0
            pacientesList.SelectedIndex = 0;
            citasPacienteList.ItemsSource = PacienteSeleccionado.Citas;
            
        }
        public Paciente PacienteSeleccionado
        {
            get
            {
                return (Paciente)pacientesList.SelectedItem;
            }
        }

        private void listaPacientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            historialesPacienteList.SelectedIndex = 0; 
            UpdateListaPacientes();
            ActualizarListaCitas();

        }

        private void comboBox_TipoPaciente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateListaPacientes();
            ActualizarListaCitas();
        }

        private void comboBoxTipoCitaPaciente_SelectionChanged(Object sender, SelectionChangedEventArgs e)
        {
            ActualizarListaCitas();
        }

        public void ActualizarListaCitas()
        {
            // Está vacía y no se indica nada
            if (citasPacienteList == null || PacienteSeleccionado == null)
            {
                return;
            }
            if (tipoCitaPacienteComboBox.SelectedIndex == 1)
            {
                citasPacienteList.ItemsSource = PacienteSeleccionado.Citas.Where(cita => cita.Estado.Equals("Completada")).ToList();

            } else if (tipoCitaPacienteComboBox.SelectedIndex == 2)
            {
               citasPacienteList.ItemsSource = PacienteSeleccionado.Citas.Where(cita => cita.Estado.Equals("Pendiente")).ToList();

            } else
            {
                citasPacienteList.ItemsSource = PacienteSeleccionado.Citas;
            }
        }

        private void btnImagenesHistorial_Click(object sender, RoutedEventArgs e)
        {

            // De momento le pongo disable. Debatirlo con Sergio
        }

        private void citasPacientesMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // No se está seleccionando nada
            if (citasPacienteList.SelectedItem == null)
            {
                return;
            }

            mainMenu.tabularControl.SelectedIndex = 2;
            Citas citasPagina = mainMenu.citasPage;

            citasPagina.tipoCitaComboBox.SelectedIndex = 0;

            Cita citaElegida = (Cita)citasPacienteList.SelectedItem;
            int citaIndex = context.ListadoCitas.FindIndex(cita => cita.IdentificacionCita.Equals(citaElegida.IdentificacionCita));
            citasPagina.citasList.SelectedIndex = citaIndex;

        }
        private void ctxPacienteAdd_Click(object sender, RoutedEventArgs e)
        {
            mainMenu.framePacientes.Content = new ModificarPacientes(new Paciente(), context, mainMenu);
            mainMenu.mainMenuCitas.IsEnabled = false;
            mainMenu.mainMenuPersonal.IsEnabled = false;
        }
        private void ctxPacienteModify_Click(object sender, RoutedEventArgs e)
        {
            mainMenu.framePacientes.Content = new ModificarPacientes(PacienteSeleccionado, context, mainMenu);
            mainMenu.mainMenuCitas.IsEnabled = false;
            mainMenu.mainMenuPersonal.IsEnabled = false;

        }
        private void UpdateListaPacientes()
        {
            if (pacientesList == null)
            {
                return;
            }

            if (pacientesList.SelectedIndex == -1)
            {
                pacientesList.SelectedIndex = 0;
            }

            if (tipoPacienteComboBox.SelectedIndex == 1)
            {
                if (pacientesList.SelectedIndex == -1)
                {
                    pacientesList.SelectedIndex = 0;
                }
                pacientesList.ItemsSource = context.ListadoPacientes.Where(paciente => paciente.Sexo.Equals("Hombre")).ToList();

            }
            else if (tipoPacienteComboBox.SelectedIndex == 2)
            {
                if (pacientesList.SelectedIndex == -1)
                {
                    pacientesList.SelectedIndex = 0;
                }
                pacientesList.ItemsSource = context.ListadoPacientes.Where(paciente => paciente.Sexo.Equals("Mujer")).ToList();
            }
            else if (tipoPacienteComboBox.SelectedIndex == 0 && context != null)
            {
                pacientesList.ItemsSource = context.ListadoPacientes;
            }

        }
        private void ctxPacienteDelete_Click(object sender, RoutedEventArgs e)
        {
            int removeIndex = pacientesList.SelectedIndex;
            if (removeIndex == -1)
            {
                return;
            }
            var question = Helper.ShowAdvertencia("¿Estás seguro de que quiere eliminar al paciente'" + PacienteSeleccionado.NombreCompleto + "'?", "Verificar confirmación");
            if (question != DialogResult.OK)
                return;

            // Eliminar un paciente de la lista

            context.ListadoPacientes = context.ListadoPacientes.Where(paciente => !paciente.NombreCompleto.Equals(PacienteSeleccionado.NombreCompleto)).ToList();
            pacientesList.ItemsSource = context.ListadoPacientes;

            if (context.ListadoPacientes.Count == 0)
            {
                ctxPacienteModify.IsEnabled = false; 
                ctxPacienteDelete.IsEnabled = false;
               
            }
            else

            // Para que me indica un índice cuando se elemine uno
            {
                pacientesList.SelectedIndex = Math.Min(removeIndex, context.ListadoPacientes.Count - 1);
            }


            // Eliminar las citas que corresponden a ese paciente
            // Un paciente tiene una lista de citas

            //foreach (Cita cita in context.ListadoCitas)
            //{
            //    cita.Rutas = ctx.ListadoRutas
            //     .Where(paciente => paciente.ExcursionistasApuntados.Contains(exc.NombreCompleto))
            //     .ToList();

            //}
        }

    }
}
