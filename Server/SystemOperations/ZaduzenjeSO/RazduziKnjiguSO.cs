using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ZaduzenjeSO
{
    internal class RazduziKnjiguSO : SystemOperationBase
    {
        private List<Zaduzenje> argument;
        public int Result { get; set; }
        public bool IsSucseful { get; set; }
        public RazduziKnjiguSO(List<Zaduzenje> argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            PrimerakKnjige pk;
            IsSucseful = true;

            foreach (Zaduzenje item in argument)
            {
               Result = broker.Update(item);
               if (Result == 0) { IsSucseful = false; }
               pk = item.Knjiga;
               pk.Status = false;
               broker.Update(pk);
            }            
        }
    }
}
