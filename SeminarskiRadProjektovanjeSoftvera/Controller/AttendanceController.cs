using Domain;
using SeminarskiRadProjektovanjeSoftvera.Communications;
using SeminarskiRadProjektovanjeSoftvera.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarskiRadProjektovanjeSoftvera.Controller
{
    public class AttendanceController
    {
       

        internal void Load(CheckedListBox clbStudents, Period p, SchoolClass schoolClass)
        {
            Communication.Instance.GetPeriod(p);
            clbStudents.Items.AddRange(schoolClass.Students.ToArray());
          
        }

        internal void SaveAbsentsAndPeriod(CheckedListBox clbStudents, SchoolClass schoolClass, int v)
        {
            List<Student> apsentStudents = new List<Student>();
            foreach (var  item in clbStudents.CheckedItems)
            {
                apsentStudents.Add((Student)item);
            }

            Period period = new Period
            {

                Teacher = MainCoordinator.Instance.Teacher,
                SchoolClass = schoolClass,
                Subject = MainCoordinator.Instance.Teacher.Subject,
                PeriodNumber=v,
                ApsentStudents = apsentStudents


            };

            Communication.Instance.SaveAbsentsAndPeriod(period);
        }

        internal void FormClosing(AttendanceForm attendanceForm)
        {

            MainCoordinator.Instance.OpenForm(new TeacherChooseSchoolClassForm(), attendanceForm);
        }
    }
}
