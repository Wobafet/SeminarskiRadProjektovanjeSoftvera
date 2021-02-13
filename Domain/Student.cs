using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
  public   class Student:IEntity
    {
        public string  LastName { get; set; }
        public string FirstName { get; set; }

        [Browsable(false)]
        public Subject CurrentSubject { get; set; }

        [Browsable(false)]
        public List<Evalution> Evalutions { get; set; }

        [Browsable(false)]
        public int Id { get ; set; }
       
        [Browsable(false)]
        public SchoolClass SchoolClass{ get; set; }
        public List<Period> ApsentPeriod{ get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Student
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    SchoolClass = new SchoolClass
                    {
                        Id = reader.GetInt32(3),
                        SchoolClassName=reader.GetString(5)
                    }
                });
            }
            return result;
        }

        [Browsable(false)]
        public string TableName => "Student";
        [Browsable(false)]
        public string InsertValues => $"'{FirstName}','{LastName}',{SchoolClass.Id}";
        [Browsable(false)]
        public string SetCondition => $"studentid={Id}";
        [Browsable(false)]
        public string SetValue => $"StudentFirstName='{FirstName}',StudentLastName='{LastName}',SchoolClassId={SchoolClass.Id}";
        [Browsable(false)]
        public string IdName { get; set; } = "StudentId";
        [Browsable(false)]
        public string OrderBy => $"StudentLastName asc, StudentFirstName asc";
        [Browsable(false)]
        public string Join => "s join SchoolClass sc on (s.SchoolClassId=sc.SchoolClassId)";
        [Browsable(false)]
        public string WhereCondition => $"sc.SchoolClassId = {SchoolClass.Id}";


       
    }
}
