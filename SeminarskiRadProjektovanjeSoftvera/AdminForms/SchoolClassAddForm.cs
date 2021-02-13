
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
    public partial class SchoolClassAddForm : Form
    {
        private SchoolClassController controller;
        public SchoolClassAddForm()
        {
            InitializeComponent();
            controller = new SchoolClassController(ucClassName,ucTeacher);
            try
            {
                controller.LoadForm();

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
                controller.SaveSchoolClass(ucClassName,ucTeacher);
              
                MessageBox.Show("System successfully saved school class");
               
            }
            catch (AddException ex )
            {
                MessageBox.Show("System cannot saved school class");
                MessageBox.Show(ex.Message);
            }
            catch (ValidationException )
            {
               
            }
        }

     
       

        private void cbTeachers_Click(object sender, EventArgs e)
        {

            if(controller.ClickHandler())
            MessageBox.Show("There are no items in combo box");
        }

        private void SchoolClassAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.FormClosing(this);
           
        }
    }
}
