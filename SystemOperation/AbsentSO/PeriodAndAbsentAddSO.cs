using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.AbsentSO
{
    public class PeriodAndAbsentAddSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Period p = entity as Period;
            repository.Add(p);

            foreach (var item in p.ApsentStudents)
            {
                Absent a = new Absent() { Period = p, Student = item };
                
                    repository.Add(a);
                             
            }
        }
    }
}
