using System;

namespace Randomness
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Välj mellan motståndare 0-2: ");
                string[] motståndarna = new string[3]; // motståndarna har positionerna 0, 1, 2
                motståndarna[0] = "Muzan Kibutsuji (0)";
                motståndarna[1] = "Ryomen Sukuna (1)";
                motståndarna[2] = "Eren Yeager (2)";

                foreach (var motståndare in motståndarna)
                {
                    Console.WriteLine(motståndare);
                }

                int spelarSvar = 0;
                spelarSvar = int.Parse(Console.ReadLine());
                Console.WriteLine($"Du har valt {motståndarna[spelarSvar]}");
                string type = Console.ReadLine();
                
                while (type == "w")
                {
                    break;
                }
            }
        }
    }
}
