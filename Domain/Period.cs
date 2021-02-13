using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
   public  class Period:IEntity
    {
        public int Id { get ; set ; }

        public int PeriodNumber { get; set; }
        public SchoolClass SchoolClass { get; set; }

        public Teacher Teacher { get; set; }

        public Subject Subject { get; set; }

        public DateTime DateTime{ get; set; }

        public List<Student> ApsentStudents{ get; set; }

        public string TableName => $"Period";

        public string InsertValues => $"{Subject.Id},{SchoolClass.Id},{Teacher.Id},{PeriodNumber}";

        public string SetCondition => "";

        public string SetValue => "";

        public string IdName { get; set; } = "PeriodId";

        public string OrderBy => "PeriodId asc";

        public string Join => "";

        public string WhereCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Period
                {
                    Id=reader.GetInt32(0),
                    Subject=new Subject { Id=reader.GetInt32(1)},
                    Teacher = new Teacher{ Id = reader.GetInt32(3) },
                    SchoolClass = new SchoolClass{ Id = reader.GetInt32(2) },
                    PeriodNumber = reader.GetInt32(4),
                });
            }
            return result;
        }
    }
}
