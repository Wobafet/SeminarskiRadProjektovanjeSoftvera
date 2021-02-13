using Domain;
using Storage.Implementation;
using Storage.Implementation.InSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public abstract class SystemOperationBase
    {
        protected IGenericRepository repository=new GenericRepository();

        public SystemOperationBase()
        {
        }

        public void ExecuteTemplate(IEntity entity)
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();
                ExecuteOperation(entity);
                repository.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.CloseConnection();
            }
        }

        protected abstract void ExecuteOperation(IEntity entity);
    }
}
