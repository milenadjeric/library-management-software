using Common.Domain;
using DBBroker;
using Server.SystemOperations;
using Server.SystemOperations.AutorSO;
using Server.SystemOperations.ClanSO;
using Server.SystemOperations.IzdavacSO;
using Server.SystemOperations.KnjigaSO;
using Server.SystemOperations.ZaduzenjeSO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Controller
    {
        public List<string> ulogovani;
        private static Controller instance;
        public static Controller Instance
        { 
            get
            {
                if (instance == null)
                {
                    instance = new Controller();                    
                }
                return instance;
            } 
        }

        private Controller()
        {
            ulogovani = new List<string>();
        }

        internal object LoginAdmin(Bibliotekar bibliotekar)
        {
            string logovan = bibliotekar.Username + bibliotekar.Password;
            bool postoji = IsLogedIn(logovan);
            if (postoji)
            {
                bibliotekar.Username = null;
                return bibliotekar;
            }
            else
            {
                ulogovani.Add(logovan);
            }

            LoginAdminSO so = new LoginAdminSO(bibliotekar);
            so.ExecuteTemplate();
            return so.Result;
        }
        internal bool IsLogedIn(string korisnik)
        {
            foreach (string k in ulogovani)
            {
                if (korisnik == k)
                {
                    return true;
                }
            }
            return false;
        }
        internal object LoginClan(Clan clan)
        {
            string logovan = clan.BrojClanskeKarte + clan.SifraNaloga;
            bool postoji = IsLogedIn(logovan);
            if (postoji)
            {
                clan.BrojClanskeKarte = 0;
                return clan;
            }
            else
            {
                ulogovani.Add(logovan);
            }

            LoginClanSO so = new LoginClanSO(clan);
            so.ExecuteTemplate();
            return so.Result;
        }
        
        internal bool Logout(string ulogovan)
        {
           return ulogovani.Remove(ulogovan);
        }

        internal int KreirajNovogClana(Clan argument)
        {
            KreirajClanaSO so = new KreirajClanaSO(argument);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal object VratiSveClanove()
        {
            VratiSveClanoveSO so = new VratiSveClanoveSO();
            so.ExecuteTemplate();
            return so.Result.Cast<Clan>().ToList();
        }

        internal List<Clan> PretraziClanove(string brClanskeKarte)
        {
            PretraziClanoveSO so = new PretraziClanoveSO(brClanskeKarte);
            so.ExecuteTemplate();
            return so.Result.Cast<Clan>().ToList();
        }

        internal bool IzmeniClana(Clan argument)
        {
            IzmeniClanaSO so = new IzmeniClanaSO(argument);
            so.ExecuteTemplate();
            return so.IsSucseful;
        }

        internal string ObrisiClana(Clan argument)
        {
            ObrisiClanaSO so = new ObrisiClanaSO(argument);
            so.ExecuteTemplate();
            return so.Message;
        }

        internal List<Zanr> UcitajZanrove()
        {
            UcitajZanroveSO so = new UcitajZanroveSO();
            so.ExecuteTemplate();
            return so.Result.Cast<Zanr>().ToList();
        }

        internal List<Izdavac> UcitajIzdavace()
        {
            UcitajIzdavaceSO so = new UcitajIzdavaceSO();
            so.ExecuteTemplate();
            return so.Result.Cast<Izdavac>().ToList();
        }

        internal List<Autor> UcitajAutore()
        {
            UcitajAutoreSO so = new UcitajAutoreSO();
            so.ExecuteTemplate();
            return so.Result.Cast<Autor>().ToList();
        }

        internal string DodajNovuKnjigu(Knjiga argument)
        {
            DodajNovuKnjiguSO so = new DodajNovuKnjiguSO(argument);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal List<Knjiga> VratiSveKnjige()
        {
            VratiSveKnjigeSO so = new VratiSveKnjigeSO();
            so.ExecuteTemplate();
            return so.Result.Cast<Knjiga>().ToList();
        }

        internal List<Knjiga> PretraziKnjige(string naziv)
        {
            PretraziKnjigeSO so = new PretraziKnjigeSO(naziv);
            so.ExecuteTemplate();
            return so.Result.Cast<Knjiga>().ToList();
        }

        internal string ObrisiKnjigu(Knjiga argument)
        {
            ObrisiKnjiguSO so = new ObrisiKnjiguSO(argument);
            so.ExecuteTemplate();
            return so.Message;
        }

        internal List<PrimerakKnjige> VratiSvePrimerkeKnjiga()
        {
            VratiSvePrimerkeKnjigaSO so = new VratiSvePrimerkeKnjigaSO();
            so.ExecuteTemplate();
            return so.Result.Cast<PrimerakKnjige>().ToList();
        }

        internal List<int> KreirajZaduzenje(List<Zaduzenje> argument)
        {
            KreirajZaduzenjeSO so = new KreirajZaduzenjeSO(argument);
            so.ExecuteTemplate();
            return so.Result.Cast<int>().ToList();
        }

        internal List<Zaduzenje> VratiSvaZaduzenja()
        {
            VratiSvaZaduzenjaSO so = new VratiSvaZaduzenjaSO();
            so.ExecuteTemplate();
            return so.Result.Cast<Zaduzenje>().ToList();
        }

        internal List<Zaduzenje> PretraziZaduzenja(string text)
        {
            PretraziZaduzenjaSO so = new PretraziZaduzenjaSO(text);
            so.ExecuteTemplate();
            return so.Result.Cast<Zaduzenje>().ToList();
        }

        internal bool RazduziKnjigu(List<Zaduzenje> argument)
        {
            RazduziKnjiguSO so = new RazduziKnjiguSO(argument);
            so.ExecuteTemplate();
            return so.IsSucseful;
        }

        internal int DodajAutora(Autor argument)
        {
            DodajAutoraSO so = new DodajAutoraSO(argument);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal object DodajIzdavaca(Izdavac argument)
        {
            DodajIzdavacaSO so = new DodajIzdavacaSO(argument);
            so.ExecuteTemplate();
            return so.Result;
        }
    }
}
