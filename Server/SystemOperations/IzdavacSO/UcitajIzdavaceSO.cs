using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.IzdavacSO
{
    public class UcitajIzdavaceSO : SystemOperationBase
    {
        public List<IEntity> Result { get; set; }
        public UcitajIzdavaceSO()
        {
            
        }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Izdavac());
        }
    }
}
