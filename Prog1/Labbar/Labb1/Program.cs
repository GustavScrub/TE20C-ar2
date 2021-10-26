using System;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Presentera programmet
            Console.WriteLine("Program som skrivet ut ASCII");

            //Be användaren mata in ett ord
            Console.Write("Ange ett ord: ");
            string ord = Console.ReadLine();

            Console.Write("Ange en nyckel: ");
            int nyckel = int.Parse(Console.ReadLine());
            string krypteratMeddelande = "";
            for (int i = 0; i < ord.Length; i++)
            {
                char bokstav = ord[i];
                
                int kod = (int)bokstav;

                Console.WriteLine(bokstav);
                
                //Lägg till nyckeln
                kod = kod + nyckel;         //kod += nyckel;

                //Vad är den nya bokstaven?
                char bokstavKrypterad = (char)(kod);

                //Console.WriteLine($"{bokstav} {kod} {bokstavKrypterad}");
                
                krypteratMeddelande += bokstavKrypterad.ToString();
            }

            //Skriv ut färdiga meddelandet
            Console.WriteLine(krypteratMeddelande);
        }
    }
}
