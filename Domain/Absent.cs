using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]

    public class Absent : IEntity
    {
        public Period Period { get; set; }

        public Student Student { get; set; }
        public string TableName => "Absents";

        public string InsertValues => $"{Period.Id},{Student.Id}";

        public string SetCondition => $"StudentId={Student.Id}";

        public string SetValue => throw new NotImplementedException();

        public int Id { get ; set; }

       

        public string IdName { get; set; } = "PeriodId";

        public string OrderBy => "";

        public string Join => "a join Period p on (p.PeriodId=a.PeriodId)";

        public string WhereCondition => $"p.PeriodId={Period.Id}";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
