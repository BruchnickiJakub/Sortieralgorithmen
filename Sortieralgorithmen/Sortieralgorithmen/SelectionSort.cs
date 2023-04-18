using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace Sortieralgorithmen
{
    class SelectionSort : AllSort, ISort
    {
        public void SelectionSortieren()
        {
            Stopwatch watch = new Stopwatch();
            int zwischenwert, small;
            Console.WriteLine("UNSORTED: ");
            Console.WriteLine();
            for (int l = 0; l < Werte.Length; l++)
            {
                Console.Write(Werte[l] + "   ");
            }
            watch.Start();
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
            watch.Stop();
            Console.WriteLine();
            Console.WriteLine("SORTED: ");
            Console.WriteLine();
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
