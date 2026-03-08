using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.KnjigaSO
{
    internal class VratiSveKnjigeSO : SystemOperationBase
    {
        public VratiSveKnjigeSO()
        {
        }

        public List<IEntity> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Knjiga());
        }
    }
}
