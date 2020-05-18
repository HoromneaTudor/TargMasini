using Masina;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NivelAccesDate
{
    //clasa AdministrareStudenti_FisierBinar implementeaza interfata IStocareData
    public class AdministrareMasini_FisierBinar : IStocareData
    {
        private const int ID_PRIMA_MASINA = 1;
        private const int INCREMENT = 1;
        string NumeFisier { get; set; }
        public AdministrareMasini_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = numeFisiser;
            Stream sBinFile = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sBinFile.Close();
        }

        public void AddMasina(masina m)
        {
            //throw new Exception("Optiunea AddStudent nu este implementata");
            m.IdMasina = GetId();
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                using(Stream sBinFile=File.Open(NumeFisier,FileMode.Append,FileAccess.Write))
                {
                    b.Serialize(sBinFile, m);
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public masina[] GetMasina(out int nrStudenti)
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }

        public void edititare(masina[] v)
        {
            throw new NotImplementedException();
        }

        //public ArrayList GetMasini()
        //{
        //    throw new NotImplementedException();
        //}

        public masina GetMasina()
        {
            throw new NotImplementedException();
        }

        public masina GetMasina(string nume, string prenume, string model, string pret)
        {
            throw new NotImplementedException();
        }

        public masina GetMasina(string nume, string prenume, string modell)
        {
            //masina m = null;
            List<masina> masini = new List<masina>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                // instructiunea 'using' va apela sr.Close()
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    //string line;
                    masina m = null;
                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        m = (masina)b.Deserialize(sBinFile);
                        //masini.Add((masina)b.Deserialize(sBinFile));
                        masini.Add(m);
                        if (m.nume_vanzator.Equals(nume) && m.prenume_vanzator.Equals(prenume) && m.model.Equals(modell))
                        {
                            return m;
                        }
                        //contor++;
                        //ok = true;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }

        public bool UpdateMasina(masina masinaActualizata)
        {
            bool ok = false;
            List<masina> masini = GetMasini();
            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Truncate, FileAccess.Write))
                {
                    foreach (var m in masini)
                    {
                        //serializare unui obiect
                        if (m.IdMasina == masinaActualizata.IdMasina)
                        {
                            b.Serialize(sBinFile, masinaActualizata);
                        }
                        else
                            b.Serialize(sBinFile, m);
                    }
                    ok = true;

                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return ok;
        }
        private int GetId()
        {
            int IdMasina = ID_PRIMA_MASINA;
            try
            {
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        masina m = (masina)b.Deserialize(sBinFile);
                        IdMasina = m.IdMasina + INCREMENT;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return IdMasina;
        }

        public List<masina> GetMasini()
        {
            List<masina> masini = new List<masina>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                using(Stream sBinFile=File.Open(NumeFisier,FileMode.Open))
                {
                    while (sBinFile.Position < sBinFile.Length)
                        masini.Add((masina)b.Deserialize(sBinFile));
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return masini;
        }

        public masina GetMasinaByIndex(int index)
        {
            masina m = null;
            List<masina> masini = new List<masina>();
            try
            {
                int contor = 0;
                BinaryFormatter b = new BinaryFormatter();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        m = (masina)b.Deserialize(sBinFile);
                        //masini.Add((masina)b.Deserialize(sBinFile));
                        masini.Add(m);
                        if (contor == index)
                        {
                            break;
                        }
                        contor++;
                    }

                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return m;
        }
    }
}
