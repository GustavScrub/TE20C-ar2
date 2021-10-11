using System;

namespace Lucktext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Svara på dessa 4 frågor");
            Console.Write("Vad är den bästa fågeln?");
            string svar1 = Console.ReadLine();
            Console.WriteLine($"Intressant val av {svar1}");

            Console.Write("Programmering eller Webutveckling?");
            string svar2 = Console.ReadLine();
            Console.WriteLine($"Alla vet ju att {svar2} är rätt");

            Console.Write("Hur lång är du?");
            string svar3 = Console.ReadLine();
            Console.WriteLine($"Jag känner någon som är 145 så att vara {svar3} är lugnt");

            Console.Write("DJ Grooves eller The Conducter?");
            string svar4 = Console.ReadLine();
            Console.WriteLine($"Båda är lika bra. Bra val med {svar4} ändå");


        }
    }
}
