using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Autor : IEntity
    {
        public int AutorID { get; set; }
        public string ImeAutora { get; set; }
        public string PrezimeAutora { get; set; }
        public string TableName => "Autor";

        public string DisplayValues => AutorID + "    " + ImeAutora + " " + PrezimeAutora;

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
            return "AutorID";
        }

        public string GetParametres()
        {
            return "@ImeAutora, @PrezimeAutora";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Autor autor = new Autor()
                {
                    AutorID = (int)reader["AutorID"],
                    ImeAutora = (string)reader["Ime"],
                    PrezimeAutora = (string)reader["Prezime"]
                };
                entities.Add(autor);
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
            cmd.Parameters.AddWithValue("@ImeAutora", ImeAutora);
            cmd.Parameters.AddWithValue("@PrezimeAutora", PrezimeAutora);
        }

        public string UpdateQuery()
        {
            throw new NotImplementedException();
        }
        
    }
}
