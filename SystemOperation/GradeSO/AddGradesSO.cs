using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation.GradeSO
{
    public class AddGradesSO:SystemOperationBase
    {
   
        private List<Evalution> Evalutions;

        public AddGradesSO(List<Evalution> lists)
        {
            this.Evalutions = lists;
        }

        protected override void ExecuteOperation(IEntity entity)
        {
            foreach (var item in Evalutions)
            {
                try
                {

                    repository.Add(item);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {

                    repository.Update(item);
                    }
                    else
                    {

                    throw new Exception(ex.Message);
                    }

                }

            }
           
        }
    }
}
