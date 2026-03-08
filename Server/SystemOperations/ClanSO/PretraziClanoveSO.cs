using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ClanSO
{
    internal class PretraziClanoveSO:SystemOperationBase
    {
        private readonly string brClanskeKarte;
        public List<IEntity> Result { get; set; }
        public PretraziClanoveSO(string brClanskeKarte)
        {
            this.brClanskeKarte = brClanskeKarte;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAllFiltered(new Clan(), brClanskeKarte);
        }
    }
}
