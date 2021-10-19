using System;

namespace Prog_Prov_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Uträkning av nettolön");
            Console.WriteLine("---------------------");
            Console.Write("Vad heter du? ");
            string svar1 = Console.ReadLine();
            
            Console.Write("Ange din bruttolön i kronor: ");
            int svar2 = int.Parse(Console.ReadLine());

            if (svar2 < 10000 && svar2 > 45000)
            {
                Console.WriteLine($"{svar1}, bruttolön måste vara 45000 < 10000");
            }
            if (svar2 < 45000)
            {
                Console.WriteLine($"{svar1}, bruttolön måste vara 45000 < 10000");                
            }
            
            Console.Write("Ange din skattesats i %: ");
            int svar3 = int.Parse(Console.ReadLine());

            if (svar3 < 10)
            {
                Console.WriteLine($"{svar1}, skattesatsen måste vara 45% < 10%");
            }
            if (svar3 > 45)
            {
                Console.WriteLine($"{svar1}, skattesatsen måste vara 45% < 10%");                
            }
            else
            {
                int svar4 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Baserat på din bruttolön {svar2} kr och skattesats {svar3}%");
            }
        }
    }
}
