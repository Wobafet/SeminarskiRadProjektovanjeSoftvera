
using Domain;
using SeminarskiRadProjektovanjeSoftvera.Communications;
using SeminarskiRadProjektovanjeSoftvera.Controller;
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

namespace SeminarskiRadProjektovanjeSoftvera.Forms
{
    public partial class StudentAddForm : Form
    {
        private StudentController controller;
       
        public StudentAddForm()
        {
            InitializeComponent();
            controller = new StudentController();
            try
            {
                controller.Initialize(ucFirstName, ucLastName, ucSchoolClass);
            }
            catch (GetAllException ex)
            {

                MessageBox.Show(ex.Message);
            }

          
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                controller.SaveStudent(ucFirstName,ucLastName,ucSchoolClass);
                MessageBox.Show("System successfully saved student");
                
            }
            catch (AddException ex)
            {
                MessageBox.Show("System cannot saved student");
                MessageBox.Show(ex.Message);
            }
            catch (ValidationException )
            {
               
            }

        }



        private void StudentAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.FormClosing(this);
        }

        private void ucSchoolClass_Load(object sender, EventArgs e)
        {

        }
    }
}
