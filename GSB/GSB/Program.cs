using System;
using System.Windows.Forms;

namespace GSB
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmConnexion unFrmConnexion = new FrmConnexion();
            //FrmMenu unFrmMenu = new FrmMenu();
            Application.Run(unFrmConnexion);
        }
    }
}
