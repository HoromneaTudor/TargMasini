using System;
using NivelAccesDate;
using Masina;

namespace targ_masini
{
    class Program
    {
        static void Main(string[] args)
        {
            masina[] masini;


            string optiune;
            do
            {
                Console.WriteLine("1.Creare masina predefinita");
                Console.WriteLine("2.Creare masina (constructor null)");
                Console.WriteLine("3.Creare masina (constructor predefinit cu delimitator)");
                Console.WriteLine("4.adaugare 2 masini de la tastatura ,afisarea primei masini introduse si compararea anilor lor ");
                Console.WriteLine("5.Afisare masini existente");
                Console.WriteLine("6.Modificare masina existenta");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                Console.Clear();
                switch(optiune)
                {
                    case "1":
                        var f = new masina("alin", "petru", "opel", "astra");
                        Console.WriteLine(f.afisare());
                        break;
                    case "2":
                        var f1 = new masina();
                        Console.WriteLine(f1.afisare());
                        break;
                    case "3":
                        var f2 = new masina("tudor,narcis,citroen,c5");
                        Console.WriteLine(f2.afisare());
                        break;
                    case "4":
                        masina f3 = CitireMasinaTastatura();
                        masina f4 = CitireMasinaTastatura();


                        Console.WriteLine(f3.ConversieLaSir());
                        int rez = f3.Comparean(f4);
                        if (rez == masina.Mai_Mare)
                            Console.WriteLine("masina {0}, modelul {1} este mai noua decat masina {2} modelul, {3}", f3.firma, f3.model, f4.firma, f4.model);
                        else if (rez == masina.Egal)
                        {
                            Console.WriteLine("masina {0}, modelul {1} este din acelasi an cu masina {2} modelul {3}", f3.firma, f3.model, f4.firma, f4.model);
                        }
                        else Console.WriteLine("masina {0}, modelul {1} este mai veche decat masina {2} modelul {3}", f3.firma, f3.model, f4.firma, f4.model);
                        break;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;




                }

            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
            
            
            //string p = Console.ReadLine();
            

           
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

            Console.WriteLine("Dati culoarea vehicului:\n1- Rosu\n2- Albastru\n3- Gri\n4- Alb\n5- Portocaliu/n");
            m.Culoare = (masina.CuloareMasina)Int32.Parse(Console.ReadLine());
          

            Console.WriteLine(
           "\nAll possible combinations of values with FlagsAttribute:");
            for (int val = 0; val < 16; ++val)
                Console.WriteLine("{0,3} - {1}", val, (masina.Optiuni)val);
            m.OptiuniMasina = (masina.Optiuni)Int32.Parse(Console.ReadLine());

            Console.Clear();
            return m;
        }

        public static void AfisareMasini(masina[] masini,int nrmasini)
        {
            Console.WriteLine("Masinile sunt:");
            for(int i=0;i<nrmasini;++i)
                { 
                Console.WriteLine(masini[i].ConversieLaSir());
                }

        }
    }
}
