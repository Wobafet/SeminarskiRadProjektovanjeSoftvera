using BrokerDataBase;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation.InSql
{
    public class GenericRepository : IGenericRepository
    {
        private Broker broker = new Broker();
        public void Add(IEntity entity)
        {
            broker.Add(entity);
        }

        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void Delete(IEntity entity)
        {
            broker.Delete(entity);
        }

        public List<IEntity> GetAll(IEntity e)
        {
            return broker.GetAll(e);
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public void Update(IEntity entity)
        {
            broker.Update(entity);
        }
    }
}
