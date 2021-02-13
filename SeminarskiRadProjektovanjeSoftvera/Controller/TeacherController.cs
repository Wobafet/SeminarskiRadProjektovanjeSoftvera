using Domain;
using SeminarskiRadProjektovanjeSoftvera.Communications;
using SeminarskiRadProjektovanjeSoftvera.Dialogs;
using SeminarskiRadProjektovanjeSoftvera.Forms;
using SeminarskiRadProjektovanjeSoftvera.HelpClasses;
using SeminarskiRadProjektovanjeSoftvera.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskiRadProjektovanjeSoftvera.Controller
{
    public class TeacherController
    {
        internal List<Subject> GetAllSubjects()
        {
            return Communication.Instance.GetAllSubjects();
        }

        internal void SaveTeacher(UCTextBox ucFirstName, UCTextBox ucLastName, UCTextBox ucEmail, UCTextBox ucPassword, UCComboBox ucSubject)
        {
            Helper.EmptyField(ucEmail, ucFirstName, ucLastName, ucPassword, ucSubject);

            if (!Helper.EmailCheck(ucEmail) | !Helper.PasswordCheck(ucPassword))
                throw new ValidationException();

            Teacher teacher = new Teacher
            {
                FirstName = ucFirstName.TextBox.Text,
                LastName = ucLastName.TextBox.Text,
                Email = ucEmail.TextBox.Text,
                Password = ucPassword.TextBox.Text,
                Subject = (Subject)ucSubject.ComboBox.SelectedItem

            };

            Communication.Instance.SaveTeacher(teacher);
        }

        internal bool Click(UCComboBox ucSubject)
        {
            return ucSubject.ComboBox.Items.Count == 0;
        }

        internal void Initialize(UCTextBox ucFirstName, UCTextBox ucLastName, UCTextBox ucEmail, UCTextBox ucPassword, UCComboBox ucSubject)
        {
            ucFirstName.SetLabelName("First name");
            ucLastName.SetLabelName("Last name");
            ucEmail.SetLabelName("Email");
            ucPassword.SetLabelName("Password");
            ucSubject.SetLabelName("Subject");

            ucPassword.TextBox.PasswordChar = '*';
           


           
                ucSubject.ComboBox.DataSource = GetAllSubjects();
                ucSubject.ComboBox.DisplayMember = "SubjectName";
                ucSubject.ComboBox.SelectedIndex = -1;
                ucSubject.ComboBox.Text = "Select subject";

            
           
        }

        internal void CloseForm(TeacherAddForm teacherAddForm)
        {
            MainCoordinator.Instance.OpenForm(new AdminMainForm(), teacherAddForm);
        }
    }
}
