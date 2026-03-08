using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Zaduzenje : IEntity
    {
        public int ZaduzenjeID { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public bool Vraceno { get; set; }
        public Clan Clan { get; set; }
        public PrimerakKnjige Knjiga { get; set; }
       
        public string TableName => "Zaduzenje";

        public string DisplayValues => Clan.DisplayValues+" "+Knjiga.Knjiga.Naziv;

        public string PrimaryKey => ZaduzenjeID.ToString();

        public object GetByIDQuery()
        {
            return $"ZaduzenjeID={ZaduzenjeID}";
        }

        public string GetFilterQuery(string filter)
        {
            return $"Zaduzenje.BrojClanskeKarte = '{filter}'" +
                $"OR Zaduzenje.ISBN = '{filter}'";
        }

        public string GetFirstColumn()
        {
            return "ZaduzenjeID";
        }

        public string GetParametres()
        {
            return "@DatumOd, @DatumDo, @Vraceno, @Clan, @PrimerakID,@ISBN";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Autor a = new Autor();
                a.AutorID = (int)reader["AutorID"];
                a.ImeAutora = (string)reader["Ime"]; //imeautora!! vraca ime clana
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

                Clan clan = new Clan()
                {
                    BrojClanskeKarte = (int)reader["BrojClanskeKarte"],
                    Ime = (string)reader["Ime"],
                    Prezime = (string)reader["Prezime"],
                    JMBG = (string)reader["JMBG"],
                    Adresa = (string)reader["Adresa"],
                    Telefon = (string)reader["Telefon"],
                    Email = (string)reader["Email"],
                    SifraNaloga = (string)reader["SifraNaloga"]
                };

                Zaduzenje zaduzenje = new Zaduzenje()
                {
                    ZaduzenjeID = (int)reader["ZaduzenjeID"],
                    DatumOd = (DateTime)reader["DatumOd"], 
                    DatumDo = (DateTime)reader["DatumDo"],
                    Vraceno = Convert.ToBoolean(reader["Vraceno"]),
                    Clan = clan,
                    Knjiga = primerak
                };

                entities.Add(zaduzenje);
            }
            return entities;
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public object JoinQuery()
        {
            return "JOIN Clan c ON (c.BrojClanskeKarte = Zaduzenje.BrojClanskeKarte)" +
                "JOIN PrimerakKnjige pk ON (pk.ISBN = Zaduzenje.ISBN AND pk.PrimerakID=Zaduzenje.PrimerakID)" +
                "JOIN Knjiga k ON (k.ISBN=pk.ISBN) JOIN Autor a ON (k.AutorID = a.AutorID)" +
                "JOIN Zanr z ON (k.ZanrID = z.ZanrID) JOIN Izdavac i ON (k.IzdavacID = i.IzdavacID)";
        }

        public void PrepareCommand(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@DatumOd", DatumOd);
            cmd.Parameters.AddWithValue("@DatumDo", DatumDo);
            cmd.Parameters.AddWithValue("@Vraceno", Vraceno);
            cmd.Parameters.AddWithValue("@Clan", Clan.BrojClanskeKarte);
            cmd.Parameters.AddWithValue("@PrimerakID", Knjiga.PrimerakID);
            cmd.Parameters.AddWithValue("@ISBN", Knjiga.Knjiga.ISBN);
        }

        public string UpdateQuery()
        {
            return $"DatumDo= '{DatumDo.ToString("MM-dd-yyyy")}', Vraceno='{Vraceno}'";

        }
    }
}
