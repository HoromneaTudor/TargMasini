using Masina;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddMasina(masina s);
        masina[] GetStudenti(out int nrMasini);
    }
}
