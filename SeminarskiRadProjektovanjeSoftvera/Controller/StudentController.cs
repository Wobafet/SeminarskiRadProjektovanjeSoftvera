using Domain;
using SeminarskiRadProjektovanjeSoftvera.Communications;
using SeminarskiRadProjektovanjeSoftvera.Dialogs;
using SeminarskiRadProjektovanjeSoftvera.Forms;
using SeminarskiRadProjektovanjeSoftvera.HelpClasses;
using SeminarskiRadProjektovanjeSoftvera.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRadProjektovanjeSoftvera.Controller
{
    public class StudentController
    {
        private BindingList<Student> students;
        internal static Student student;

        internal void Initialize(UCTextBox ucFirstName, UCTextBox ucLastName, UCComboBox ucSchoolClass)
        {
            ucFirstName.SetLabelName("First name");
            ucLastName.SetLabelName("Last name");
            ucSchoolClass.SetLabelName("School class");

            ucSchoolClass.ComboBox.DataSource = GetAllSchoolClasses();

            ucSchoolClass.ComboBox.SelectedIndex = -1;
            ucSchoolClass.ComboBox.Text = "Select school class";
        }

        internal void Initialize(Student studentUpdate, UCTextBox ucFirstName, UCTextBox ucLastName, UCComboBox ucSchoolClass)
        {
            student = studentUpdate;
            ucFirstName.SetLabelName("First name");
            ucLastName.SetLabelName("Last name");
            ucSchoolClass.SetLabelName("School class");

            ucFirstName.TextBox.Text = student.FirstName;
            ucLastName.TextBox.Text =  student.LastName;
            List<SchoolClass> sc= GetAllSchoolClasses();
            ucSchoolClass.ComboBox.DataSource = sc;

            ucSchoolClass.ComboBox.SelectedItem = sc.Single(s => s.Id == student.SchoolClass.Id);
        }

       

        internal void OpenStudentUpdateMiniDialog(DataGridView dgvUpdateStudent, StudentUpdateForm studentUpdateForm)
        {
            student = (Student)dgvUpdateStudent.SelectedRows[0].DataBoundItem;

            MainCoordinator.Instance.OpenForm(new StudentUpdateMiniForm(student), studentUpdateForm);
          
        }

        internal bool InitializeDGV(DataGridView dgvDeleteStudent,ComboBox cbSchoolClass)
        {
            students = new BindingList<Student>(GetAllStudentsFromSchoolClass((SchoolClass)cbSchoolClass.SelectedItem));
            if (students.Count == 0)
            {
               
                return false ;
            }

            dgvDeleteStudent.DataSource = students;

            return true;
        }

        internal void Initialize(ComboBox cbSchoolClass)
        {
            cbSchoolClass.DataSource = GetAllSchoolClasses();
            cbSchoolClass.SelectedIndex = -1;
        }

        internal void SaveStudent(UCTextBox ucFirstName, UCTextBox ucLastName, UCComboBox ucSchoolClass)
        {
            Helper.EmptyField(ucFirstName, ucLastName, ucSchoolClass);
                    

                Student student = new Student
                {
                    FirstName = ucFirstName.TextBox.Text,
                    LastName = ucLastName.TextBox.Text,
                    SchoolClass = (SchoolClass)ucSchoolClass.ComboBox.SelectedItem
                };

                Communication.Instance.SaveStudent(student);
             
        }

        internal void DeleteStudent(DataGridView dgvDeleteStudent)
        {
            Student student = (Student)dgvDeleteStudent.SelectedRows[0].DataBoundItem;
            students.Remove(student);

            Communication.Instance.DeleteStudent(student);
        }

        internal void UpdateStudent(UCTextBox ucFirstName, UCTextBox ucLastName, SchoolClass selectedItem)
        {
            Helper.EmptyField(ucLastName, ucFirstName);
               

            student.FirstName = ucFirstName.TextBox.Text;
            student.LastName = ucLastName.TextBox.Text;
            student.SchoolClass = selectedItem;
            Communication.Instance.UpdateStudent(student);
           
        }

        internal void FormClosing(Form form)
        {
         if(form is StudentUpdateMiniForm)
                MainCoordinator.Instance.OpenForm(new StudentUpdateForm(), form);
         else
            MainCoordinator.Instance.OpenForm(new AdminMainForm(), form);
        }


        internal List<Student> GetAllStudentsFromSchoolClass(SchoolClass selectedItem)
        {
            return Communication.Instance.GetAllStudentsFromSchoolClass(selectedItem);
        }

        internal List<SchoolClass> GetAllSchoolClasses()
        {
            return Communication.Instance.GetAllSchoolClasses();
        }


    }
}
