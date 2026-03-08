using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DBBroker
{
    public class DbConection
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public DbConection()
        {
            //connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=projekat;Integrated Security=True;"); 
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection?.Close();
        }
        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction?.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public SqlCommand CreateCommand() 
        {
            return new SqlCommand("", connection, transaction);
        }   

    }
}
