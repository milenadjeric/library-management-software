using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ZaduzenjeSO
{
    internal class PretraziZaduzenjaSO : SystemOperationBase
    {
        private readonly string text;

        public PretraziZaduzenjaSO(string text)
        {
            this.text = text;
        }
        public List<IEntity> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAllFiltered(new Zaduzenje(), text);
        }
    }
}
