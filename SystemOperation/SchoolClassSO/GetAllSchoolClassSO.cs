using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.SchoolClassSO
{
    public class GetAllSchoolClassSO : SystemOperationBase
    {
        public List<SchoolClass> SchoolClasses{ get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            SchoolClasses = repository.GetAll(entity).Cast<SchoolClass>().ToList();
        }
    }
}
