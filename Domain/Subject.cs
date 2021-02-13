using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Subject:IEntity
    {
        public int Id { get ; set ; }
      
        public string SubjectName { get; set; }

        public string TableName => "Subject";

        public string InsertValues => throw new NotImplementedException();

        public string SetCondition => throw new NotImplementedException();

        public string SetValue => throw new NotImplementedException();

        public string IdName { get; set; } = "SubjectId";

        public string OrderBy => "Name asc";

        public string Join => "";

        public string WhereCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Subject
                {
                    Id = reader.GetInt32(0),
                    SubjectName = reader.GetString(1),
                });
            }
            return result;
        }

        public override string ToString()
        {
            return $"{SubjectName}";
        }
    }
}
