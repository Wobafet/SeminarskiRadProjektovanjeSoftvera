using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerDataBase
{
    public class Broker
    {

        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {

            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SchoolDatabase"].ConnectionString);
        }

        public void Add(IEntity entity)
        {

            SqlCommand command = new SqlCommand("", connection, transaction);
            command.Transaction = transaction;
            command.CommandText = $"insert into {entity.TableName} output inserted.{entity.IdName} values({entity.InsertValues})";

            entity.Id= (int)command.ExecuteScalar();
            
        }

       
        public void Delete(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);

            command.CommandText = $"delete from {entity.TableName} where {entity.SetCondition}";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
           
        }

    

        public void Update(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
           

            command.CommandText = $"update {entity.TableName} set {entity.SetValue} where {entity.SetCondition}";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
          
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            List<IEntity> entities = new List<IEntity>();

            SqlCommand command = new SqlCommand("", connection, transaction);


            if(entity.WhereCondition=="")
            command.CommandText = $"select * from {entity.TableName} {entity.Join} order by {entity.OrderBy}";
            else
                command.CommandText = $"select * from {entity.TableName} {entity.Join} where {entity.WhereCondition} order by {entity.OrderBy}";
            SqlDataReader reader = command.ExecuteReader();

           
            
            entities= entity.GetEntities(reader);
            reader.Close();



            return entities;
        }
       


        #region Connection and Transaction
        public void OpenConnection() => connection.Open();
        public void CloseConnection() => connection.Close();
        public void BeginTransaction() => transaction = connection.BeginTransaction();
        public void Commit() => transaction.Commit();
        public void Rollback() => transaction.Rollback();

        #endregion

    }
}
