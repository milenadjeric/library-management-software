using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public interface IEntity
    {
        string TableName { get; }
        string DisplayValues { get; }
        string PrimaryKey { get; }

        List<IEntity> GetReaderList(SqlDataReader reader);
        object JoinQuery();
        object GetByIDQuery();
        IEntity GetReaderResult(SqlDataReader reader);
        string GetParametres();
        string GetFirstColumn();
        void PrepareCommand(SqlCommand cmd);
        string UpdateQuery();
        string GetFilterQuery(string filter);
    }
}
