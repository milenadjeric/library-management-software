using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class PrimerakKnjige:IEntity
    {
        public int PrimerakID { get; set; }
        public bool Status { get; set; }
        public Knjiga Knjiga { get; set; } 

        public string TableName => "PrimerakKnjige";

        public string DisplayValues => Knjiga.Naziv;

        public string PrimaryKey => PrimerakID+" "+ Knjiga.PrimaryKey;

        public object GetByIDQuery()
        {
            return $"ISBN='{Knjiga.ISBN}' AND PrimerakID={PrimerakID}";
        }

        public string GetFilterQuery(string filter)
        {
            throw new NotImplementedException();
        }

        public string GetFirstColumn()
        {
            return "PrimerakID";
        }

        public string GetParametres()
        {
            return "@Status, @ISBN";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Autor a = new Autor();
                a.AutorID = (int)reader["AutorID"];
                a.ImeAutora = (string)reader["Ime"];
                a.PrezimeAutora = (string)reader["Prezime"];

                Izdavac i = new Izdavac();
                i.IzdavacID = (int)reader["IzdavacID"];
                i.NazivIzdavaca = (string)reader["NazivIzdavaca"];

                Zanr z = new Zanr();
                z.ZanrID = (int)reader["ZanrID"];
                z.NazivZanra = (string)reader["NazivZanra"];

                Knjiga knjiga = new Knjiga()
                {
                    ISBN = (string)reader["ISBN"],
                    Naziv = (string)reader["Naziv"],
                    Autor = a,
                    BrojStrana = (int)reader["BrojStrana"],
                    Povez = (Povez)reader["Povez"],
                    Izdavac = i,
                    GodinaIzdavanja = (int)reader["GodinaIzdavanja"],
                    Zanr = z,
                    BrojPrimeraka = (int)reader["BrojPrimeraka"]

                };

                PrimerakKnjige primerak = new PrimerakKnjige()
                {
                    PrimerakID = (int)reader["PrimerakID"],
                    Status = Convert.ToBoolean(reader["Status"]),
                    Knjiga = knjiga,
                };

                entities.Add(primerak);
            }
            return entities;
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public object JoinQuery()
        {
            return "JOIN Knjiga k ON (k.ISBN=PrimerakKnjige.ISBN) JOIN Autor a ON (k.AutorID = a.AutorID) " +
                "JOIN Zanr z ON (k.ZanrID = z.ZanrID) JOIN Izdavac i ON (k.IzdavacID = i.IzdavacID)";
        }

        public void PrepareCommand(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@ISBN", Knjiga.ISBN);

        }

        public string UpdateQuery()
        {
            return $"Status = '{Status}'";
        }
    }
}
