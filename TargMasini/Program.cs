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
        }
    }
}
