using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class KreirajClanaSO:SystemOperationBase
    {
        private readonly Clan clan;       
        public int Result { get; set; }
        public KreirajClanaSO(Clan clan)
        {
            this.clan = clan;   
        }
        protected override void ExecuteConcreteOperation()
        {
            Result=(int)broker.Add(clan);
        }
    }
}
