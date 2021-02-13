
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

namespace SeminarskiRadProjektovanjeSoftvera.Dialogs
{
    public partial class StudentUpdateMiniForm : Form
    {
        private StudentController controller;
       
        public StudentUpdateMiniForm(Student studentUpdate)
        {
           
            InitializeComponent();
            controller = new StudentController();

            controller.Initialize(studentUpdate,ucFirstName, ucLastName, ucSchoolClass);
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

         

            try
            {
                controller.UpdateStudent(ucFirstName, ucLastName, (SchoolClass)ucSchoolClass.ComboBox.SelectedItem);
          
                MessageBox.Show("System successfully updated student");

                
            }
            catch (UpdateException  ue)
            {
                
                MessageBox.Show("System cannot update student");
                MessageBox.Show(ue.Message);
            }
           
        }


        private void StudentUpdateMiniForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           controller.FormClosing(this);
        }
    }
}
