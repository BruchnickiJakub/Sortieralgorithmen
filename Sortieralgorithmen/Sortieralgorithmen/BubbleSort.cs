using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace Sortieralgorithmen
{
    class BubbleSort : AllSort, ISort
    {
        public void BubbleSortieren()
        {
            int zwischenwert;
            Console.WriteLine("UNSORTED: ");
            for (int l = 0; l < Werte.Length; l++)
            {
                Console.Write(Werte[l] + "   ");
            }
            Stopwatch watch = new Stopwatch();
            watch.Start();
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
            watch.Stop();
            Console.WriteLine();
            Console.WriteLine("SORTED: ");
            for (int k = 0; k < Werte.Length; k++)
            {
                Console.Write(Werte[k] + "   ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zeit: " + watch.Elapsed);
        }

    }
}
