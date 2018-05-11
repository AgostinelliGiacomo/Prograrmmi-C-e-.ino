using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2018_04_9__Gara_tuffi
{
    class Program
    {
        const int N_TUFFI = 6;
        static Giudici g = new Giudici();
        static Classifica c = new Classifica();

        static void Main()
        {
            Random r = new Random();
            char ch;


            if (c.Carica() == false)
            {
                Console.WriteLine("File concorrenti non trovato");
                Console.ReadKey();
                return;
            }

            //Menù
            do
            {
                Console.Clear();
                Console.WriteLine("[1]:Svolgimento gara");
                Console.WriteLine("[2]:Visualizza classifica");
                Console.WriteLine("[*]:Fine");
                Console.WriteLine("Selezione: ");
                ch = Console.ReadKey().KeyChar;

                switch (ch)
                {
                    case'1':
                        Gara();
                        break;

                    case '2':
                        break;

                    case '*':
                        break;
                }

            }while(true);
        }

        //svolgimento della gara
        static void Gara()
        {
            for (int i = 0; i < N_TUFFI; i++)
            {
                Console.Clear();
                Console.WriteLine("{0} {1}", c.Tab[i].nome, c.Tab[i].naz);
                Console.WriteLine("Punteggi: ");
                for (int k = 0; k < 6; k++)
                {
                    int v;
                    do
                    {
                        v = Convert.ToInt32(Console.ReadLine());
                    } while (v < 0 || v > 10);

                    g.Set(k, v);
                }
                c.Tab[i].punti += g.GetVoto();
            }
        }
    }
}
