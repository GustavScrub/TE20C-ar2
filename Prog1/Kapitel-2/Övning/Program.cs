using System;

namespace Övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Vad heter du?");
            string Namn = Console.ReadLine();
            Console.WriteLine("Hej på dig! " + Namn);

            Console.Write("Var bor du? ");
            string ort = Console.ReadLine();
            Console.WriteLine("Vad trevligt att du bor i " + ort);

            Console.Write("Hur gammal är du? ");
            string ålder = Console.ReadLine();
            Console.WriteLine($"Du är {ålder} år");
        }
    }
}
