using System;
using Raylib_cs;

namespace Bilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starta grafikmotorn
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(60);

            // Ladda in bilden
            Texture2D månen = Raylib.LoadTexture(@"./resur");

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                 // Börja rita
                 Raylib.BeginDrawng();
                 
                 // Töm ritytan
                 Raylib.ClearBackground
            }
        }
    }
}
