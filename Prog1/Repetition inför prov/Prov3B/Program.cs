using System;

namespace Prov3B
{
    class Program
    {
        static void Main(string[] args)
        {
                
            Console.Clear();
            Console.WriteLine("Progran for listing countries!");

            // Array of countries
            string[] countries = {"Andorra", "Afghanistan", "Antigua och Barbuda", "Bulgarien", "Vitryssland", "Benin", "Chile", "Kina", "Dominikanska republiken", "Eritrea", "Indonesien", "Kirgizistan", "Liechtenstein", "Madagaskar", "Papua Nya Guinea"
            };

            // Minimum length
            int minLength = 4;

            // Length of longest country name
            int topLenght = 0;

            // Calculate topLength
            foreach (var country in countries)
            {
                if (topLenght <= country.Length)
                {
                    topLenght = country.Length;
                }
            }

            // Maxlenght for names to output
            int maxLength = 0;

            while (true)
            {  
            // User inputs maxLenght
            Console.Write("Please input max length, between 4 and 23: ");
            maxLength = InputInt(minLength, topLenght);

            // Output all countries
            outputCountries(maxLength, countries);

            // Go again?
            Console.Write("Do you want to try again? (y/n) ");
            if (Console.ReadLine() == "n")
            {
                break;
            } 
            }
        }
        

        // Method for inputing an int 
        static int InputInt(int minLength, int topLenght)
            {
                int max = 0;
                while (true)
                {
                    // 1. Make sure user inputs an int                    
                while (!int.TryParse(Console.ReadLine(), out max))
                {
                    Console.Write("You have to put in a full number. Please try again: ");

                }
                    // 2. Make sure user input number between 4 and 22
                    if (max < minLength || max > topLenght)
                    {
                        Console.WriteLine("It has to be at least 4 and not more than 22. Please try again");
                    }
                    else
                    {
                        break;
                    }
                }
                return max;
            }

            static void outputCountries(int maxLength, string [] countries)
            {
                foreach (var country in countries)
            {
                if (country.Length <= maxLength)
                {
                    Console.WriteLine($"* {country}");
                }
            }
            }
    }
}


