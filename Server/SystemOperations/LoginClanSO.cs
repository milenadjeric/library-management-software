using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class LoginClanSO : SystemOperationBase
    {
        private readonly Clan argument;
        public IEntity Result { get; set; }

        public LoginClanSO(Clan argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetEntityByID(argument);
        }
    }
}
