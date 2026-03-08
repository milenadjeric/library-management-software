using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ClanSO
{
    internal class IzmeniClanaSO : SystemOperationBase
    {
        private Clan argument;
        public int Result { get; set; }
        public bool IsSucseful { get; set; }
        public IzmeniClanaSO(Clan argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.Update(argument); 
            if (Result != 0) { IsSucseful = true; }
            else { IsSucseful = false; }
        }
    }
}
