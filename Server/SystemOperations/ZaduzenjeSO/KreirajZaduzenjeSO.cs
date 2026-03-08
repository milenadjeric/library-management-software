using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.ZaduzenjeSO
{
    internal class KreirajZaduzenjeSO:SystemOperationBase
    {
        private readonly List<Zaduzenje> zaduzenja;

        public List<int> Result { get; set; }
        public KreirajZaduzenjeSO(List<Zaduzenje> argument)
        {
            zaduzenja = argument;
            Result = new List<int>();
        }

        protected override void ExecuteConcreteOperation()
        {
            //List<IEntity> entities = zaduzenja.Cast<IEntity>().ToList();
            //Result = (List<int>)broker.AddList(entities);
            PrimerakKnjige pk;
            int result;

            foreach (Zaduzenje item in zaduzenja)
            {
                result = (int)broker.Add(item);
                Result.Add(result);
                pk = item.Knjiga;
                pk.Status = true;
                broker.Update(pk);                
            }

        }
    }
}
