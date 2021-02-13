using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IEntity
    {
        string TableName { get; }
        string InsertValues { get; }
        string SetCondition { get; }
        string SetValue { get; }
        string WhereCondition { get; }
        string Join { get; }
        string OrderBy { get; }
        int Id { get; set; }
        string IdName { get; set; }

        List<IEntity> GetEntities(SqlDataReader reader);
    }
}
