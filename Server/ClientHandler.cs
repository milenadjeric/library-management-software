using Common;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class ClientHandler
    {
        private Socket socket;
        private Sender sender;
        private Receiver receiver;

        public ClientHandler(Socket clientSocket)
        {
            this.socket = clientSocket;
            sender = new Sender(clientSocket);
            receiver = new Receiver(clientSocket);
        }

        internal void HandleRequest()
        {
            try
            {
                while (true)
                {
                    Request request = (Request)receiver.Receive();
                    Response response = ProcessRequest(request);
                    sender.Send(response);
                }
            }
            catch (Exception)
            {
                Server.clients.Remove(this);
            }
            finally
            {
                socket.Close();
            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();

            try
            {
                switch (request.Operation)
                {
                    case Operation.LoginAdmin:
                        response.Result = Controller.Instance.LoginAdmin((Bibliotekar)request.Argument);
                        break;
                    case Operation.LoginClan:
                        response.Result = Controller.Instance.LoginClan((Clan)request.Argument);
                        break;
                    case Operation.Logout:
                        response.IsSuccessful = Controller.Instance.Logout((String)request.Argument);
                        break;
                    case Operation.KreirajNovogClana:
                        response.Result = Controller.Instance.KreirajNovogClana((Clan)request.Argument);
                        break;
                    case Operation.VratiSveClanove:
                        response.Result = Controller.Instance.VratiSveClanove();
                        break;
                    case Operation.PretraziClanove:
                        response.Result = Controller.Instance.PretraziClanove(request.Argument.ToString());
                        break;
                    case Operation.IzmeniClana:
                        response.IsSuccessful = Controller.Instance.IzmeniClana((Clan)request.Argument);
                        break;
                    case Operation.ObrisiClana:
                        response.Message = Controller.Instance.ObrisiClana((Clan)request.Argument);
                        if (response.Message == null) { response.IsSuccessful = true; }
                        break;
                    case Operation.UcitajZanrove:
                        response.Result = Controller.Instance.UcitajZanrove();
                        break;
                    case Operation.UcitajIzdavace:
                        response.Result = Controller.Instance.UcitajIzdavace();
                        break;
                    case Operation.UcitajAutore:
                        response.Result = Controller.Instance.UcitajAutore();
                        break;
                    case Operation.DodajNovuKnjigu:
                        response.Result = Controller.Instance.DodajNovuKnjigu((Knjiga)request.Argument);
                        break;
                    case Operation.VratiSveKnjige:
                        response.Result = Controller.Instance.VratiSveKnjige();
                        break;
                    case Operation.PretraziKnjige:
                        response.Result = Controller.Instance.PretraziKnjige(request.Argument.ToString());
                        break;
                    case Operation.ObrisiKnjigu:
                        response.Message = Controller.Instance.ObrisiKnjigu((Knjiga)request.Argument);
                        if (response.Message == null) { response.IsSuccessful = true; }
                        break;
                    case Operation.VratiSvePrimerkeKnjiga:
                        response.Result = Controller.Instance.VratiSvePrimerkeKnjiga();
                        break;
                    case Operation.KreirajZaduzenje:
                        response.Result = Controller.Instance.KreirajZaduzenje((List<Zaduzenje>)request.Argument);
                        break;
                    case Operation.VratiSvaZaduzenja:
                        response.Result = Controller.Instance.VratiSvaZaduzenja();
                        break;
                    case Operation.PretraziZaduzenja:
                        response.Result = Controller.Instance.PretraziZaduzenja(request.Argument.ToString());
                        break;
                    case Operation.RazduziKnjigu:
                        response.IsSuccessful = Controller.Instance.RazduziKnjigu((List<Zaduzenje>)request.Argument);
                        break;
                    case Operation.DodajAutora:
                        response.Result = Controller.Instance.DodajAutora((Autor)request.Argument);
                        break;
                    case Operation.DodajIzdavaca:
                        response.Result = Controller.Instance.DodajIzdavaca((Izdavac)request.Argument);
                        break;
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(">>>"+ex.ToString());
            }

            return response;
        }
        internal void Close()
        {
            socket?.Close();
        }
    }
}
