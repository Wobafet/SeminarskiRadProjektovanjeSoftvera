using Domain;
using SeminarskiRadProjektovanjeSoftvera.Communications;
using SeminarskiRadProjektovanjeSoftvera.Forms;
using SeminarskiRadProjektovanjeSoftvera.HelpClasses;
using SeminarskiRadProjektovanjeSoftvera.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRadProjektovanjeSoftvera.Controller
{
   public  class LoginController
    {
        private UCTextBox ucUsername;
        private UCTextBox ucPassword;

        public LoginController(UCTextBox ucUsername, UCTextBox ucPassword)
        {
            this.ucUsername = ucUsername;
            this.ucPassword = ucPassword;


        }

        public void InitializeUcControls()
        {
            
            ucUsername.SetLabelName("Username or email");
            ucPassword.SetLabelName("Password");
            ucPassword.TextBox.PasswordChar = '*';

            ucUsername.TextBox.Text = "ljilja@gmail.com";
            ucPassword.TextBox.Text = "Ljilja97.";
        }

        internal void FormClosing()
        {
            Environment.Exit(0);
        }

        internal bool Connect()
        {
            try
            {
                Communication.Instance.Connect();
                return true;
            }
            catch (SocketException)
            {
                MessageBox.Show("Server error!");
                return false;
            }
        }


      

        internal void Login(UCTextBox ucPassword, UCTextBox ucUsername, LoginForm loginForm)
        {
              Helper.EmptyField(ucPassword, ucUsername);
                    
                Admin user = new Admin () { Email = ucUsername.TextBox.Text, Password = ucPassword.TextBox.Text };

                var userBack = Communication.Instance.Login(user);


                if (userBack is Admin)
                {
                    MainCoordinator.Instance.Admin = userBack as Admin;
                    MessageBox.Show($"Welcome {MainCoordinator.Instance.Admin.Email}");
                    MainCoordinator.Instance.OpenForm(new AdminMainForm(), loginForm);
                 }
                else
                {
                    MainCoordinator.Instance.Teacher = userBack as Teacher;
                    MessageBox.Show($"Welcome {MainCoordinator.Instance.Teacher.FirstName} {MainCoordinator.Instance.Teacher.LastName}");

                    MainCoordinator.Instance.OpenForm(new TeacherChooseSchoolClassForm(),loginForm);
                }
            }
            
           

        }
    }

