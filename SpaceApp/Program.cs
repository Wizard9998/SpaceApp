using SpaceApp.clases;
using SpaceApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Fachada f = new Fachada();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormInicio(f));
            FormInicio main = new FormInicio(f);
            main.FormClosed += FromInicio_Closed; // agrega esto aquí
            main.Show();
            Application.Run();
        }

        private static void FromInicio_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FromInicio_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += FromInicio_Closed;
            }
        }
    }
}
