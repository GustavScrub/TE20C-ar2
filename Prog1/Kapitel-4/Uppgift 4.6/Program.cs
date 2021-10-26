using System;

namespace Uppgift_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string meddelande = "Hallå allesammans";

            //skriv ut hela stringen
            Console.WriteLine(meddelande);

            Console.WriteLine(meddelande[0]);

            Console.WriteLine(meddelande[17]);

            //Skriv ut alla tecken baklänges
            for (int i = 17; i >= 0; i--)
            {
                Console.WriteLine($"index {i} {meddelande[i]}");
            }
        }
    }
}
