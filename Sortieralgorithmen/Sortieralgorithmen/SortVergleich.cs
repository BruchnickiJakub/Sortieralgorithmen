using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Sortieralgorithmen
{
    class SortVergleich : AllSort, ISort
    {
        int zwischenwert, small;
        public void Vergleich()
        {
            //Bubblesort
            Stopwatch watch1 = new Stopwatch();
            watch1.Start();
            for (int j = 0; j <= Werte.Length - 2; j++)
            {
                for (int i = 0; i <= Werte.Length - 2; i++)
                {
                    if (Werte[i] > Werte[i + 1])
                    {
                        zwischenwert = Werte[i + 1];
                        Werte[i + 1] = Werte[i];
                        Werte[i] = zwischenwert;
                    }
                }
            }
            watch1.Stop();
            Console.WriteLine("SORTED: ");
            Console.WriteLine();
            for (int k = 0; k < Werte.Length; k++)
            {
                Console.Write(Werte[k] + "   ");
            }
            Console.WriteLine("Bubblesort Zeit:    " + watch1.Elapsed);
            //Insertionsort
            Stopwatch watch2 = new Stopwatch();
            watch2.Start();
            for (int i = 0; i < Werte.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (Werte[j - 1] > Werte[j])
                    {
                        zwischenwert = Werte[j - 1];
                        Werte[j - 1] = Werte[j];
                        Werte[j] = zwischenwert;
                    }
                }
            }
            watch2.Stop();
            Console.WriteLine("Insertionsort Zeit: " + watch2.Elapsed);
            //Selectionsort
            Stopwatch watch3 = new Stopwatch();
            watch3.Start();
            for (int i = 0; i < Werte.Length - 1; i++)
            {
                small = i;
                for (int j = i + 1; j < Werte.Length; j++)
                {
                    if (Werte[j] < Werte[small])
                    {
                        small = j;
                    }
                }
                zwischenwert = Werte[small];
                Werte[small] = Werte[i];
                Werte[i] = zwischenwert;
            }
            watch3.Stop();
            Console.WriteLine("Selectionsort Zeit: " + watch3.Elapsed);
        }
    }
}
