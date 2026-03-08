using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.KnjigaSO
{
    internal class PretraziKnjigeSO : SystemOperationBase
    {
        private readonly string text;

        public PretraziKnjigeSO(string text)
        {
            this.text = text;
        }

        public List<IEntity> Result { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAllFiltered(new Knjiga(), text);
        }
    }
}
