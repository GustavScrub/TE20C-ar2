using System;

namespace Genomgång
{
    class Program
    {
        static void Main(string[] args)
        {
            string inmatat = string.Empty;
            while (inmatat != "hej")
            {
                Console.Writ("Mata in något: ");
                string inmatat = Console.Readline();

                Console.WriteLine("Du skrev: " + inmatat);
            }
            Console.WriteLine("Nu är programmet slut!");
        }
    }
}
