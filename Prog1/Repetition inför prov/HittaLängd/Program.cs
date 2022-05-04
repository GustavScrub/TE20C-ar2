using System;

namespace HittaLängd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användaren mata in 3 kompisar 
            
            string[] kompisar = new string[3];

            for (int i = 0; i < kompisar.Length; i++)
            {
                Console.WriteLine("Skriv ut 3 kompisar: ");
                string kompis = Console.ReadLine();
                kompisar[i] = kompis;
            }

            // Efter inmatning
            // Skriv ut längden på varje kompis namn
            foreach (var kompis in kompisar)
            {
                Console.WriteLine($"{kompis} har {kompis.Length} långt namn");
            }

            // Avsluta med 
            // Skriv också ut vem som har längst namn
            Console.WriteLine($"{kompis} har längst namn");
        }
    }
}
