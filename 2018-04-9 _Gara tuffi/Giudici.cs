using System;

namespace _2018_04_9__Gara_tuffi
{
    class Giudici
    {
        int[] voto = new int [6];

        public int GetVoto()
        {
            int somma = 0;
            voto[p_min] = 0;
            voto[p_max] = 0;
            for (int i = 0; i < 6; i++)
            {
                somma += voto[i];
            }
            return somma;
        }

        public void Set(int i, int x)
        {
            voto[i] = x;
        }

        //Ricerca valore minimo
        int p_min
        {
            get
            {
                int min = 0;
                for (int i = 0; i < 6; i++)
                    if (voto[i] < voto[min])
                        min = i;
                return min;
            }
        }

        //Ricerca valore massimo
        int p_max
        {
            get
            {
                int max = 0;
                for (int i = 0; i < 6; i++)
                    if (voto[i] > voto[max])
                        max = i;
                return max;
            }
        }
    }
}
