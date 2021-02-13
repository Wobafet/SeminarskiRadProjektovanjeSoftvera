using Domain;
using Domain.Grade;
using SeminarskiRadProjektovanjeSoftvera.Communications;
using SeminarskiRadProjektovanjeSoftvera.Forms;
using SeminarskiRadProjektovanjeSoftvera.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRadProjektovanjeSoftvera.Controller
{
    public class EvaluationController
    {
        private List<Evalution> oralEvalutions;
        private List<Evalution> controlEvalutions;
        private List<Evalution> writtenEvalutions;
        private List<Evalution> evalutions;
        private SchoolClass schoolClass;
        public EvaluationController(Label lblSubject, SchoolClass schoolClass)
        {
            this.schoolClass = schoolClass;
            
            oralEvalutions = new List<Evalution>();
            controlEvalutions = new List<Evalution>();
            writtenEvalutions = new List<Evalution>();
            evalutions = new List<Evalution>();
            lblSubject.Text = $"Subject : {MainCoordinator.Instance.Teacher.Subject.SubjectName}";
        }

        internal void ChangeClassificationPeriod(ComboBox cbClassificationPeriod, DataGridView dgvGradeStudent)
        {
            dgvGradeStudent.Rows.Clear();

            Grades? oral = null;
            Grades? control = null;
            Grades? written = null;

            foreach (var student in schoolClass.Students)
            {
                foreach (var grades in student.Evalutions)
                {

                    if (grades.ClassificationPeriod == (ClassificationPeriod)cbClassificationPeriod.SelectedItem)
                    {
                        switch (grades.GradeType)
                        {
                            case GradeType.Oral:
                                oral = grades.Grade;

                                break;

                            case GradeType.Control:
                                control = grades.Grade;

                                break;

                            case GradeType.Written:

                                written = grades.Grade;
                                break;

                        }
                    }
                }

                dgvGradeStudent.Rows.Add(student, oral, control, written);

                oral = null;
                control = null;
                written = null;
            }
        }

        internal void Initialize(ComboBox cbClassificationPeriod)
        {
          
           
            cbClassificationPeriod.DataSource = Enum.GetValues(typeof(ClassificationPeriod));
            cbClassificationPeriod.SelectedIndex = -1;
           
        }

        internal void SetDGV(DataGridView dgvGradeStudent)
        {
            var LastNameAndName = new DataGridViewTextBoxColumn();
            var oral = new DataGridViewComboBoxColumn();
            var control = new DataGridViewComboBoxColumn();
            var written = new DataGridViewComboBoxColumn();


            LastNameAndName.HeaderText = "Name";
            LastNameAndName.ValueType = typeof(Student);

            oral.HeaderText = "Oral";
            oral.DataSource = Enum.GetValues(typeof(Grades));
            oral.ValueType = typeof(Grades);

            control.HeaderText = "Control";
            control.DataSource = Enum.GetValues(typeof(Grades));
            control.ValueType = typeof(Grades);

            written.HeaderText = "Written";
            written.DataSource = Enum.GetValues(typeof(Grades));
            written.ValueType = typeof(Grades);

            dgvGradeStudent.Columns.AddRange(LastNameAndName, oral, control, written);
        }

        internal void SaveGrades()
        {
            evalutions.AddRange(oralEvalutions);
            evalutions.AddRange(controlEvalutions);
            evalutions.AddRange(writtenEvalutions);
            Communication.Instance.SaveGrades(evalutions.ToList());
        }

        internal void ValueChanged(DataGridViewCellEventArgs e, DataGridView dgvGradeStudent,ComboBox cbClassificationPeriod)
        {
            Evalution evalution = new Evalution()
            {
                Student = GetValueDGV(0, e.RowIndex,dgvGradeStudent) as Student,
                ClassificationPeriod = (ClassificationPeriod)cbClassificationPeriod.SelectedItem,
                GradeType = SetGradeType(e.ColumnIndex),
                Grade = (Grades)dgvGradeStudent[e.ColumnIndex, e.RowIndex].Value,
                Subject = schoolClass.Students[0].CurrentSubject

            };

            switch (e.ColumnIndex)
            {
                case 1:
                    if (oralEvalutions.Any(ev => ev.Student.Id == evalution.Student.Id))
                    {
                        oralEvalutions.Remove(oralEvalutions.ToList().Single(ev => ev.Student.Id == evalution.Student.Id));
                    }
                    oralEvalutions.Add(evalution);
                    break;

                case 2:
                    if (controlEvalutions.Any(ev => ev.Student.Id == evalution.Student.Id))
                    {
                        controlEvalutions.Remove(controlEvalutions.ToList().Single(ev => ev.Student.Id == evalution.Student.Id));
                    }
                    controlEvalutions.Add(evalution);
                    break;

                case 3:
                    if (writtenEvalutions.Any(ev => ev.Student.Id == evalution.Student.Id))
                    {
                        writtenEvalutions.Remove(writtenEvalutions.ToList().Single(ev => ev.Student.Id == evalution.Student.Id));
                    }
                    writtenEvalutions.Add(evalution);
                    break;
            }
            
           
        }

        private object GetValueDGV(int col, int row, DataGridView dgvGradeStudent)
        {
            return dgvGradeStudent[col, row].Value;
        }
        private GradeType SetGradeType(int col)
        {
            switch (col)
            {
                case 1:
                    return GradeType.Oral;
                case 2:
                    return GradeType.Control;
                case 3:
                    return GradeType.Written;

            }
            return GradeType.Written;
        }

        internal void FormClosing(GradeForm gradeForm)
        {
            MainCoordinator.Instance.OpenForm(new TeacherChooseSchoolClassForm(), gradeForm);
        }
    }
}
