using System;
using System.Collections.Generic;
using System.Text;

namespace targ_masini
{
    class masina
    {
        string marca;
        int numar_pistoane;
        int capacitate_cilindrica;
        int nr_locuri;
        string nume_vanzator;
        string nume_cumparator;
        //int pret;
        //int an;

        public const int Mai_Mare= 1;
        public const int Mai_Mic= 1;
        public const int Egal = 0;

        public int pret { get; set; }
        public int an { get; set; }
        public string firma { get; set; }
        public string model { get; set; }

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

        public int Comparean(masina s)
        {
            if (this.an > s.an)
                return Mai_Mare;
            else if (this.an == s.an)
                return Egal;
            return Mai_Mic;

        }

        public void SetAnPret(int ann,int prett)
        {
            an = ann;
            pret = prett;
        }
        public string ConversieLaSir()
        {
            string sAnPret = "Nu exista(Nu ati apelat metoda SetAnPret";
            if(an!=null&&pret!=null)
            {
                sAnPret = string.Format("nul {0} si are pretul de {1} Euro", an, pret);
            }
            string s = string.Format("masina {0}, modelul{1} este din {2}  ", marca, firma, sAnPret);

            return s;
        }
    }
}
