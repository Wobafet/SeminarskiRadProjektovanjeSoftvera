
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
    public partial class AdminMainForm : Form
    {
        private AdminMainController mainController;
        public AdminMainForm()
        {
            InitializeComponent();
            mainController = new AdminMainController(this);
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {

            mainController.OpenForm(new TeacherAddForm());
                       
        }

        private void AdminMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainController.CloseAdminMainForm();
            
        }

        private void addSchoolClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenForm(new SchoolClassAddForm());

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenForm(new StudentAddForm());
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenForm(new StudentDeleteForm());
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenForm(new StudentUpdateForm());

        }
    }
}
