using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace Lab_IPO
{
    public class Helper
    {
        public static DialogResult ShowAdvertencia(string mensaje, string tema)
        {
            return System.Windows.Forms.MessageBox.Show(mensaje, tema, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
        public static DialogResult ShowAdvertencia(string mensaje, string tema, MessageBoxButtons buttons)
        {
            return System.Windows.Forms.MessageBox.Show(mensaje, tema, buttons, MessageBoxIcon.Warning);
        }
        public static void ShowInformacion(string mensaje)
        {
            System.Windows.Forms.MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowAyuda(string mensaje)
        {
            System.Windows.Forms.MessageBox.Show(mensaje, "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult ShowError(string mensaje, string tema)
        {
            return System.Windows.Forms.MessageBox.Show(mensaje, tema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
