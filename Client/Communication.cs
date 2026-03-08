using Common;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Client
{
    public class Communication
    {
        private static Communication instance;
        public static Communication Instance 
        { 
            get 
            {
                if(instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            } 
        }

        private Communication()
        {
                
        }

        Socket socket;
        Sender sender;
        Receiver receiver;

        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(ConfigurationManager.AppSettings["ip"], int.Parse(ConfigurationManager.AppSettings["port"]));
            //socket.Connect("127.0.0.1", 9999);
            Debug.WriteLine(">>> Konektovani!!");

            sender = new Sender(socket);
            receiver = new Receiver(socket);

        }
        public void Close()
        {
            socket?.Close();
        }

        internal Bibliotekar LoginAdmin(string username, string password)
        {
            Bibliotekar user = new Bibliotekar
            {
                Username = username,
                Password = password
            };
            Request request = new Request(Operation.LoginAdmin,user);
            sender.Send(request);
            Response response = (Response)receiver.Receive();
           
            return (Bibliotekar)response.Result;
        }

        internal Clan LoginClan(string brojClanskeKarte, string password)
        {
            Clan user = new Clan()
            {
                BrojClanskeKarte = int.Parse(brojClanskeKarte),
                SifraNaloga = password
            };
            Request request = new Request(Operation.LoginClan, user);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return (Clan)response.Result;
        }

        internal bool Logout(string ulogovan)
        {
            Request request = new Request(Operation.Logout, ulogovan);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return response.IsSuccessful;
        }
        internal int KreirajNovogClana(Clan clan)
        {
            Request request = new Request(Operation.KreirajNovogClana, clan);
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            
            return (int)response.Result;
        }

        internal List<Clan> VratiSveClanove()
        {
            Request request = new Request(Operation.VratiSveClanove, null);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return (List<Clan>)response.Result;
        }

        internal List<Clan> PretraziClanove(string text)
        {
            Request request = new Request(Operation.PretraziClanove, text);
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            
            return (List<Clan>)response.Result;
        }

        internal bool IzmeniClana(Clan clan)
        {
            Request request = new Request(Operation.IzmeniClana, clan);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return response.IsSuccessful;
        }

        internal Response ObrisiClana(Clan clan)
        {
            Request request = new Request(Operation.ObrisiClana, clan);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return response;
        }

        internal List<Zanr> UcitajSveZnarove()
        {
            Request request = new Request(Operation.UcitajZanrove, null);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return (List<Zanr>)response.Result;
        }

        internal List<Izdavac> UcitajSveIzdavace()
        {
            Request request = new Request(Operation.UcitajIzdavace, null);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return (List<Izdavac>)response.Result;
        }

        internal List<Autor> UcitajAutore()
        {
            Request request = new Request(Operation.UcitajAutore, null);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return (List<Autor>)response.Result;
        }

        internal string DodajNovuKnjigu(Knjiga nova)
        {
            Request request = new Request(Operation.DodajNovuKnjigu, nova);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return (string)response.Result;
        }

        internal List<Knjiga> VratiSveKnjige()
        {
            Request request = new Request(Operation.VratiSveKnjige, null);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return (List<Knjiga>)response.Result;
        }

        internal List<Knjiga> PretraziKnjigePoNazivu(string text)
        {
            Request request = new Request(Operation.PretraziKnjige, text);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return (List<Knjiga>)response.Result;
        }

        internal Response ObrisiKnjigu(Knjiga knjiga)
        {
            Request request = new Request(Operation.ObrisiKnjigu, knjiga);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return response;
        }

        internal List<PrimerakKnjige> VratiSvePrimerkeKnjiga()
        {
            Request request = new Request(Operation.VratiSvePrimerkeKnjiga, null);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return (List<PrimerakKnjige>)response.Result;
        }

        internal List<int> KreirajZaduzenja(List<Zaduzenje> zaduzenja)
        {
            Request request = new Request(Operation.KreirajZaduzenje, zaduzenja);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return (List<int>)response.Result;
        }

        internal List<Zaduzenje> VratiSvaZaduzenja()
        {
            Request request = new Request(Operation.VratiSvaZaduzenja, null);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return (List<Zaduzenje>)response.Result;
        }

        internal List<Zaduzenje> PretraziZaduzenja(string text)
        {
            Request request = new Request(Operation.PretraziZaduzenja, text);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return (List<Zaduzenje>)response.Result;
        }

        internal bool RazduziKnjige(List<Zaduzenje> zaRazduzivanje)
        {
            Request request = new Request(Operation.RazduziKnjigu, zaRazduzivanje);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return response.IsSuccessful;
        }

        internal int DodajAutora(Autor autor)
        {
            Request request = new Request(Operation.DodajAutora, autor);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return (int)response.Result;
        }

        internal int DodajIzdavaca(Izdavac izdavac)
        {
            Request request = new Request(Operation.DodajIzdavaca, izdavac);
            sender.Send(request);
            Response response = (Response)receiver.Receive();

            return (int)response.Result;
        }
    }
}
