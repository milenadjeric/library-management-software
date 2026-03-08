using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Knjiga : IEntity
    {
        public string ISBN { get; set; }
        public string Naziv { get; set; }
        public Autor Autor { get; set; }
        public int BrojStrana { get; set; }
        public Povez Povez { get; set; } 
        public Izdavac Izdavac { get; set; }
        public int GodinaIzdavanja { get; set; }
        public Zanr Zanr { get; set; }
        public int BrojPrimeraka { get; set; }
        public string TableName => "Knjiga";

        public string DisplayValues => Naziv;

        public string PrimaryKey => "ISBN";

        public object GetByIDQuery()
        {
            return $"ISBN='{ISBN}'";
        }

        public string GetFilterQuery(string filter)
        {
            return $"Naziv LIKE '%{filter}%' OR ISBN LIKE '%{filter}%'";
                
        }

        public string GetFirstColumn()
        {
            return "ISBN";
        }

        public string GetParametres()
        {
            return "@ISBN, @Naziv, @Autor, @BrojStrana, @Povez, @Izdavac, @GodinaIzdavanja, @Zanr, @BrojPrimeraka";
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
                z.ZanrID= (int)reader["ZanrID"];
                z.NazivZanra = (string)reader["NazivZanra"];

                Knjiga knjga = new Knjiga()
                {
                    ISBN = (string)reader["ISBN"],
                    Naziv = (string)reader["Naziv"],
                    Autor = a,
                    BrojStrana = (int)reader["BrojStrana"],
                    Povez = (Povez)reader["Povez"],
                    Izdavac=i,
                    GodinaIzdavanja = (int)reader["GodinaIzdavanja"],
                    Zanr = z ,
                    BrojPrimeraka = (int)reader["BrojPrimeraka"]
                    
                };
                entities.Add(knjga);
            }
            return entities;
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string GetSearchAttributes()
        {
            throw new NotImplementedException();
        }

        public object JoinQuery()
        {
            return "JOIN Autor a ON (a.AutorID=Knjiga.AutorID) JOIN Izdavac i ON (i.IzdavacID=Knjiga.IzdavacID) " +
                "JOIN Zanr z ON (z.ZanrID=Knjiga.ZanrID)"; 
        }

        public void PrepareCommand(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@ISBN", ISBN);
            cmd.Parameters.AddWithValue("@Naziv", Naziv);
            cmd.Parameters.AddWithValue("@Autor", Autor.AutorID);
            cmd.Parameters.AddWithValue("@BrojStrana", BrojStrana);
            cmd.Parameters.AddWithValue("@Povez", Povez);
            cmd.Parameters.AddWithValue("@Izdavac", Izdavac.IzdavacID);
            cmd.Parameters.AddWithValue("@GodinaIzdavanja", GodinaIzdavanja);
            cmd.Parameters.AddWithValue("@Zanr", Zanr.ZanrID);
            cmd.Parameters.AddWithValue("@BrojPrimeraka", BrojPrimeraka);
        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string UpdateQuery()
        {
            throw new NotImplementedException();
        }
    }
}
