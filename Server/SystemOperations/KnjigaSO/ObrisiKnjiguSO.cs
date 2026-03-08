using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.KnjigaSO
{
    internal class ObrisiKnjiguSO : SystemOperationBase
    {
        private readonly Knjiga argument;
        public int Result { get; set; }
        public bool IsSucseful { get; set; }
        public string Message { get; set; }
        public ObrisiKnjiguSO(Knjiga argument)
        {
            this.argument = argument;  
        }

        protected override void ExecuteConcreteOperation()
        {
            List<PrimerakKnjige> sviPrimerci = broker.GetAll(new PrimerakKnjige()).Cast<PrimerakKnjige>().ToList();
            foreach (PrimerakKnjige item in sviPrimerci)
            {
                if (item.Knjiga.ISBN == argument.ISBN && item.Status==false)
                {
                    Result += 1;                    
                }
            }

            if (Result == argument.BrojPrimeraka)
            {
                Result = broker.Delete(argument);
                if (Result != 0)
                {
                    Message = null;
                }
                else {  Message = "Sistem nije uspeo da obrise knjigu."; }
            }
            else
            {
                Message = "Sistem ne moze da obrise knjigu jer primerci knjige nisu vraceni.";
            }
        }
    }
}
