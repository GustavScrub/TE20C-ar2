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
            Console.WriteLine("*It's a very glitchy looking robot. Will you look around?* (Yes/No)");
            string answer1 = Console.ReadLine();
            if (answer1 == "Yes")
            {
                Console.WriteLine("\"PERFECT! WHAT WILL IT BE?!\"");
                Console.WriteLine("*You look around the junk shop and see a shiny key. Will you buy the it?* (Yes/No)");
                string answer2 = Console.ReadLine();
                if (answer2 == "Yes")
                {
                    Console.WriteLine("*You got the KeyGen*");
                    Console.WriteLine("\"DELICIOUS KROMER!\"");
                    Console.WriteLine("\"WANT TO CUT ANYTHING 2 PIECES?! USE [Hyperlink Blocked]?\"");
                    Console.WriteLine("*Spamton shows you a blade. Will you buy it or leave the shop?* (Leave/Buy)");
                    string answer4 = Console.ReadLine();
                    if (answer4 == "Buy")
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
            }
            else
            {
                Console.WriteLine("\"BUT IT'S SOME REAL [BIG SHOT] DEALS!\"");
                Console.WriteLine("*Are you sure you want to leave? (RUN/Fine...)");
                string answer3 = Console.ReadLine();
                if (answer3 == "RUN")
                {
                    Console.WriteLine("*Spamton looks at you very angrily*");
                    Console.WriteLine("*...*");
                    Console.WriteLine("*Your soul was destroyed*");
                }
                else
                {
                    Console.WriteLine("\"THOUGHT SO YOU LITTLE [GreatCustomer]! SO WILL IT BE A [Hyperlink Blocked]?\"");
                    Console.WriteLine("*Spamton shows you a bowtie with the words \"Big Shot\" written on it. Buy it?* (Buy/Nevermind)");
                    string answer5 = Console.ReadLine();
                    if (answer5 == "Buy")
                    {
                        Console.WriteLine("*You got the BSHOT BOWTIE*");
                        Console.WriteLine("\"DELICIOUS KROMER\"");
                    }
                }
            }
        }
    }
}
