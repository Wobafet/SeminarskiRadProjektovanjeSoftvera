using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.GradeSO
{
    public class GetAllGradesSO : SystemOperationBase
    {
        public  List<Student> students;
        protected override void ExecuteOperation(IEntity entity)
        {
            foreach (var item in students)
            {
                Evalution e = (Evalution)entity;
                e.Student = item;
                item.Evalutions= repository.GetAll(e).Cast<Evalution>().ToList();
            }
        }
    }
}
