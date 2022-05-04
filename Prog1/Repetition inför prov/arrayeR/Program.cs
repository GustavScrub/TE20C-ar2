using System;

namespace arrayeR
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en string-array med 10 platser
            string[] platser = new string[3];
            // Alternativt:
            // string[] platser = {"", "", ""};
            
            
            // Vi skall fylla den tomm arrayen
            for (int i = 0; i < platser.Length; i++)
            {
                Console.WriteLine("Ange en plats: ");
                string plats = Console.ReadLine();
                platser[i] = plats;
            }

            // Skriv ut arrayens innehåll
            foreach (var plats in platser)
            {
                Console.WriteLine(plats);
            }

            // Skriv ut alla i med stora bokstäver
            foreach (var plats in platser)
            {
                Console.WriteLine(plats.ToUpper());
            }
        }
    }
}
