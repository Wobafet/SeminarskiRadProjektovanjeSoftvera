using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.TeacherSO
{
    public class GetAllTeacherSO : SystemOperationBase
    {
        public List<Teacher> Teachers{ get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Teachers= repository.GetAll(entity).Cast<Teacher>().ToList();
        }
    }
}
