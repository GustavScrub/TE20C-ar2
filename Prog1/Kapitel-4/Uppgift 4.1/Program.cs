using System;

namespace Uppgift_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Vilket är världens folkrikaste land?");
            string svar = Console.ReadLine();
            while (svar != "Kina")
            {
             Console.WriteLine("Detta är fel svar! Svara igen");
             svar = Console.ReadLine();    
            }
            Console.WriteLine("Yes! Nu hade du rätt!");
        }
    }
}
