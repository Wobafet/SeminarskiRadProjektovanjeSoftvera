
using Domain;
using SeminarskiRadProjektovanjeSoftvera.Communications;
using SeminarskiRadProjektovanjeSoftvera.Controller;
using SeminarskiRadProjektovanjeSoftvera.Forms;
using SeminarskiRadProjektovanjeSoftvera.HelpClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRadProjektovanjeSoftvera
{
    public partial class LoginForm : Form
    {
        private LoginController controller;
        public LoginForm()
        {
            InitializeComponent();

            controller = new LoginController(ucUsername,ucPassword);
            controller.InitializeUcControls();

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.FormClosing();
            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
               MessageBox.Show("System cannot saved attendance");
                if (controller.Connect())
                    controller.Login(ucPassword, ucUsername, this);

            }
            catch (LoginException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (ValidationException)
            {

            }
            catch (Exception)
            {

            }

        }

       
    }
}
