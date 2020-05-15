using Masina;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //clasa AdministrareStudenti_FisierBinar implementeaza interfata IStocareData
    public class AdministrareMasini_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareMasini_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddMasina(masina s)
        {
            throw new Exception("Optiunea AddStudent nu este implementata");
        }

        public masina[] GetMasina(out int nrStudenti)
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }

        public void edititare(masina[] v)
        {
            throw new NotImplementedException();
        }

        public ArrayList GetMasini()
        {
            throw new NotImplementedException();
        }

        public masina GetMasina()
        {
            throw new NotImplementedException();
        }

        public masina GetMasina(string nume, string prenume, string model, string pret)
        {
            throw new NotImplementedException();
        }

        public masina GetMasina(string nume, string prenume, string model)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMasina(masina studentActualizat)
        {
            throw new NotImplementedException();
        }
    }
}
