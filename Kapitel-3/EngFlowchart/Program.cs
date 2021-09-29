using System;
using System.Text;

namespace EngFlowchart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.WriteLine("Engineering Flowchart");

            Console.WriteLine("Does it move? (y/n) ");
            string answer1 = Console.ReadLine();
            if (answer1 == "y")
            {
                Console.WriteLine("Should it? (y/n) ");
                string answer2 = Console.ReadLine();
                if (answer2 == "y")
                {
                   Console.WriteLine("No problem! 😁"); 
                }
                else
                {
                    Console.WriteLine("Use Duct tape! 🤪");
                }
            }
            else
            {
              Console.WriteLine("Should it? (y/n) ");
              if (Console.ReadLine() == "n")  
              {
                  Console.WriteLine("No problemo! 😁");
              }
              else
              {
                  Console.WriteLine("Use WD-40! 🤪");
              }
            }
        }
    }
}
