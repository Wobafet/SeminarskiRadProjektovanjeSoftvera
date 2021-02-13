using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
   public  class SchoolClass:IEntity
    {
        
        public int Id { get; set; }
        public string SchoolClassName { get; set; }
        public Teacher ClassElder { get; set; }

        public List<Student> Students  { get; set; }

        public string TableName => "SchoolClass";

        public string InsertValues => $"'{SchoolClassName}',{ClassElder.Id}";

        public string SetCondition => throw new NotImplementedException();
       
        public string SetValue => throw new NotImplementedException();

        public string IdName { get; set; } = "SchoolClassId";

        public string OrderBy => $"SchoolClassName asc";

        public string Join => "";

        public string WhereCondition =>"";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new SchoolClass
                {
                    Id = reader.GetInt32(0),
                    SchoolClassName = reader.GetString(1),
                    ClassElder = new Teacher
                    {
                        Id = reader.GetInt32(2)
                    }
                });
            }
            return result;
        }

        public override string ToString()
        {
            return $"{SchoolClassName}";
        }
    }
}
