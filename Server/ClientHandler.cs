using Common;
using ControllerClass;
using Domain;
using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace ServerApp
{
    internal class ClientHandler
    {
        private Socket client;
        private Server server;
        private SenderAndReceiver senderAndReceiver;

        public ClientHandler(Socket client, Server server)
        {
            this.client = client;
            this.server = server;
            senderAndReceiver = new SenderAndReceiver(client);
        }

        internal void Listen()
        {
            try
            {
                while (true)
                {
                    Response response;
                    try
                    {
                        Request request = senderAndReceiver.Receive() as Request;
                       response = OperationHandler(request);
                    }
                    catch (Exception ex)
                    {
                         response = new Response() { IsSuccessful = false, Error = ex.Message };
                         
                    }
                    senderAndReceiver.Send(response);
                }
            }
            catch (Exception)
            {

            }
        }

        private Response OperationHandler(Request request)
        {
            Response response;
            switch (request.Operation)
            {
                case Operation.Login:
                    Admin a = Controller.Instance.LoginAdmin(request.RequestObject);
                    if (a != null)
                    {

                        return response = new Response() { IsSuccessful = true, Result = a };
                    }
                    Teacher t = Controller.Instance.LoginTeacher(request.RequestObject);
                    if (t != null)
                    {

                        return response = new Response() { IsSuccessful = true, Result = t };
                    }

                    return response = new Response() { IsSuccessful = false };

                case Operation.AddStudent:

                    Controller.Instance.AddStudent(request.RequestObject as Student);
                    return response = new Response() { IsSuccessful = true };

                case Operation.DeleteStudent:

                    Controller.Instance.DeleteStudent(request.RequestObject as Student);
                    return response = new Response() { IsSuccessful = true };



                case Operation.UpdateStudent:

                    Controller.Instance.UpdateStudent(request.RequestObject as Student);
                    return response = new Response() { IsSuccessful = true };

                case Operation.AddSchoolClass:

                    Controller.Instance.AddSchoolClass(request.RequestObject as SchoolClass);
                    return response = new Response() { IsSuccessful = true };



                case Operation.AddTeacher:

                    Controller.Instance.AddTeacher(request.RequestObject as Teacher);
                    return response = new Response() { IsSuccessful = true };



                case Operation.GetAllSchoolClasses:

                    List<SchoolClass> sc = Controller.Instance.GetAllSchoolClasses();
                    return response = new Response() { IsSuccessful = true, Result = sc };


                case Operation.GetAllStudentsFromSchoolClass:

                    List<Student> sc2 = Controller.Instance.GetAllStudentFromSchoolClass(request.RequestObject as SchoolClass);
                    return response = new Response() { IsSuccessful = true, Result = sc2 };


                case Operation.GetAllTeachers:

                    List<Teacher> sc3 = Controller.Instance.GetAllTeachers();
                    return response = new Response() { IsSuccessful = true, Result = sc3 };


                case Operation.GetAllSubjects:

                    List<Subject> sc4 = Controller.Instance.GetAllSubjects();
                    return response = new Response() { IsSuccessful = true, Result = sc4 };

                case Operation.GetAllGrades:

                    List<Student> sc5 = Controller.Instance.GetAllGrade(request.RequestObject as List<Student>);
                    return response = new Response() { IsSuccessful = true, Result = sc5 };

                case Operation.GetPeriod:

                    Period p2 = request.RequestObject as Period;
                    List<Period> periods = Controller.Instance.GetAllPeriods();

                    Period p = periods.Find(ps => ps.Subject.Id == p2.Subject.Id && ps.SchoolClass.Id == p2.SchoolClass.Id && ps.Teacher.Id == p2.Teacher.Id && ps.PeriodNumber == p2.PeriodNumber);
                    if(p!=null)
                    return response = new Response() { IsSuccessful=true};
                    throw new Exception();

                case Operation.AddAbsentsAndPeriod:

                    Controller.Instance.AddAbsentsAndPeriod(request.RequestObject as Period);
                    return response = new Response() { IsSuccessful = true };

                case Operation.AddGrades:

                    Controller.Instance.AddGrades(request.RequestObject as List<Evalution>);
                    return response = new Response() { IsSuccessful = true };


            }
            throw new Exception("Operation doesnt exist");
        }

        internal void Close()
        {
            client.Close();
        }
    }
}