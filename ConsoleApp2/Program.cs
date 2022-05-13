using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba = 4, liczba_pomocnicza = 1;

            for (int wiersz = 1; wiersz <= liczba; wiersz++)
            {
                for (int kolumna = 1; kolumna <= wiersz; kolumna++)
                {
                    Console.Write(" " + liczba_pomocnicza);
                    liczba_pomocnicza++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
