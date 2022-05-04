using System;

namespace LF0205
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Clear();
            string[] namnen = new string[3];    // positioner 0, 1, 2

            namnen[0] = "Dimentio";
            namnen[1] = "Scrubsy";
            namnen[2] = "Martin";

            // Skriv ut arrayens innehåll
            foreach (var namn in namnen)
            {
                Console.WriteLine(namn);
            }

            string[] möbler = new string[5];

            for (int i = 0; i < möbler.Length; i++)
            {
                Console.WriteLine("Ange en möbel: ");
                string möbel = Console.ReadLine();
                möbler[i] = möbel;
            }

            foreach (var möbel in möbler)
            {
                Console.WriteLine(möbel);
            }

            Console.WriteLine(möbler[0]);
            Console.WriteLine(möbler[1]);
            Console.WriteLine(möbler[2]);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(möbler[i]);
            }

                Console.WriteLine("Mata in 4 och 5: ");
            for (int i = 3; i < 5; i++)
            {
                möbler[i] = Console.ReadLine();
            } */

            string[] namnen = {"Muzan", "Mahito", "Mello", "", ""};
            Console.WriteLine("Skriv in de två sista namnen: ");

            for (int i = 3; i < 5; i++)
            {
                namnen[i] = Console.ReadLine();
            }

            foreach (var namn in namnen)
            {
                Console.WriteLine(namn);
            }

            Console.Write("Ange en bokstav: ");
            string bokstav = Console.ReadLine();
            
            foreach (var namn in namnen)
            {
                if (namn.Contains(bokstav))
                {
                    Console.WriteLine(namn);
                }
            }
        }
    }
}
