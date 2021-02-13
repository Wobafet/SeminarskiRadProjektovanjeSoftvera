using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.SubjectSO
{
    public class GetAllSubjectSO : SystemOperationBase
    {
        public List<Subject>Subjects { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Subjects = repository.GetAll(entity).Cast<Subject>().ToList();
        }
    }
}
