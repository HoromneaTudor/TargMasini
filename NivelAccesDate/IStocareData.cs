using Masina;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddMasina(masina s);
        masina[] GetMasina(out int nrMasini);
    }
}
