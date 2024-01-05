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
        public static DialogResult ShowWarning(string message, string caption)
        {
            return System.Windows.Forms.MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowWarning(string message, string caption, MessageBoxButtons buttons)
        {
            return System.Windows.Forms.MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
        }

        public static DialogResult ShowError(string message, string caption)
        {
            return System.Windows.Forms.MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowHelp(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowInfo(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
