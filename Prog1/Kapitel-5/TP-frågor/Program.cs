using System;

namespace TP_frågor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Slumpa fram en fråga");

            //Namnge korten (array)
            string[] korten = {
                "När uppfördes Verdi?",
                "Vem vann fotbolls-Em 1984?",
                "Vem skrev Frankenstein?",
                "Vad är 60+9?",
                "När startade ww2?",
                "Vem är president i USA 2021?"
                };

            //Kasta tärningen
            Random tärning = new Random();
            int slumptal = tärning.Next(0, 6); // 0 till 5

            //Skriver utslaget
            Console.WriteLine($"Tärningen slog {slumptal}");

            //Skriv ut fråga 2
            Console.WriteLine($"Frågan: {korten[slumptal]}");
        }
    }
}
