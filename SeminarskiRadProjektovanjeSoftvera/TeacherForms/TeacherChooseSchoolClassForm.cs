
using Domain;
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
    public partial class TeacherChooseSchoolClassForm : Form
    {
        private TeacherMainController controller;
        public TeacherChooseSchoolClassForm()
        {
            InitializeComponent();
            controller = new TeacherMainController(this);
            controller.Initialize(ucSchoolClass);
           
        }

        private void TeacherChooseSchoolClassForm_Load(object sender, EventArgs e)
        {
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {


            try
            {
                controller.Submit(ucSchoolClass, rbAttendanceRecord, rbEvalution);
            }
            catch (ValidationException)
            {

                
            }
    
            
            

        }



        private void TeacherChooseSchoolClassForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.FormClosing(this);
          
        }
    }
}
