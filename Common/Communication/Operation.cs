using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    public enum Operation
    {
        LoginAdmin,
        KreirajNovogClana,
        VratiSveClanove,
        PretraziClanove,
        IzmeniClana,
        ObrisiClana,
        UcitajZanrove,
        UcitajIzdavace,
        UcitajAutore,
        DodajNovuKnjigu,
        VratiSveKnjige,
        PretraziKnjige,
        ObrisiKnjigu,
        VratiSvePrimerkeKnjiga,
        KreirajZaduzenje,
        VratiSvaZaduzenja,
        PretraziZaduzenja,
        RazduziKnjigu,
        LoginClan,
        DodajAutora,
        DodajIzdavaca,
        Logout
    }
}
