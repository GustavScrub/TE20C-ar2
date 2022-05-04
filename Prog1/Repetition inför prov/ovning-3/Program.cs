using System;

namespace ovning_3
{
    class Program
    {
        static void Main(string[] args)
        {
           // Använda metod 1 
           Print32();

           // Använd metod 2
           PrintText32("Hej världen!");

           // Använd metod 3
           Console.WriteLine("Mata in ett tal 5-10: ");
           string stringTal = Console.ReadLine();
           int tal = LäsInHeltal(stringTal);

           // Använd metod 3 igen
           Console.WriteLine("Mata in ett tal 5-10: ");
           int tal2 = LäsInHeltal(Console.ReadLine());
        }

            //skapa en metod som, när den anropas, skriver ut "Hello world!" 32 gånger.
            static void Print32()
            {
                string texten = "Hello World!";
                for (int i = 0; i < 32; i++)
                {
                    Console.WriteLine(texten);
                }
            }
            static void PrintText32(string texten)
            {
                for (int i = 0; i < 32; i++)
                {
                    Console.WriteLine(texten);
                }
            }

            static int LäsInHeltal(string stringTal)
            {
                int tal = 0;
                while (!int.TryParse(stringTal, out tal))
                {
                    Console.WriteLine("Du måste mata in ett heltal. Vg försök igen: ");
                    stringTal = Console.ReadLine();
                }
                return tal;
            }
            static int LäsInHeltalBättre()
            {
                int tal = 0;
                while (!int.TryParse(Console.ReadLine(), out tal))
                {
                    Console.WriteLine("Du måste mata in ett heltal. Vg försök igen: ");
                }
                return tal;
            }
    }
}
