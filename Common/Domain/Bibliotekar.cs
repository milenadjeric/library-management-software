using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Bibliotekar: IEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string TableName => "Bibliotekar";
        public string DisplayValues => "Username";
        public string PrimaryKey => Username;

        public object JoinQuery()
        {
            return "";
        }

        public object GetByIDQuery()
        {

            return $"Username='{Username}' AND Password='{Password}'";
        }
        public IEntity GetReaderResult(SqlDataReader reader)
        {
            if (reader.Read())
            {
                Bibliotekar admin = new Bibliotekar
                {
                    Username = (string)reader["Username"],
                    Password = (string)reader["Password"],
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"]
                };
                return admin;
            }
            return null;
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string GetParametres()
        {
            throw new NotImplementedException();
        }

        public void PrepareCommand(SqlCommand cmd)
        {
            throw new NotImplementedException();
        }

        public string UpdateQuery()
        {
            throw new NotImplementedException();
        }

        public string GetFilterQuery(string filter)
        {
            throw new NotImplementedException();
        }

        public string GetFirstColumn()
        {
            throw new NotImplementedException();
        }
    }
}
