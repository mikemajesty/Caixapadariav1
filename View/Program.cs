using Controller;
using System;
using System.Windows.Forms;

namespace View
{

    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //KeyGenDAO keygenDao = new KeyGenDAO();

            //if (keygenDao.SelectDiasTrail().Equals("0"))
            //{
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new frmLogin());


            //}
            //else
            //{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());

            //}
        }
    }
}
