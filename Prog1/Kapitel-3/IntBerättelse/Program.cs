using System;

namespace IntBerättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Deals With [[SPAMTON!]]");

            Console.WriteLine("*You walk inside a mysterious shop*");
            Console.WriteLine("\"HEY EVERY    ! IT'S ME, SPAMTON G. SPAMTON! MAY I INTEREST YOU IN SOME DEALS FOR [Hyperlink Blocked]?\"");
            Console.WriteLine("*It's a very glitchy looking robot. Will you look around?* (yes/no)");
            string answer1 = Console.ReadLine();
            if (answer1 == "yes")
            {
                Console.WriteLine("\"PERFECT [Givemekromer(money)]! WHAT WILL IT BE?!\"");
                Console.WriteLine("*You look around the junk shop and see a shiny key. Will you buy the it?* (yes/no)");
                string answer2 = Console.ReadLine();
                if (answer2 == "yes")
                {
                    Console.WriteLine("*You got the KeyGen*");
                    Console.WriteLine("\"DELICIOUS KROMER!\"");
                    Console.WriteLine("\"WANT TO CUT ANYTHING 2 PIECES?! USE [Hyperlink Blocked]?\"");
                    Console.WriteLine("*Spamton shows you a blade. Will you buy it or leave the shop?* (leave/buy)");
                    string answer4 = Console.ReadLine();
                    if (answer4 == "buy")
                    {
                        Console.WriteLine("*You got \"THE BIG ONE\". It's so sharp, it cut you into 2 pieces. You are dead.*");
                        Console.WriteLine("\"DELICIOUS KROMER!! I TOLD YOU YOU'D BE 2 PIECES.\"");
                    }
                    else
                    {
                        Console.WriteLine("\"PLEASURE MAKING [Deals] WITH YOU!\"");
                        Console.WriteLine("*You left the shop alive*");
                    }
                }
                else
                {
                    Console.WriteLine("\"BUT..! [Givemekromer] OR I [KILLED] YOU!\"");
                    Console.WriteLine("*You ran away faster than you've ever ran*");
                    Console.WriteLine("*...*"); 
                    Console.WriteLine("*You escaped but with an empty feeling in your chest*");                   
                }
            }
            else
            {
                Console.WriteLine("\"BUT IT'S SOME REAL [BIG SHOT] DEALS!\"");
                Console.WriteLine("*Are you sure you want to leave? (run/fine)");
                string answer3 = Console.ReadLine();
                if (answer3 == "run")
                {
                    Console.WriteLine("*Spamton looks at you very angrily*");
                    Console.WriteLine("*...*");
                    Console.WriteLine("*Your soul was destroyed*");
                }
                else
                {
                    Console.WriteLine("\"THOUGHT SO YOU LITTLE [GreatCustomer]! SO WILL IT BE A [Hyperlink Blocked]?\"");
                    Console.WriteLine("*Spamton shows you a bowtie with the words \"Big Shot\" written on it. Buy it?* (buy/nevermind)");
                    string answer5 = Console.ReadLine();
                    if (answer5 == "buy")
                    {
                        Console.WriteLine("*You got the BSHOT BOWTIE*");
                        Console.WriteLine("\"DELICIOUS KROMER! WILL YOU BUY ANYMORE [Big shot] ITEMS?!\"(yes/no)");
                        string answer6 = Console.ReadLine();
                        if (answer6 == "yes")
                        {
                            Console.WriteLine("\"HOW ABOUT THIS [Hyperlink Blocked]?!\"");
                            Console.WriteLine("*It's a huge blade. Will you buy it?* (yes/no)");
                            string answer7 = Console.ReadLine();
                            if (answer7 == "yes" )
                            {
                                Console.WriteLine("*You got \"THE BIG ONE\". It's so sharp, it cut you into 2 pieces. You are dead.*");
                                Console.WriteLine("\"DELICIOUS KROMER!! GLAD TO MAKE [Killed] BUISSNES WITH YOU!.\"");
                            }
                            else
                            {
                                Console.WriteLine("\"NO?! [Unfortunate]\"");
                                Console.WriteLine("*You were sliced in half*");
                            }
                        }
                        else
                        {
                         Console.WriteLine("\"I GUESS I AM THE ONLY [Big shot]\"");
                         Console.WriteLine("*Spamton shot you. You are dead*");   
                        }
                    }
                }
            }
        }
    }
}
