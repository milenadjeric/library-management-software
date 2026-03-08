using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ClanSO
{
    internal class VratiSveClanoveSO : SystemOperationBase
    {
        public List<IEntity> Result { get; set; }
        public VratiSveClanoveSO()
        {
            
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Clan());
        }
    }
}
