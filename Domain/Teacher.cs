using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
   public  class Teacher:IEntity
    {
        public int Id { get ; set ; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password{ get; set; }
        public Subject Subject { get; set; }

        public string TableName => "Teacher";
 
        public string InsertValues => $"'{FirstName}','{LastName}','{Email}','{Password}',{Subject.Id}";

        public string SetCondition => throw new NotImplementedException();

        public string SetValue => throw new NotImplementedException();

        public string IdName { get; set; } = "TeacherId";

        public string OrderBy => "LastName asc,FirstName asc";

        public string Join => $"t join Subject s on(t.SubjectId = s.SubjectId)";

        public string WhereCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Teacher
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Email = reader.GetString(3),
                    Password = reader.GetString(4),

                    Subject = new Subject
                    {
                        Id = reader.GetInt32(5),

                        SubjectName = reader["Name"].ToString()


                    }
                });
            }
            return result;
        }

        public override string ToString()
        {
            return $"{FirstName } {LastName}";
        }
    }
}
