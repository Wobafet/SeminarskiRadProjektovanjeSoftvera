using SeminarskiRadProjektovanjeSoftvera.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRadProjektovanjeSoftvera
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

            while (true)
            {
                try
                {

                    MainCoordinator.Instance.OpenForm(new LoginForm(), new Form());
                    Application.Run();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
           


        }
    }
}
