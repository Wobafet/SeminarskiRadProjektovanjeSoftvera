using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.StudentSO
{
    public class GetAllStudentsSO : SystemOperationBase
    {
        public List<Student> Students { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Students = repository.GetAll(entity).Cast<Student>().ToList();
        }
    }
}
