using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Masina
{
    public class masina
    {
        //string marca;
        //int numar_pistoane;
        //int capacitate_cilindrica;
        //int nr_locuri;
        public string nume_vanzator { get; set; }
        //public string 
        public string prenume_vanzator { get; set; }
        //int pret;
        //int an;

        private const bool SUCCES = true;
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        //private int n;

        public const int Mai_Mare = 1;
        public const int Mai_Mic = 1;
        public const int Egal = 0;
        private const int ID = 0;
        private const int FIRMA = 1;
        private const int MODEL = 2;
        private const int NUMEVANZ = 3;
        private const int PRENUMEVANZ = 4;
        private const int AN = 5;
        private const int PRET = 6;
        private const int CULOARE = 7;
        private const int OPTIUNI = 8;

        public Optiuni OptiuniMasina { get; set; }
        public CuloareMasina Culoare { get; set; }

        public static int IdUltimaMasina { get; set; } = 0;

        public int IdMasina { get; set; }
        public int pret { get; set; }
        public int an { get; set; }
        public string firma { get; set; }
        public string model { get; set; }

        public int Vechime
        {
            get
            {
                return 2020 - an;
                
            }
        }
        public masina()
        {
            nume_vanzator = string.Empty;
            prenume_vanzator = string.Empty;
            model = string.Empty;
            firma = string.Empty;
            an = 0;
            pret = 0;
            Culoare = 0;
            OptiuniMasina = 0;
        }
        public masina(string numev, string prenumev, string firmaa, string modell)
        {
            nume_vanzator = numev;
            prenume_vanzator = prenumev;
            firma = firmaa;
            model = modell;
            IdUltimaMasina++;
            IdMasina = IdUltimaMasina;
            Culoare = 0;
            OptiuniMasina = 0;

        }

        //public masina(string nume1)
        //{
        //    string[] buff = nume1.Split(',');
        //    nume_cumparator = buff[0];
        //    nume_vanzator = buff[1];
        //    firma = buff[2];
        //    model = buff[3];

        //}

        public masina(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ToString()
            IdMasina = Convert.ToInt32(dateFisier[ID]);
            firma = dateFisier[FIRMA];
            model = dateFisier[MODEL];
            nume_vanzator = dateFisier[NUMEVANZ];
            prenume_vanzator = dateFisier[PRENUMEVANZ];
            string anbuf = dateFisier[AN];
            an = Int32.Parse(anbuf);
            string pretbuf = dateFisier[PRET];
            pret = Int32.Parse(pretbuf);
            Culoare = (CuloareMasina)Enum.Parse(typeof(CuloareMasina), dateFisier[CULOARE]);
            OptiuniMasina = (Optiuni)Enum.Parse(typeof(Optiuni), dateFisier[OPTIUNI]);
            IdUltimaMasina = IdMasina;
           
        }
        public string afisare()
        {
            //Console.WriteLine("Producator masina :{0}, model: {1}, nume cumparator: {2}, nume vanzator: {3}", firma, model, nume_cumparator, nume_vanzator);
            string s = string.Format(" Producator masina :{0}, model: {1}, nume vanzator: {2} {3}, cu pretul:{4} si din anul:{5}", firma, model, nume_vanzator, prenume_vanzator,pret,an);
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

        public void SetAnPret(int ann, int prett)
        {
            an = ann;
            pret = prett;
        }
        public string ConversieLaSir()
        {
            string sAnPret = "Nu exista(Nu ati apelat metoda SetAnPret";
            if (an != 0 && pret != 0)
            {
                sAnPret = string.Format("anul {0} si are pretul de {1} Euro ,culoarea {2} , cu optiunile {3}", an, pret, Culoare.ToString(), OptiuniMasina);
            }
            string s = string.Format("ID-ul Masina: {3}\nMarca: {0} \nmodelul {1} \nEste din {2}  \nNume vanzator: {4} {5}\n", firma, model, sAnPret,IdMasina,nume_vanzator,prenume_vanzator);

            return s;
        }
        public string ConversieLaSir_PentruFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}",
                SEPARATOR_PRINCIPAL_FISIER, IdMasina.ToString(), (firma ?? " NECUNOSCUT "), (model ?? " NECUNOSCUT "), (nume_vanzator  ?? " NECUNOSCUT "), (prenume_vanzator ?? " NECUNOSCUT ") ,an, pret,Culoare,OptiuniMasina);

            return s;
        }
        //public void UpdateMasina(masina[] u, int nr)
        //{
        //    var encoding = Encoding.UTF8;
        //    using (var stream = new FileStream("Masini.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
        //    {

        //        stream.Position = 0;
        //        using (var writer = new StreamWriter(stream, encoding))
        //        {
        //            for (int z = 0; z <= nr; z++)
        //                writer.Write(u[z].ConversieLaSir_PentruFisier());
        //        }

        //    }
        //}
        //~masina()
        //{
        //    using (StreamWriter streamWriter = new StreamWriter("Masini.txt"))
        //    {
        //        foreach (var entry in masina)
        //        {
        //            streamWriter.WriteLine(entry.Value.ToString());
        //        }
        //    }
        //}
        

    }
}
