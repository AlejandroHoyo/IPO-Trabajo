using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Xml;

namespace Lab_IPO
{
    public class Context
    {
        public List<Paciente> ListadoPacientes { get; set; }
        public List<Plantilla> ListadoPersonal { get; set; }
        public List<Cita> ListadoCitas { get; set; }

        public Context()
        {
            ListadoPacientes = CargarPacientes();
            ListadoPersonal = CargarPersonal();
            ListadoCitas = CargarCitas();
        }
        private XmlDocument LoadDoc(string uri)
        {
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri(uri, UriKind.Relative));
            doc.Load(fichero.Stream);
            return doc;
        }
        private List<Paciente> CargarPacientes()
        {
            List<Paciente> listado = new List<Paciente>();
            XmlDocument doc = LoadDoc("data/pacientes.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {

                string nombre = node.Attributes["Nombre"]?.Value ?? string.Empty; 
                string apellidos = node.Attributes["Apellidos"]?.Value ?? string.Empty;
                string edad = node.Attributes["Edad"]?.Value ?? string.Empty;
                string sexo = node.Attributes["Sexo"]?.Value ?? string.Empty;
                string correoElectronico = node.Attributes["CorreoElectronico"]?.Value ?? string.Empty;
                string direccion = node.Attributes["Direccion"]?.Value ?? string.Empty;
                string telefono = node.Attributes["Telefono"].Value ?? string.Empty;
                string fotoPerfilPath = node.Attributes["FotoPerfil"]?.Value ?? "Assets/Icons/user.png"; 

                var nuevoPaciente = new Paciente()
                {
                    Nombre = nombre,
                    Apellidos = apellidos,
                    Edad = edad,
                    Sexo = sexo,
                    CorreoElectronico = correoElectronico,
                    Direccion = direccion,
                    Telefono = telefono,
                    FotoPerfil = new BitmapImage(new Uri(fotoPerfilPath, UriKind.Relative))

                };
                List<Historial> historiales = new List<Historial>();

                foreach (XmlNode childNode in node.ChildNodes)
                {
                    string fecha = childNode.Attributes["Fecha"]?.Value ?? string.Empty; 
                    string tratamientos = childNode.Attributes["Tratamientos"]?.Value ?? string.Empty;
                    string dolencias = childNode.Attributes["Dolencias"]?.Value ?? string.Empty;

                    if (childNode.Name.Equals("HistorialMedico"))
                    {
                        var nuevoHistorial = new Historial();
                        nuevoHistorial.Fecha = fecha;
                        nuevoHistorial.Tratamientos = tratamientos;
                        nuevoHistorial.Dolencias = dolencias;
                        historiales.Add(nuevoHistorial);
                    }
                }
                nuevoPaciente.HistorialesMedicos = historiales;
                listado.Add(nuevoPaciente);

            }
            return listado;
        }

        private List<Cita> CargarCitas()
        {
            List<Cita> listado = new List<Cita>();
            XmlDocument doc = LoadDoc("data/citas.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string fecha = node.Attributes["Fecha"]?.Value ?? string.Empty;
                string hora = node.Attributes["Hora"]?.Value ?? string.Empty;
                string duracion = node.Attributes["Duracion"]?.Value ?? string.Empty;
                string estado = node.Attributes["Estado"]?.Value ?? string.Empty;
                string sanitarioNombre = node.Attributes["Sanitario"]?.Value ?? string.Empty;
                string pacienteNombre = node.Attributes["Paciente"]?.Value ?? string.Empty;

                //XmlNode sanitarioNode = node["Sanitario"];
                //string sanitarioApellidos = sanitarioNode?.Attributes["Apellidos"]?.Value ?? string.Empty;
                //string sanitarioTelefono = sanitarioNode?.Attributes["Telefono"]?.Value ?? string.Empty;
                //string sanitarioFotoPerfilPath = sanitarioNode?.Attributes["FotoPerfil"]?.Value ?? "Assets/Icons/user.png";

                //XmlNode pacienteNode = node["Paciente"];
                //string pacienteApellidos = pacienteNode?.Attributes["Apellidos"]?.Value ?? string.Empty;
                //string pacienteTelefono = pacienteNode?.Attributes["Telefono"]?.Value ?? string.Empty;
                //string pacienteFotoPerfilPath = pacienteNode?.Attributes["FotoPerfil"]?.Value ?? "Assets/Icons/user.png";

                //var nuevoSanitario = new Plantilla()
                //{
                //    Nombre = sanitarioNombre,
                //    Apellidos = sanitarioApellidos,
                //    Telefono = sanitarioTelefono,
                //    FotoPerfil = new BitmapImage(new Uri(sanitarioFotoPerfilPath, UriKind.Relative))
                //};

                //var nuevoPaciente = new Paciente()
                //{
                //    Nombre = pacienteNombre,
                //    Apellidos = pacienteApellidos,
                //    Telefono = pacienteTelefono,
                //    FotoPerfil = new BitmapImage(new Uri(pacienteFotoPerfilPath, UriKind.Relative))
                //};

                var nuevaCita = new Cita()
                {
                    Fecha = fecha,
                    Hora = hora,
                    Duracion = duracion,
                    Estado = estado,
                    Sanitario = sanitarioNombre,
                    Paciente = pacienteNombre
                };

                listado.Add(nuevaCita);
            }

            return listado;
        }
        private List<Plantilla> CargarPersonal()
        {
            List<Plantilla> listado = new List<Plantilla>();
            XmlDocument doc = LoadDoc("data/personal.xml");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string nombre = node.Attributes["Nombre"]?.Value ?? string.Empty;
                string apellidos = node.Attributes["Apellidos"]?.Value ?? string.Empty;
                string telefono = node.Attributes["Telefono"]?.Value ?? string.Empty;
                string edad = node.Attributes["Edad"]?.Value ?? string.Empty;
                string tipoPersonal = node.Attributes["TipoPersonal"]?.Value ?? string.Empty;
                string fotoPerfilPath = node.Attributes["FotoPerfil"]?.Value ?? "Assets/Icons/user.png";
                string logoPath = tipoPersonal.Equals("Sanitario") ? "Assets/Icons/farmacia.png" : "Assets/Icons/escoba.png";

                var nuevoPersonal = new Plantilla()
                {
                    Nombre = nombre,
                    Apellidos = apellidos,
                    Telefono = telefono,
                    Edad = edad,
                    TipoPersonal = tipoPersonal,
                    FotoPerfil = new BitmapImage(new Uri(fotoPerfilPath, UriKind.Relative)),
                    Logo = new BitmapImage(new Uri(logoPath, UriKind.Relative))
                };

                listado.Add(nuevoPersonal);
            }

            return listado;
        }

    }
}

