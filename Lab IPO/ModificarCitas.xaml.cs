using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
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
    /// Lógica de interacción para ModificarCitas.xaml
    /// </summary>
    public partial class ModificarCitas : Page
    {
        private Context context;
        private MainMenu mainMenu;
        private Cita citaElegida;
        private Cita citaTemp;
        public ModificarCitas(Cita citaElegida, Context context, MainMenu mainMenu)
        {
            InitializeComponent();

            this.mainMenu = mainMenu;
            this.context = context;
            this.citaElegida = citaElegida;

            pacienteModificarCitaCombobox.ItemsSource = context.ListadoPacientes.Select(paciente => paciente.NombreCompleto).ToList();
            doctorModificarCitaCombobox.ItemsSource = context.ListadoPersonal.Where(personal => personal.TipoPersonal.Equals("Sanitario")).Select(doctor => doctor.NombreCompleto).ToList();

            // Se está creando uno nuevo 
            if (citaElegida.Fecha == null)
            {
                citaTemp = new Cita
                {

                };
                pacienteModificarCitaCombobox.SelectedIndex = 0;
                doctorModificarCitaCombobox.SelectedIndex = 0;
            } else
            {
                citaTemp = new Cita
                {
                    Fecha = citaElegida.Fecha,
                    Hora = citaElegida.Hora,
                    Duracion = citaElegida.Duracion,
                    Estado = citaElegida.Estado,
                    NombreCompletoSanitario = citaElegida.NombreCompletoSanitario,
                    NombreCompletoPaciente = citaElegida.NombreCompletoPaciente
                };

                int index = citaElegida.Estado.Equals("Pendiente") ? 0 : 1;
                estadoModificarCitaComboBox.SelectedIndex = index;
                pacienteModificarCitaCombobox.SelectedItem = citaTemp.NombreCompletoPaciente;
                doctorModificarCitaCombobox.SelectedItem = citaTemp.NombreCompletoSanitario;
                fechaModificarCitaDate.SelectedDate = DateTime.ParseExact(citaTemp.Fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }

            DataContext = citaTemp;

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
            citaTemp.NombreCompletoPaciente = pacienteModificarCitaCombobox.SelectedValue.ToString();
            citaTemp.NombreCompletoSanitario = doctorModificarCitaCombobox.SelectedValue.ToString();
            citaTemp.Fecha = ((DateTime)(fechaModificarCitaDate.SelectedDate)).ToString("dd/MM/yyyy");
            citaTemp.Estado = estadoModificarCitaComboBox.SelectedIndex == 0 ? "Pendiente" : "Completada";
            int referencia = context.ListadoCitas.FindIndex(cita => cita.IdentificacionCita.Equals(citaElegida.IdentificacionCita));
            if (referencia != -1)
            {
                context.ListadoCitas[referencia] = citaTemp;
                Plantilla doctorSeleccionado = context.ListadoPersonal.Find(doctor => doctor.NombreCompleto.Equals(citaTemp.NombreCompletoSanitario));
                doctorSeleccionado.Citas = context.ListadoCitas.FindAll(cita => cita.NombreCompletoSanitario.Contains(doctorSeleccionado.NombreCompleto));

                Paciente pacienteSeleccionado = context.ListadoPacientes.Find(paciente => paciente.NombreCompleto.Equals(citaTemp.NombreCompletoPaciente));
                pacienteSeleccionado.Citas = context.ListadoCitas.FindAll(cita => cita.NombreCompletoPaciente.Contains(pacienteSeleccionado.NombreCompleto));

    
            }
            else
            {
                context.ListadoCitas.Add(citaTemp);
            }
        }

        private bool ComprobarTodos()
        {
            return ComprobarEspaciosVacios("Hora", horaModificarCitaTextbox) && ComprobarEspaciosVacios("Duracion", duracionModificarCitaTextbox);
        }
        private void btnConfirmarCambiosCita_Click(object sender, RoutedEventArgs e)
        {
            if (!ComprobarTodos())
            {
                return;
            }

            if (fechaModificarCitaDate.SelectedDate == null)
            {
                Helper.ShowError("La Fecha del historial no puede estar vacía. Seleccione una", "Campo vacío");
                return;
            }

            var question = Helper.ShowAdvertencia("¿Seguro que quieres aceptar los cambios?", "Aceptar cambios");
            if (question == DialogResult.Cancel)
                return;

            HacerCambios();

            var list = mainMenu.citasPage.citasList;
            list.Items.Refresh();
            list.SelectedIndex = context.ListadoCitas.FindIndex(cita => cita.IdentificacionCita.Equals(citaTemp.IdentificacionCita));
            list.Focus();

            mainMenu.mainMenuPacientes.IsEnabled = true;
            mainMenu.mainMenuPersonal.IsEnabled = true;
            mainMenu.frameCitas.Content = mainMenu.citasPage;


            list.Items.Refresh();
            mainMenu.citasPage.ctxCitaDelete.IsEnabled = true;
            mainMenu.citasPage.ctxCitaModify.IsEnabled = true;
        }
        private void btnBorrarCambiosCita_Click(object sender, RoutedEventArgs e)
        {
            var question = Helper.ShowAdvertencia("¿Seguro que quiere borrar los cambios?", "Borrar cambios");
            if (question == DialogResult.Cancel)
                return;
            mainMenu.mainMenuPersonal.IsEnabled = true;
            mainMenu.mainMenuPacientes.IsEnabled = true;
            mainMenu.frameCitas.Content = mainMenu.citasPage;

        }

    } 
}
