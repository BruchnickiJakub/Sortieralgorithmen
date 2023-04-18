using System;
using System.Diagnostics;

namespace Sortieralgorithmen
{
    class Program
    {
        
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Mit welchem Sortieralgorithmus wollen Sie sortieren? (1 = BubbleSort, 2 = Insertion Sort, 3 = Selection Sort, 4 = Vergleich, 5 = Exit)");
                int zahlen = Int32.Parse(Console.ReadLine());
                BubbleSort bubble = new BubbleSort();
                InsertionSort insert = new InsertionSort();
                SelectionSort select = new SelectionSort();
                SortVergleich vergleich = new SortVergleich();
                switch (zahlen)
                {
                    case 1:
                        bubble.Bestücke();
                        bubble.BubbleSortieren();
                        break;
                    case 2:
                        insert.Bestücke();
                        insert.InsertionSortieren();
                        break;
                    case 3:
                        select.Bestücke();
                        select.SelectionSortieren();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("FEHLER!");
                        break;
                }
                Console.WriteLine();
            } while (true);
        }
    }
}
