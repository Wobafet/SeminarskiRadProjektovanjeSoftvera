using Domain.Grade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Evalution:IEntity
    {
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public Grades? Grade { get; set; }
        public GradeType GradeType { get; set; }
        public ClassificationPeriod ClassificationPeriod { get; set; }

        public string TableName => "Grades";

        public string InsertValues => $"{Student.Id},{Subject.Id},{(int)Grade},{(int)GradeType},{(int)ClassificationPeriod}";

        public string SetCondition => $"StudentId={Student.Id} and GradeType={(int)GradeType} and SubjectId={Subject.Id} and ClassificationPeriod={(int)ClassificationPeriod}";

        public string SetValue => $"Grade={(int)Grade}";

        public string WhereCondition => $"s.StudentId={Student.Id} and g.SubjectId={Student.CurrentSubject.Id}";

        public string Join => "g join Student s on (g.StudentId=s.StudentId)";

        public string OrderBy => "ClassificationPeriod asc";

        public int Id { get; set; }
        public string IdName { get; set; } = "GradeId";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Evalution
                {
                    //Student = new Student { Id = reader.GetInt32(1),FirstName=reader.GetString(7),LastName=reader.GetString(8),SchoolClass = new SchoolClass { Id=9} },
                    Subject = new Subject { Id = reader.GetInt32(2) },
                    Grade=(Grades)reader.GetInt32(3),
                    GradeType=(GradeType)reader.GetInt32(4),
                    ClassificationPeriod=(ClassificationPeriod)reader.GetInt32(5)
                   
                });
            }
            return result;
        }
    }
}
