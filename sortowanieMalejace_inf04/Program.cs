using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanieMalejace_inf04
{
    internal class Program
    {
        /*
         klasa: Program
         opis: aplikacja wypelniajaca tablice losowymi liczbami calkowitymi z zakresu 0-100
         pola: tab - tablica liczb calkowitych
               rnd - generator liczb losowych
         autor: Jakub Samonek
         */
        static void Main(string[] args)
        {
            int n = 50;
            if(args.Length > 0 && int.TryParse(args[0],out int parsed) &&  parsed > 0)
            {
                n = parsed;
            }
            int[] tab = new int[n];
            Random rand = new Random();

            for(int i = 0; i < n; i++)
            {
                tab[i] = rand.Next(0, 101);
            }

            Console.WriteLine($"Tablica ({n} elementow): ");
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{i}: {tab[i]}");
            }
        }
    }
}
