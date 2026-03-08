using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ClanSO
{
    internal class ObrisiClanaSO:SystemOperationBase
    {
        private Clan argument;
        public int Result { get; set; }
        public string Message { get; set; }
        public ObrisiClanaSO(Clan argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            Message = null;
            List<Zaduzenje> zaduzenja = broker.GetAllFiltered(new Zaduzenje(),argument.BrojClanskeKarte.ToString()).Cast<Zaduzenje>().ToList();
            foreach (Zaduzenje item in zaduzenja)
            {
                if (item.Vraceno == false)
                {
                    Message = "Sistem ne moze da obrise clana jer ima aktivna zaduzenja.";
                }       
            }

            if (Message == null)
            {
                Result = broker.Delete(argument);
                if (Result != 0) { Message = null; }
                else { Message = "Sistem nije uspeo da obrise clana."; }
            }
           
        }
    }
}
