using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.KnjigaSO
{
    internal class DodajNovuKnjiguSO : SystemOperationBase
    {
        private readonly Knjiga knjiga;
        public string Result { get; set; }
        public DodajNovuKnjiguSO(Knjiga argument)
        {
            knjiga = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.Add(knjiga).ToString();

            if (Result!=null)
            {
                for (int i = 1; i <= knjiga.BrojPrimeraka; i++)
                {
                    PrimerakKnjige pk = new PrimerakKnjige() 
                    { 
                        Status = false,
                        Knjiga=knjiga
                    };
                    broker.Add(pk);
                } 
            }
        }
    }
}
