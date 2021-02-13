using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.StudentSO
{
    public class AddStudentSO : SystemOperationBase
    {

        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Add(entity);   
        }
    }
}
