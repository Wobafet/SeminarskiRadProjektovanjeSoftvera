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
using System.Windows.Forms;

namespace SeminarskiRadProjektovanjeSoftvera.Controller
{
    internal class TeacherMainController
    {
        private SchoolClass schoolClass;
        private TeacherChooseSchoolClassForm teacherChooseSchoolClassForm;

        public TeacherMainController(TeacherChooseSchoolClassForm teacherChooseSchoolClassForm)
        {
            this.teacherChooseSchoolClassForm = teacherChooseSchoolClassForm;
        }

        internal void Initialize(UCComboBox ucSchoolClass)
        {
            ucSchoolClass.SetLabelName("Choose school class");
            ucSchoolClass.ComboBox.DataSource = GetAllSchoolClasses();

            ucSchoolClass.ComboBox.SelectedIndex = -1;
        }

        internal List<SchoolClass> GetAllSchoolClasses()
        {
            return Communication.Instance.GetAllSchoolClasses();
        }

        internal void Submit(UCComboBox ucSchoolClass, RadioButton rbAttendanceRecord, RadioButton rbEvalution)
        {
            Helper.EmptyField(ucSchoolClass);


            if (rbAttendanceRecord.Checked == false && rbEvalution.Checked == false)
            {
                MessageBox.Show("Radio button must be selected");
                return;
            }

                schoolClass=ucSchoolClass.ComboBox.SelectedItem as SchoolClass;
                schoolClass.Students = Communication.Instance.GetAllStudentsFromSchoolClass((SchoolClass)ucSchoolClass.ComboBox.SelectedItem);
            if (rbEvalution.Checked)
            {
                SetSubject();
                schoolClass.Students = Communication.Instance.GetAllGradesForStudents(schoolClass.Students);
              
                MainCoordinator.Instance.OpenForm(new GradeForm(schoolClass), teacherChooseSchoolClassForm);
            }
            else
            {
               
                MainCoordinator.Instance.OpenForm(new AttendanceForm(schoolClass), teacherChooseSchoolClassForm);
            }
        }

        internal void FormClosing(Form form)
        {
            MainCoordinator.Instance.OpenForm(new LoginForm(), form);
        }

        private void SetSubject()
        {
            schoolClass.Students.ForEach(s => s.CurrentSubject = MainCoordinator.Instance.Teacher.Subject);
        }
    }
}
