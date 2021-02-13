
using Domain;
using Domain.Grade;
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
    public partial class GradeForm : Form
    {
        private EvaluationController controller;
       
        public GradeForm(SchoolClass schoolClass)
        
        {
            InitializeComponent();
            controller = new EvaluationController(lblSubject,schoolClass);

          
            controller.Initialize(cbClassificationPeriod);
            controller.SetDGV(dgvGradeStudent);


        }

       

        private void cbClassificationPeriod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            controller.ChangeClassificationPeriod(cbClassificationPeriod,dgvGradeStudent);
            
        }

        private void dgvGradeStudent_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            controller.ValueChanged(e,dgvGradeStudent,cbClassificationPeriod);

        }
        
        private void btnLogIn_Click(object sender, EventArgs e)
        {

            try
            {
                controller.SaveGrades();

                MessageBox.Show("System successfully saved grades");
                controller.FormClosing(this);
            }
            catch (AddException ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void GradeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.FormClosing(this);
        }
    }
}
