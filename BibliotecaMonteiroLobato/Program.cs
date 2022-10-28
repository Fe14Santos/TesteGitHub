using System;
using System.Windows.Forms;

namespace BibliotecaMonteiroLobato
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
            //Application.Run(new Principal());
            Application.Run(new Login());
            //Application.Run(new Emprestimo());
        }
    }
}
