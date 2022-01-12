using System;
using Raylib_cs;

namespace RAF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello RAF!");

            Raylib.InitWindow(800, 600, "Into the window");

            Raylib.SetTargetFPS(60);

            Console.WriteLine("Hann inte med det sista, men det är basic grejer jag har koll på.");

        }
    }
}
