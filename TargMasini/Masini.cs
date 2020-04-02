using System;
using System.Collections.Generic;
using System.Text;

namespace NivelAccesDate
{
    public class masina
    {
        //string marca;
        //int numar_pistoane;
        //int capacitate_cilindrica;
        //int nr_locuri;
        string nume_vanzator;
        string nume_cumparator;
        //int pret;
        //int an;

        private int n;

        public const int Mai_Mare = 1;
        public const int Mai_Mic = 1;
        public const int Egal = 0;

        public enum CuloareMasina
        {
            Rosu = 1,
            Albastru = 2,
            Gri = 3,
            Alb = 4,
            Portocaliu = 5,
        };

        [Flags]
        public enum Optiuni : short
        {
            None = 0,
            AerConditionat = 1,
            ScauneDePiele = 2,
            ABS = 4,
            LuminiDeCeata = 8,
        };

        public Optiuni OptiuniMasina { get; set; }
        public CuloareMasina Culoare { get; set; }
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
            string[] buff = nume1.Split(',');
            nume_cumparator = buff[0];
            nume_vanzator = buff[1];
            firma = buff[2];
            model = buff[3];

        }
        public string afisare()
        {
            //Console.WriteLine("Producator masina :{0}, model: {1}, nume cumparator: {2}, nume vanzator: {3}", firma, model, nume_cumparator, nume_vanzator);
            string s = string.Format("Producator masina :{0}, model: {1}, nume cumparator: {2}, nume vanzator: {3}", firma, model, nume_cumparator, nume_vanzator);
            return s;
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
                sAnPret = string.Format("anul {0} si are pretul de {1} Euro ,culoarea {2} , cu optiunile {3}", an, pret,Culoare.ToString(),OptiuniMasina);
            }
            string s = string.Format("masina {0}, modelul {1} este din {2}  ", firma, model, sAnPret);

            return s;
        }
    }
}
