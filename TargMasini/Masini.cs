using System;
using System.Collections.Generic;
using System.Text;

namespace targ_masini
{
    class masina
    {
        string marca;
        int an;
        int numar_pistoane;
        int capacitate_cilindrica;
        int nr_locuri;
        string nume_vanzator;
        string nume_cumparator;
        string firma;
        string model;

        public masina()
        {
            nume_cumparator = string.Empty;
            nume_vanzator = string.Empty;
            model = string.Empty;
            firma = string.Empty;
        }
        public masina(string numev, string numec, string firmaa, string modell)
        {
            nume_cumparator = numec;
            nume_vanzator = numev;
            firma = firmaa;
            model = modell;

        }

        public masina(string nume1)
        {
            string[] buff = nume1.Split(",");
            nume_cumparator = buff[0];
            nume_vanzator = buff[1];
            firma = buff[2];
            model = buff[3];

        }
        public void afisare()
        {
            Console.WriteLine("Producator masina :{0}, model: {1}, nume cumparator: {2}, nume vanzator: {3}", firma, model, nume_cumparator, nume_vanzator);
        }

    }
}
