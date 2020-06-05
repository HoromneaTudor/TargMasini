//Horomnea Tudor Grupa 3122A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masina
{
    public enum CodEroare
    {
        CORECT=0,
        NUME_INCORECT=1,
        PRENUME_INCORECT=2,
        MARCA_INCORECT=3,
        MODEL_INCORECT=4,
        AN_INCORECT=5,
        PRET_INCORECT=6

    }
    public enum CuloareMasina
    {
        Rosu = 1,
        Albastru = 2,
        Gri = 3,
        Alb = 4,
        Portocaliu = 5,
        Inexistenta = 6,
    };
    //[Flags]
    //public enum Optiuni : short
    //{
    //    None = 0,
    //    AerConditionat = 1,
    //    ScauneDePiele = 2,
    //    ABS = 4,
    //    LuminiDeCeata = 8,
    //};
    //public enum Tip
    //{
    //    Motocicleta=0,
    //    Masina=1,
    //    Camion=2,
    //};
}
