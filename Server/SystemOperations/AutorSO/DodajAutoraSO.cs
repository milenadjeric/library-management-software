using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.AutorSO
{
    internal class DodajAutoraSO : SystemOperationBase
    {
        private readonly Autor argument;
        public int Result { get; set; }
        public DodajAutoraSO(Autor argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = (int)broker.Add(argument);
        }
    }
}
