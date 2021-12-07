using System;

namespace Uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Uppgift 5.1");
            
            // Skapa en array för 3 öar
            string[] städer = new string[3];
 
            // Första platsen (0)
            städer[0] = "Stockholm";
            städer[1] = "Malmö";
            // Låt användaren skriva den tredje staden
            Console.WriteLine($"Skriv in en till svensk stad förutom {städer[0]} och {städer[1]}");
            städer[2] = Console.ReadLine();

            // Skriv avslutningsvis ut alla stadsnamnen på samma rad
            Console.WriteLine("Här är 3 svenska städer:");
            Console.WriteLine($"{städer[0]}, {städer[1]} och {städer[2]}");

            // Ett annat sätt att skapa en array
            string[] länder = {"Sverige", "Finland", "Dannmark", "Norge"};
            länder[0] = "Tyskland";

            // Skriv ut alla länder
            // Loopa igenom arrayen länder
            foreach (var land in länder)
            {
                Console.WriteLine(land);
            }
        }
    }
}
