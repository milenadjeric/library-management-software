using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Zanr:IEntity
    {
        public int ZanrID { get; set; }
        public string NazivZanra { get; set; }

        public string TableName => "Zanr";

        public string DisplayValues => NazivZanra;

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
            throw new NotImplementedException();
        }

        public string GetParametres()
        {
            throw new NotImplementedException();
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Zanr zanr = new Zanr()
                {
                    ZanrID = (int)reader["ZanrID"],
                    NazivZanra = (string)reader["NazivZanra"]
                };
                entities.Add(zanr);
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
            throw new NotImplementedException();
        }

        public string UpdateQuery()
        {
            throw new NotImplementedException();
        }
        
    }
}
