using System;

namespace targ_masini
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new masina("alin", "petru", "opel", "astra");
            f.afisare();
            var f1 = new masina();
            f1.afisare();
            Console.ReadKey();
            var f2 = new masina("tudor,narcis,citroen,c5");
            f2.afisare();
            Console.ReadKey();
            f2.SetAnPret(2000, 5000);
            f.SetAnPret(1999, 4500);
            Console.WriteLine(f2.ConversieLaSir());
            int rez = f.Comparean(f2);
            if (rez == masina.Mai_Mare)
                Console.WriteLine("masina {0}, modelul {1} este mai noua decat masina {2} modelul, {3}", f2.firma, f2.model, f.firma, f.model);
            else if (rez == masina.Egal)
            {
                Console.WriteLine("masina {0}, modelul {1} este din acelasi an cu masina {2} modelul {3}", f2.firma, f2.model, f.firma, f.model);
            }
            else Console.WriteLine("masina {0}, modelul {1} este mai veche decat masina {2} modelul {3}", f2.firma, f2.model, f.firma, f.model);

        }
    }
}
