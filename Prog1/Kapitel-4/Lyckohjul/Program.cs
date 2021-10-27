using System;

namespace Lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lyckohjul!");

            //Skapa ett program som ska fungera som ett lyckohjul
            Random hjul = new Random();
            int spin = hjul.Next(1, 11);

            //Användaren får 3 försök!
            for (int i = 0; i < 3; i++)
            {
                //När användaren kör programmet får hen välja ett tal från 1 till 10 som hen tror att lyckohjulet kommer att stanna på
                Console.WriteLine("Gissa ett nummer mellan 1 och 10");
                int gissning = int.Parse(Console.ReadLine());

                //Slumpa därefter fram ett tal från 1 till 10 och säg till användaren vilket tal det blev
                Console.WriteLine($"Det blev {spin}");

                //Berätta också för användaren om hen vann eller förlorade
                if (gissning == spin)
                {
                    Console.WriteLine("Du vann!");
                    break;
                }
                else
                {
                    Console.WriteLine("Du förlorade!");
                }


            }

        }
    }
}
