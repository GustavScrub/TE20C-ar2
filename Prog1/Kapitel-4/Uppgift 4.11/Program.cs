using System;

namespace Uppgift_4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket är världens mest sålda spel?");
            string svar = Console.ReadLine();
            int Försök = 1;

            while (svar != "minecraft")
            {
                if (Försök >=5)
                {
                    Console.WriteLine("Stopp! Du har gissat för mycket");
                    break;
                }
                 Console.WriteLine($"Nope! Inte {svar}");
                 svar = Console.ReadLine();
                 Försök++;
            }
            if (svar == "minecraft")
            {
                Console.WriteLine("Ja! Där är svaret!");
            }
        }
    }
}
