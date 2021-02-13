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

namespace SeminarskiRadProjektovanjeSoftvera.Dialogs
{
    public partial class TeacherAddForm : Form
    {
        private TeacherController controller;
        public TeacherAddForm()
        {
            InitializeComponent();
            controller = new TeacherController();
            try
            {
                controller.Initialize(ucFirstName, ucLastName, ucEmail, ucPassword, ucSubject);
            }

            catch (GetAllException ex)
            {
                MessageBox.Show(ex.Message);
                this.Dispose();
            }

        }


        private void cbSubject_Click(object sender, EventArgs e)
        {
            if (controller.Click(ucSubject))
                MessageBox.Show("There are no items in combo box ");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            try
            {

                controller.SaveTeacher(ucFirstName, ucLastName, ucEmail, ucPassword, ucSubject);
                MessageBox.Show("System successfully saved teacher");
                
            }
            catch (AddException ex)
            {


                MessageBox.Show("System cannot saved teacher");
                MessageBox.Show(ex.Message);
            }
            catch (ValidationException)
            {

            }
        }

      

        private void TeacherAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.CloseForm(this);
        }
    }
}
