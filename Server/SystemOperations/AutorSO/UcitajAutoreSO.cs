using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.AutorSO
{
    internal class UcitajAutoreSO : SystemOperationBase
    {
        public List<IEntity> Result { get; set; }
        public UcitajAutoreSO() { }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Autor());
        }
    }
}
