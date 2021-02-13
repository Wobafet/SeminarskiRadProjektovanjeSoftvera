
using Domain;
using SeminarskiRadProjektovanjeSoftvera.Communications;
using SeminarskiRadProjektovanjeSoftvera.Controller;
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
    public partial class StudentDeleteForm : Form
    {
        private StudentController controller;
        
        public StudentDeleteForm()
        {
            InitializeComponent();
            controller = new StudentController();
            controller.Initialize(cbSchoolClass);
          
        }

     
        private void cbSchoolClass_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (!controller.InitializeDGV(dgvDeleteStudent, cbSchoolClass))
            {
                MessageBox.Show("System couldn't find students");
            }
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
              
                controller.DeleteStudent(dgvDeleteStudent);
                MessageBox.Show("System successfully deleted student");
            }
            catch (ArgumentOutOfRangeException )
            {
                MessageBox.Show("You must select entire row to delete student");
                return;
                
            } catch (DeleteException ex)
            {
                MessageBox.Show("System cannot delete student");
                MessageBox.Show(ex.Message);

                return;
                
            }


        }

        private void StudentDeleteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.FormClosing(this);
        }
    }
}
