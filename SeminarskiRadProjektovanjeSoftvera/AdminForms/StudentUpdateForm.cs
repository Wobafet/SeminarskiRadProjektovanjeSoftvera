
using Domain;
using SeminarskiRadProjektovanjeSoftvera.Controller;
using SeminarskiRadProjektovanjeSoftvera.Dialogs;
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
    public partial class StudentUpdateForm : Form
    {
        private StudentController controller;

        public StudentUpdateForm()
        {
            InitializeComponent();
            controller = new StudentController();
            controller.Initialize(cbSchoolClass);
          
        }

       

        private void Details_Click(object sender, EventArgs e)
        {
            try
            {
                controller.OpenStudentUpdateMiniDialog(dgvUpdateStudent,this);
                           
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("You must select entire row to see details ");
                

            }
        }

        private void cbSchoolClass_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if(!controller.InitializeDGV(dgvUpdateStudent,cbSchoolClass))
              {
                
                MessageBox.Show("System couldn't find students");
               
            }


            
        }

        private void StudentUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           controller.FormClosing(this);
           
        }
    }
}
