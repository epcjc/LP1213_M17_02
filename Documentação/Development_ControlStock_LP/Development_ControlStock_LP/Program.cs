using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Development_ControlStock_LP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login Login = new Login();

            Login.ShowDialog();

            if (Login.logado)
            {
                Application.Run(new Bem_Vindo());

            }
        }
    }
}
