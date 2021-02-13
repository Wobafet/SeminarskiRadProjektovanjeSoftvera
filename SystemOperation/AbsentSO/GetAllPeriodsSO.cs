using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.AbsentSO
{
    public class GetAllPeriodsSO : SystemOperationBase
    {
        public List<Period> Periods { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Periods = repository.GetAll(entity).Cast<Period>().ToList();
        }
    }
}
