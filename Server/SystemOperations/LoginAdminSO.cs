using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class LoginAdminSO : SystemOperationBase
    {
        private readonly Bibliotekar user;
        public IEntity Result { get ; set ; }

        //public Bibliotekar Result { get; set; }

        public LoginAdminSO(Bibliotekar user)
        {
            this.user = user;
        }
        protected override void ExecuteConcreteOperation()
        {
           Result = broker.GetEntityByID(user); 
        }
    }
}
