using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace DBBroker
{
    public class Broker
    {
        private DbConection connection;
        public Broker()
        {
            connection = new DbConection();
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }

        public void CloseConnection()
        {
            connection?.CloseConnection();
        }
        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void Rollback()
        {
            connection.Rollback();
        }
        public IEntity GetEntityByID(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {entity.TableName} {entity.JoinQuery()} WHERE {entity.GetByIDQuery()}";
            SqlDataReader reader = cmd.ExecuteReader();
            entity = entity.GetReaderResult(reader);

            reader.Close();
            cmd.Dispose();
            return entity;
        }

        public object Add(IEntity entity)
        {
            SqlCommand cmd =connection.CreateCommand();
            cmd.CommandText = $"INSERT INTO {entity.TableName} OUTPUT INSERTED.{entity.GetFirstColumn()} VALUES({entity.GetParametres()})";
            entity.PrepareCommand(cmd);
            object result = cmd.ExecuteScalar();
            cmd.Dispose();
            if(result==null)
            {
                return 0;
            }
            else
            {
                return result;
            }
        }


        public List<IEntity> GetAll(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {entity.TableName} {entity.JoinQuery()}";
            SqlDataReader r = cmd.ExecuteReader();
            List<IEntity> result = entity.GetReaderList(r);
            r.Close();
            cmd.Dispose();
            return result;
        }

        public List<IEntity> GetAllFiltered(IEntity entity, string filter)
        {
            SqlCommand cmd=connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {entity.TableName} {entity.JoinQuery()} WHERE {entity.GetFilterQuery(filter)} ";
            SqlDataReader r = cmd.ExecuteReader();
            List<IEntity> result = entity.GetReaderList(r);
            r.Close();
            cmd.Dispose();
            return result;
        }

        public int Update(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"UPDATE {entity.TableName} SET {entity.UpdateQuery()} WHERE {entity.GetByIDQuery()}";
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return result;
        }

        public int Delete(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"DELETE FROM {entity.TableName} WHERE {entity.GetByIDQuery()}";
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return result;
        }


    }
}
