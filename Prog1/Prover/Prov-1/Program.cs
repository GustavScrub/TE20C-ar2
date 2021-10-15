using System;

namespace Prov_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Berätta vad programmet gör
            Console.WriteLine("Uträkning av nettolön\n---------------------");

            //Fråga efter namn
            Console.Write("Vad heter du? ");
            string namn = Console.ReadLine();

            //Fråga efter bruttolön
            System.Console.WriteLine("Ange din bruttolön i kronor");
            int bruttolön = int.Parse(Console.ReadLine());

            //Fråga efter skattesats
            System.Console.WriteLine("Ange din skattesats i kronor");
            int skattesats = int.Parse(Console.ReadLine());

            //Kolla att villkoren är uppfyllda
            if (bruttolön > 10000 && bruttolön <= 45000)
            {
                //Fråga efter skattesats
                Console.Write("Ange din skattesats i kronor: ");

                //Kolla att villkoren är uppfullda för skattesats
                if (skattesats >= 10 && skattesats <=45)
                {
                    //Räkna ut nettolön
                    
                }
            }
            else
            {
                Console.WriteLine("Bruttolön måste vara mellan 10000 och 45000");
            }
                        
            
            //Räkna ut nettolön
            int nettolön = bruttolön * (100 - skattesats) / 100;
            Console.WriteLine($"{namn}, din lön efter skatt är {nettolön}");


        }
    }
}
