using Domain;
using SeminarskiRadProjektovanjeSoftvera.Communications;
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
    public class SchoolClassController
    {
        private UCTextBox ucClassName;
        private UCComboBox ucTeacher;

        public SchoolClassController(UCTextBox ucClassName, UCComboBox ucTeacher)
        {
            this.ucClassName = ucClassName;
            this.ucTeacher = ucTeacher;

            ucClassName.SetLabelName("Class name");
            ucTeacher.SetLabelName("Class elder");
        }

        internal List<Teacher> GetAllTeachers()
        {
            return Communication.Instance.GetAllTeachers();
        }

       

        internal void SaveSchoolClass(UCTextBox ucClassName, UCComboBox ucTeacher)
        {
            Helper.EmptyField(ucTeacher, ucClassName);

           

            SchoolClass schoolClass = new SchoolClass
            {
                SchoolClassName = ucClassName.TextBox.Text,
                ClassElder = (Teacher)ucTeacher.ComboBox.SelectedItem
            };

            Communication.Instance.SaveSchoolClass(schoolClass);
        }

        internal void LoadForm()
        {
            ucTeacher.ComboBox.DataSource = GetAllTeachers();
            ucTeacher.ComboBox.SelectedIndex = -1;
            ucTeacher.ComboBox.Text = "Select teacher";
        }

        internal bool ClickHandler()
        {
            return ucTeacher.ComboBox.Items.Count == 0;
              
        }

        internal void FormClosing(SchoolClassAddForm schoolClassAddForm)
        {
            MainCoordinator.Instance.OpenForm(new AdminMainForm(), schoolClassAddForm);
        }
    }
}
