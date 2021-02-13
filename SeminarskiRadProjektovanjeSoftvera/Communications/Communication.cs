using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SeminarskiRadProjektovanjeSoftvera.Communications
{
    public class Communication
    {
        public SenderAndReceiver     SenderAndReceiver { get; set; }
        private static Communication instance;

        private Socket socket;
       

        internal void  GetPeriod(Period p)
        {
            
                Request request = new Request() { Operation = Operation.GetPeriod, RequestObject = p };

                SenderAndReceiver.Send(request);
                Response response = SenderAndReceiver.Receive() as Response;

                if (response.IsSuccessful)
                    throw new GetAllException(response.Error);

            
            
        }

        internal void SaveGrades(List<Evalution> lists)
        {
            Request request = new Request() { Operation = Operation.AddGrades, RequestObject = lists };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new AddException(response.Error);
        }


        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }


        private Communication()
        {
         

        }

        internal void SaveAbsentsAndPeriod(Period period)
        {
            Request request = new Request() { Operation = Operation.AddAbsentsAndPeriod, RequestObject = period };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new AddException(response.Error);
        }

        internal List<Student> GetAllGradesForStudents(List<Student> students)
        {
            Request request = new Request() { Operation = Operation.GetAllGrades,RequestObject=students };

            SenderAndReceiver.Send(request);


            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new GetAllException(response.Error);

            return response.Result as List<Student>;
        }

        internal void Connect()
        {
            if (socket != null && socket.Connected)
            {
                return;
            }
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(ConfigurationManager.AppSettings["ip"], Int32.Parse(ConfigurationManager.AppSettings["port"]));
            SenderAndReceiver = new SenderAndReceiver(socket);
        }

        internal void SaveSchoolClass(SchoolClass schoolClass)
        {
            Request request = new Request() { Operation = Operation.AddSchoolClass,RequestObject=schoolClass };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new AddException(response.Error);

          
        }

        internal void SaveTeacher(Teacher teacher)
        {
            Request request = new Request() { Operation = Operation.AddTeacher, RequestObject = teacher };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new AddException(response.Error);
        }

        internal void Disconnect()
        {
            socket.Close();
            socket = null;
        }
        internal List<Subject> GetAllSubjects()
        {
            Request request = new Request() { Operation = Operation.GetAllSubjects };

             SenderAndReceiver.Send(request);
            
            
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new GetAllException(response.Error);

            return response.Result as List<Subject>;
        }
        internal List<Teacher> GetAllTeachers()
        {
            Request request = new Request() { Operation = Operation.GetAllTeachers };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new GetAllException(response.Error);

            return response.Result as List<Teacher>;
        }
        internal List<Student> GetAllStudentsFromSchoolClass(SchoolClass selectedItem)
        {
            Request request = new Request() { Operation = Operation.GetAllStudentsFromSchoolClass,RequestObject=selectedItem };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new Exception(response.Error);

            return response.Result as List<Student>;
        }

        internal void DeleteStudent(Student student)
        {
            Request request = new Request() { Operation = Operation.DeleteStudent, RequestObject = student};

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new DeleteException(response.Error);

        }

        internal void UpdateStudent(Student studentUpdate)
        {
            Request request = new Request() { Operation = Operation.UpdateStudent,RequestObject=studentUpdate };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new UpdateException(response.Error);

            
        }

        internal List<SchoolClass> GetAllSchoolClasses()
        {
            Request request = new Request() { Operation = Operation.GetAllSchoolClasses};

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new GetAllException(response.Error);

            return response.Result as List<SchoolClass>;
        }
        internal void SaveStudent(Student student)
        {
            Request request = new Request() { Operation = Operation.AddStudent, RequestObject = student };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (!response.IsSuccessful)
                throw new AddException(response.Error);
         
        }

        internal object Login(Admin user)
        {
            Request request = new Request() { Operation = Operation.Login, RequestObject = user };

            SenderAndReceiver.Send(request);
            Response response = SenderAndReceiver.Receive() as Response;

            if (response.IsSuccessful)
                
            return response.Result;
                else   
                throw new  LoginException("User doesn't exist");
        }
    }
}
