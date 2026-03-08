using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class UcitajZanroveSO : SystemOperationBase
    {
        public List<IEntity> Result { get; set; }
        public UcitajZanroveSO()
        {
               
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Zanr());
        }
    }
}
