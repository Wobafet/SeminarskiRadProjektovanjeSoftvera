
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
    public partial class AttendanceForm : Form
    {
        private AttendanceController controller;
        private SchoolClass schoolClass;
        public AttendanceForm(SchoolClass schoolClass)
        {
            this.schoolClass = schoolClass;
            InitializeComponent();
            
            controller = new AttendanceController();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {

            controller.SaveAbsentsAndPeriod(clbStudents,schoolClass,int.Parse(txtbPeriodNumber.Text));
          

            try
            {

                

                MessageBox.Show("System successfully saved attendance");

                controller.FormClosing(this);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }
     

        
     

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                Period p = new Period() { SchoolClass = schoolClass, PeriodNumber = int.Parse(txtbPeriodNumber.Text), Teacher = MainCoordinator.Instance.Teacher, Subject = MainCoordinator.Instance.Teacher.Subject };
                controller.Load(clbStudents, p, schoolClass);

            }
            catch (GetAllException)
            {
                MessageBox.Show("You already load this period");                
            }
        }

        private void AttendanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.FormClosing(this);
        }
    }
}
