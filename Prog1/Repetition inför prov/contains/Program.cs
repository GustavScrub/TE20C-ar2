using System;

namespace contains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in din epost: ");
            string epost = Console.ReadLine();

            // Kolla att texten innehåller @
            if (epost.Contains("@"))
            {
                Console.WriteLine("Det verkar som du skriver in en korrekt epostadress");
            }

            // 1 + 2 +3, 2 * 6, 10 /3
            Console.WriteLine("Mata in ett mattetal: ");
            string mattetal = Console.ReadLine();

            // Berätta om : + eller - eller * eller / har använts
            bool flagga = false;
            if (mattetal.Contains("+"))
            {
                Console.WriteLine("Du använder operator +");
                flagga = true;
            }
            if (mattetal.Contains("-"))
            {
                Console.WriteLine("Du använder operator -");
                flagga = true;
            }
            if (mattetal.Contains("*"))
            {
                Console.WriteLine("Du använder operator *");
                flagga = true;
            }
            if (mattetal.Contains("/"))
            {
                Console.WriteLine("Du använder operator /");
                flagga = true;
            }

            if (flagga == true)
            {
                Console.WriteLine("Du använder +, -, *, /");
            }
        }
    }
}
