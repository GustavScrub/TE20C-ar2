using System;

namespace Uppgif_5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello World!");

            // Skapa en array med minst 5 heltal
            int[] tallista = {1, 2, 3, 4, 5, 54};

            // Beräkna summan av alla heltal i arrayen med hjälp av en foreach-loop.
            int summa = 0;
            foreach (var tal in tallista)
            {
                summa += tal;
            }

            Console.WriteLine(summa);
        }
    }
}
