﻿using System;
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
    /// Lógica de interacción para ModificarPacientes.xaml
    /// </summary>
    public partial class ModificarPacientes : Page
    {
        private Context context; 
        private MainMenu mainMenu;
        private Paciente pacienteElegido;
        private Paciente pacienteTemp;
        public ModificarPacientes(Paciente pacienteElegido, Context context, MainMenu mainMenu)
        {
            InitializeComponent();

            this.mainMenu = mainMenu;
            this.context = context;
            
            this.pacienteElegido = pacienteElegido;

            if (pacienteElegido.Nombre == null)
            {
                pacienteTemp = new Paciente
                {
                    FotoPerfil = new BitmapImage(new Uri("Assets/Icons/user.png", UriKind.Relative)),
                    HistorialesMedicos = new List<Historial>()
                };
            }
            else
            {
                pacienteTemp = new Paciente
                {
                    Nombre = pacienteElegido.Nombre,
                    Apellidos = pacienteElegido.Apellidos, 
                    Sexo = pacienteElegido.Sexo,
                    Edad = pacienteElegido.Edad,
                    CorreoElectronico = pacienteElegido.CorreoElectronico,
                    Direccion = pacienteElegido.Direccion, 
                    Telefono = pacienteElegido.Telefono,
                    HistorialesMedicos = new List<Historial>(pacienteElegido.HistorialesMedicos),
                    FotoPerfil = pacienteElegido.FotoPerfil
                };
            }

            if (pacienteElegido.Nombre != null)
            {
                int index = pacienteElegido.Sexo.Equals("Hombre") ? 0 : 1;
                sexoModificarPacienteComboBox.SelectedIndex = index;
            }

            PonerHistorialAEstado(false);

            historialesMedicosList.ItemsSource = pacienteTemp.HistorialesMedicos;

            DataContext = pacienteTemp;
        }

        private bool ComprobarTodos()
        {
            return ComprobarEspaciosVacios("Nombre", nombreModificarPacienteTextbox) && ComprobarEspaciosVacios("Apellidos", apellidosModificarPacienteTextbox) && ComprobarEspaciosVacios("Edad", edadModificarPacienteTextbox)
                && ComprobarEspaciosVacios("Direccion", domicilioModificarPacienteTextbox) && ComprobarEspaciosVacios("CorreoElectronico", correoModificarPacienteTextbox) && ComprobarEspaciosVacios("Teléfono", telefonoModificarPacienteTextbox);
        }

        public void HacerCambios()
        {
            pacienteTemp.Sexo = sexoModificarPacienteComboBox.SelectedIndex == 0 ? "Hombre" : "Mujer";
            int referencia = context.ListadoPacientes.FindIndex(paciente => paciente.NombreCompleto.Equals(pacienteElegido.NombreCompleto));
            if (referencia != -1)
            {
                context.ListadoPacientes[referencia] = pacienteTemp;
            }
            else
            {
                context.ListadoPacientes.Add(pacienteTemp);
                // Igual para añadir lo del tema de citas
            }
        }
        private void btnConfirmarCambiosPaciente_Click(object sender, RoutedEventArgs e)
            {
            if (!ComprobarTodos())
            {
                return;
            }

            HacerCambios();

            var list = mainMenu.pacientesPage.pacientesList;
            list.Items.Refresh();
            list.SelectedIndex = context.ListadoPacientes.FindIndex(paciente => paciente.NombreCompleto.Equals(pacienteTemp.NombreCompleto));
            list.Focus();

            mainMenu.mainMenuCitas.IsEnabled = true;
            mainMenu.mainMenuPersonal.IsEnabled = true;
            mainMenu.framePacientes.Content = mainMenu.pacientesPage;

            list.Items.Refresh();
            mainMenu.pacientesPage.historialesPacienteList.Items.Refresh();
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

        private void PonerHistorialAEstado(bool state)
        {
            fechaHistorial.IsEnabled = state;
            dolenciasModificarPacienteTextBox.IsEnabled = state;
            tratamientosModificarPacienteTextBox.IsEnabled = state;

        }

        private void btnCambiarFotoPaciente_Click(object sender, RoutedEventArgs e)
        {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "Images|*.png;*.gif;*.jpg";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var bitmap = new BitmapImage(new Uri(openDialog.FileName, UriKind.Absolute));
                    imagenFotoPerfil.Source = bitmap;
                    pacienteTemp.FotoPerfil = bitmap;
                }
                catch
                {
                    Helper.ShowError("No ha sido posbile cargar la imagen", "Error :(");
                }
            }

        }
        public Historial HistorialSeleccionado
        {
            get
            {
                return (Historial)historialesMedicosList.SelectedItem;
            }
        }

        public void updateHistorialesMedicos()
        {
            if (HistorialSeleccionado == null)
                return;

            fechaHistorial.Text = HistorialSeleccionado.Fecha;
            dolenciasModificarPacienteTextBox.Text = HistorialSeleccionado.Dolencias;
            tratamientosModificarPacienteTextBox.Text = HistorialSeleccionado.Tratamientos;

        }

        private bool HistorialesMedicosComprobar()
        {
            return ComprobarEspaciosVacios("Dolencias del historial seleccionado", dolenciasModificarPacienteTextBox) && ComprobarEspaciosVacios("Tratamientos del historial seleccionado", tratamientosModificarPacienteTextBox);
        }
        private void btnBorrarCambiosPaciente_Click(object sender, RoutedEventArgs e)
        {
            var question = Helper.ShowWarning("¿Seguro que quiere borrar los cambios?", "Borrar cambios");
            if (question == DialogResult.Cancel)
                return;
            mainMenu.mainMenuCitas.IsEnabled = true;
            mainMenu.mainMenuPersonal.IsEnabled = true;
            mainMenu.framePacientes.Content = mainMenu.pacientesPage;

        }
        private void listaHistoriales_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            updateHistorialesMedicos();

        }
        private void btnModificarHistorialPaciente_Click(object sender, RoutedEventArgs e)
        {
            if (modificarHistorialBotonTexto.Text.Equals("Modificar"))
            {
                PonerHistorialAEstado(true);
                historialesMedicosList.IsEnabled = false;
                modificarHistorialBotonFoto.Source = new BitmapImage(new Uri("Assets/Icons/save.png", UriKind.Relative));
                modificarHistorialBotonTexto.Text = "Confirmar";
            }
            else
            {
                // Comprobación de campos
                if (!HistorialesMedicosComprobar())
                {
                    return;
                }

                if (fechaHistorial.SelectedDate == null)
                {
                    Helper.ShowError("La Fecha del historial no puede estar vacía. Seleccione una", "Campo vacío");
                    return;
                }

                if (historialesMedicosList.SelectedItem == null)
                {
                    var nuevoHistorial = new Historial()
                    {
                        Fecha = fechaHistorial.Text,
                        Dolencias = dolenciasModificarPacienteTextBox.Text,
                        Tratamientos = tratamientosModificarPacienteTextBox.Text
                    };
                    pacienteTemp.HistorialesMedicos.Add(nuevoHistorial);
                    historialesMedicosList.Items.Refresh();
                    historialesMedicosList.SelectedIndex = pacienteTemp.HistorialesMedicos.Count - 1;
                }
                else
                {
                    HistorialSeleccionado.Fecha = fechaHistorial.Text;
                    HistorialSeleccionado.Dolencias = dolenciasModificarPacienteTextBox.Text;
                    HistorialSeleccionado.Tratamientos = tratamientosModificarPacienteTextBox.Text;
                }
                historialesMedicosList.Items.Refresh();
                PonerHistorialAEstado(false);
                historialesMedicosList.IsEnabled = true;
                modificarHistorialBotonFoto.Source = new BitmapImage(new Uri("Assets/Icons/modify.png", UriKind.Relative));
                modificarHistorialBotonTexto.Text = "Modificar";
            }
    }

        private void ctxHistorialAdd_Click(object sender, RoutedEventArgs e)
        {
            historialesMedicosList.SelectedIndex = -1;
            btnModificarHistorialPaciente_Click(null, null);
            fechaHistorial.Text = "";
            dolenciasModificarPacienteTextBox.Text = "";
            tratamientosModificarPacienteTextBox.Text = "";
            historialesMedicosList.Items.Refresh();

        }
        private void ctxHistorialDelete_Click(object sender, RoutedEventArgs e)
        {
            var question = Helper.ShowWarning("¿Seguro que quiere eliminar el Historial '" + HistorialSeleccionado.Fecha + "' ?", "Sin cambios");
            if (question == DialogResult.Cancel)
            {
                return;
            }


            int removeIndex = historialesMedicosList.SelectedIndex;
            pacienteTemp.HistorialesMedicos.RemoveAt(removeIndex);
            historialesMedicosList.Items.Refresh();
            historialesMedicosList.SelectedIndex = Math.Min(removeIndex, pacienteTemp.HistorialesMedicos.Count - 1);

            PonerHistorialAEstado(false);
            historialesMedicosList.IsEnabled = true;
            modificarHistorialBotonFoto.Source = new BitmapImage(new Uri("Assets/Icons/modify.png", UriKind.Relative));
            modificarHistorialBotonTexto.Text = "Modificar";
        }
    }
}
