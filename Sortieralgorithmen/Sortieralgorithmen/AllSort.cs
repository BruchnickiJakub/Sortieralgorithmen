using System;
using System.Collections.Generic;
using System.Text;

namespace Sortieralgorithmen
{
    class AllSort
    {
        protected int[] Werte;
        Random rnd = new Random();
        public void Bestücke()
        {
            int anzahl = rnd.Next(1, 50);
            Werte = new int[anzahl];

            for (int i = 0; i < Werte.Length; i++)
            {
                int random_wert = rnd.Next(1, 1000);
                Werte[i] = random_wert;
            }
        }
    }
}
