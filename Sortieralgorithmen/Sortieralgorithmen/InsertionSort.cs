using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace Sortieralgorithmen
{
    class InsertionSort : AllSort, ISort
    {
        public void InsertionSortieren()
        {
            Stopwatch watch = new Stopwatch();
            int zwischenwert;
            Console.WriteLine();
            Console.WriteLine("UNSORTED: ");
            for (int l = 0; l < Werte.Length; l++)
            {
                Console.Write(Werte[l] + "   ");
            }
            watch.Start();
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
