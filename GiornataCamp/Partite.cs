using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GiornataCamp
{
    public struct Squadra
    {
        public string nome;
        public int goal;
    }

    public class Partite
    {

        public Squadra[,] tab;
        public int ne;

        public Partite()
        {
            tab = new Squadra[10, 2];
            ne = 0;
        }

        public bool Carica( string nomefile )
        {
            StreamReader sr = new StreamReader(nomefile);
            string riga;
            
            while ((riga = sr.ReadLine()) != null)
            {
                string [] pezzi = riga.Split(' ');
                tab[ne, 0].nome = pezzi[0];
                tab[ne, 0].goal = Convert.ToInt32( pezzi[2] );
                tab[ne, 1].nome = pezzi[1];
                tab[ne, 1].goal = Convert.ToInt32( pezzi[3] );
                ne++;
            }
            return true;
        }

    }
}
