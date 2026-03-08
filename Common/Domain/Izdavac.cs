using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Izdavac:IEntity
    {
        public int IzdavacID { get; set; }
        public string NazivIzdavaca { get; set; }

        public string TableName => "Izdavac";

        public string DisplayValues => NazivIzdavaca;

        public string PrimaryKey => throw new NotImplementedException();

        public object GetByIDQuery()
        {
            throw new NotImplementedException();
        }

        public string GetFilterQuery(string filter)
        {
            throw new NotImplementedException();
        }

        public string GetFirstColumn()
        {
            return "IzdavacID";
        }

        public string GetParametres()
        {
            return "@NazivIzdavaca";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Izdavac izdavac = new Izdavac()
                {
                    IzdavacID = (int)reader["IzdavacID"],
                    NazivIzdavaca = (string)reader["NazivIzdavaca"]
                };
                entities.Add(izdavac);
            }
            return entities;
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public object JoinQuery()
        {
            return "";
        }

        public void PrepareCommand(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@NazivIzdavaca", NazivIzdavaca);
        }

        public string UpdateQuery()
        {
            throw new NotImplementedException();
        }
    }
}
