using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ZaduzenjeSO
{
    internal class VratiSvaZaduzenjaSO : SystemOperationBase
    {
        public List<IEntity> Result { get; set; }
        public VratiSvaZaduzenjaSO()
        {
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Zaduzenje());
        }
    }
}
