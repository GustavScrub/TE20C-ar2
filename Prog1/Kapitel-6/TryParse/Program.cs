using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Gissa ett tal");

            //Slumpgenerator
            Random generator = new Random();

            //Slumpa fram ett tal mellan
            int slumptal = generator.Next(1, 101); //1-100
            int slumptal2 = generator.Next(1, 11); //1-10

            //Be spelaren att gissa ett tal
            Console.WriteLine("Gissa ett tal (1-100): ");
            //int gissning = int.Parse(Console.ReadLine());

            //Försök överästta det inmatade till ett tal
            int.TryParse(gissning, out gissningInt) ;

            //Var gissnignen korrekt
            if (gissning == slumptal)
            {
                Console.WriteLine("Du gissade rätt!");
            }
            else
            {
                Console.WriteLine("Du gissade fel...");
            }
        }
    }
}
