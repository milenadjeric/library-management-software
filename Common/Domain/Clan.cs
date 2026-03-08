using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Clan:IEntity
    {
        public int BrojClanskeKarte { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public string SifraNaloga { get; set; }

        public string TableName => "Clan";

        public string DisplayValues => Ime+" "+Prezime;

        public string PrimaryKey => BrojClanskeKarte.ToString();

        public object GetByIDQuery()
        {
            return $"BrojClanskeKarte={BrojClanskeKarte}";
        }

        public string GetFilterQuery(string filter)
        {
            return $"BrojClanskeKarte LIKE '%{filter}%' OR Ime LIKE '%{filter}%'" +
                $"OR Prezime LIKE '%{filter}%'";
        }

        public string GetFirstColumn()
        {
            return "BrojClanskeKarte";
        }

        public string GetParametres()
        {
            return "@Ime,@Prezime,@JMBG,@Adresa,@Telefon,@Email,@SifraNaloga";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Clan clan = new Clan
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
                entities.Add(clan);
            }
            return entities;
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            if (reader.Read())
            {
                Clan clan = new Clan
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
                return clan;
            }
            return null;
        }

        public object JoinQuery()
        {
            return "";
        }

        public void PrepareCommand(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Ime", Ime);
            cmd.Parameters.AddWithValue("@Prezime", Prezime);
            cmd.Parameters.AddWithValue("@JMBG", JMBG);
            cmd.Parameters.AddWithValue("@Adresa", Adresa);
            cmd.Parameters.AddWithValue("@Telefon", Telefon);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@SifraNaloga", SifraNaloga);
            
        }


        public string UpdateQuery()
        {
            return $"Ime= '{Ime}', Prezime = '{Prezime}',JMBG='{JMBG}', Adresa='{Adresa}', Telefon='{Telefon}', Email='{Email}'";
        }
    }
}
