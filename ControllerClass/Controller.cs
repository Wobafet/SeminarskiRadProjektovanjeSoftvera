using Domain;
using Domain.Grade;
using Storage.Implementation;
using Storage.Implementation.InMemory;
using Storage.Implementation.InSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation;
using SystemOperation.AbsentSO;
using SystemOperation.GradeSO;
using SystemOperation.SchoolClassSO;
using SystemOperation.StudentSO;
using SystemOperation.SubjectSO;
using SystemOperation.TeacherSO;

namespace ControllerClass
{
    public class Controller
    {
        
        private StorageAdminInMemory admins;
        public Teacher Teacher { get; set; }
        /*public SchoolClass SchoolClass { get; set; }*/
        private static  Controller instance;


        public  static Controller Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        private  Controller()
        {

            admins = new StorageAdminInMemory();
        }
        public void  AddPeriod(Period period)
        {

            PeriodAndAbsentAddSO add = new PeriodAndAbsentAddSO();
            add.ExecuteTemplate(period);
        }

        public Admin LoginAdmin(object requestObject)
        {
            Admin user = requestObject as Admin;

            if(admins.Administrators.Any(a=>a.Email==user.Email && a.Password == user.Password))
            {
                return user;
            }


            return null;
        }

        public Teacher LoginTeacher(object requestObject)
        {
            Admin a = requestObject as Admin;
          
            List<Teacher> teachers = GetAllTeachers();
            if (teachers.Any(t => t.Email == a.Email && t.Password == a.Password))
            {
                return teachers.Find(t => t.Email == a.Email && t.Password == a.Password);
            }

            return null;
        }

        #region Student
        public void UpdateStudent(Student student)
        {
            UpdateStudentSO update = new UpdateStudentSO();
            update.ExecuteTemplate(student);
        }


        public List<Student> GetAllStudentFromSchoolClass(SchoolClass schoolClass)
        {
            Student s = new Student() { SchoolClass = schoolClass };
            GetAllStudentsSO getAll = new GetAllStudentsSO();
            getAll.ExecuteTemplate(s);
           
            return getAll.Students;
        }

        public void AddStudent(Student student)
        {
            AddStudentSO add = new AddStudentSO();
            add.ExecuteTemplate(student);
        }
        public void DeleteStudent(Student student)
        {
            DeleteStudentSO delete = new DeleteStudentSO();
            delete.ExecuteTemplate(student);
        }

        #endregion

        public List<Subject> GetAllSubjects()
        {
            GetAllSubjectSO getAll = new GetAllSubjectSO();
            getAll.ExecuteTemplate(new Subject());
            return getAll.Subjects;
        }



        public void AddSchoolClass(SchoolClass schoolClass)
        {

            AddSchoolClassSO add = new AddSchoolClassSO();
            add.ExecuteTemplate(schoolClass);
        }

        public void AddTeacher(Teacher teacher)
        {
            AddTeacherSO add = new AddTeacherSO();
            add.ExecuteTemplate(teacher);
        }

        public List<SchoolClass> GetAllSchoolClasses()
        {
            GetAllSchoolClassSO getAll = new GetAllSchoolClassSO();
            getAll.ExecuteTemplate(new SchoolClass());
            return getAll.SchoolClasses;
        }

     

        public List<Teacher> GetAllTeachers()
        {
            GetAllTeacherSO getAll = new GetAllTeacherSO();
            getAll.ExecuteTemplate(new Teacher());
            return getAll.Teachers;
        }

        public List<Period> GetAllPeriods()
        {
            GetAllPeriodsSO getAll = new GetAllPeriodsSO();
            getAll.ExecuteTemplate(new Period());
            return getAll.Periods;
        }

        

        public List<Student> GetAllGrade(List<Student> lists)
        {
            GetAllGradesSO getAll = new GetAllGradesSO();
            getAll.students = lists;
            getAll.ExecuteTemplate(new Evalution());
            return getAll.students;
        }

        public void AddAbsentsAndPeriod(Period p)
        {

            PeriodAndAbsentAddSO add = new PeriodAndAbsentAddSO();
            add.ExecuteTemplate(p);

        }

        public void AddGrades(List<Evalution> lists)
        {
            AddGradesSO add = new AddGradesSO(lists);
            add.ExecuteTemplate(new Evalution());

        }
    }
}
