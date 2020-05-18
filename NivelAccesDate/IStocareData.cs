using Masina;
using System.Collections.Generic;
using System.Collections;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddMasina(masina s);
        masina[] GetMasina(out int nrMasini);
        void edititare(masina[] v);
       // ArrayList GetMasini();
        masina GetMasina(string nume,string prenume,string model);
        bool UpdateMasina(masina studentActualizat);
        List<masina> GetMasini();
        masina GetMasinaByIndex(int index);
    }
}
