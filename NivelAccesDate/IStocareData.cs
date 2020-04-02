using Masina;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddStudent(masina s);
        masina[] GetStudenti(out int nrStudenti);
    }
}
