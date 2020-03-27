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
            Console.WriteLine( f1.afisare());
            Console.ReadKey();
            //string p = Console.ReadLine();
            var f2 = new masina("tudor,narcis,citroen,c5");
            Console.WriteLine(f2.afisare());
            Console.ReadKey();

            masina f3 = CitireMasinaTastatura();
            masina f4 = CitireMasinaTastatura();


            Console.WriteLine(f2.ConversieLaSir());
            int rez = f3.Comparean(f4);
            if (rez == masina.Mai_Mare)
                Console.WriteLine("masina {0}, modelul {1} este mai noua decat masina {2} modelul, {3}", f3.firma, f3.model, f4.firma, f4.model);
            else if (rez == masina.Egal)
            {
                Console.WriteLine("masina {0}, modelul {1} este din acelasi an cu masina {2} modelul {3}", f3.firma, f3.model, f4.firma, f4.model);
            }
            else Console.WriteLine("masina {0}, modelul {1} este mai veche decat masina {2} modelul {3}", f3.firma, f3.model, f4.firma, f4.model);

        }
        public static masina CitireMasinaTastatura()
        {
            Console.WriteLine("introduceti marca masinii: ");
            string marca = Console.ReadLine();
            Console.WriteLine("introduceti modelul masinii: ");
            string modelul = Console.ReadLine();
            Console.WriteLine("introduceti nume cumparator: ");
            string numecump = Console.ReadLine();
            Console.WriteLine("introduceti nume vanzator: ");
            string numevanz = Console.ReadLine();
            masina m = new masina(numevanz, numecump, marca, modelul);
            Console.WriteLine("introduceti anul si pretul masinii: ");
            string anbuf = Console.ReadLine();
            string pretbuf = Console.ReadLine();
            int an = Convert.ToInt32(anbuf);
            int pret = Convert.ToInt32(pretbuf);
            m.SetAnPret(an, pret);
            return m;
        }
    }
}
