using System;

namespace BoolskaOperationer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coronasymptom");

            Console.WriteLine("Har du feber? (j/n) ");
            string feber = Console.ReadLine();

            Console.WriteLine("Hostar du? (j/n) ");
            string hosta = Console.ReadLine();
            
            Console.WriteLine("Har du tappat smaken? (j/n) ");
            string smak = Console.ReadLine();

            Console.WriteLine("Är du vaccinerad mot Covid? (j/n) ");
            string vaccin = Console.ReadLine();

            /* if (feber == "ja" && hosta == "ja" && smak == "ja")
            {
                Console.WriteLine("DU har troligen Covid-19");
            }

            if (feber == "ja" && smak == "ja")
            {
                Console.WriteLine("DU har troligen Covid-19");
            }
 */
            if (feber == "j" || hosta == "j" && smak == "j")
            {
             Console.WriteLine("DU har troligen Covid-19");

            }
        }
    }
}