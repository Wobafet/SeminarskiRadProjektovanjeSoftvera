using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.SchoolClassSO
{
    public class AddSchoolClassSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {

            repository.Add(entity);
        }
    }
}
