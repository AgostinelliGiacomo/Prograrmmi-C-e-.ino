using System;
using System.IO;
using System.Text;

namespace _2018_04_9__Gara_tuffi
{
    public class Classifica
    {
        public const int DIM = 100;
        public const string nome_f = "CONCORRENTI.txt";

        //attributi
        public Concorrente[] Tab;
        public int nc;

        //costruttore
        public Classifica()
        {
            Tab = new Concorrente[DIM];
            nc = 0;
        }

        //Carica
        public bool Carica()
        {
            if (File.Exists(nome_f) == false)
                return false;

            StreamReader sr = new StreamReader(nome_f);
            string riga;
            Concorrente x;
            while ((riga = sr.ReadLine()) != null)
            {
                string[] comp = riga.Split('\t');
                x.nome = comp[0];
                x.naz = comp[1];
                x.punti = 0;
                Aggiungi(x);
            }

            sr.Close();
            return true;
        }

        //Aggiungi
        public bool Aggiungi(Concorrente x)
        {
            if (nc >= DIM)
                return false;
            Tab[nc] = x;
            nc++;
            return true;
        }
    }
}
