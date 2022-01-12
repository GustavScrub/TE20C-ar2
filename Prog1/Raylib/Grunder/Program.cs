using System;
using Raylib_cs;

namespace Grunder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there Raylib!");

            // Starta ett fönster
            Raylib.InitWindow(800, 600, "Ett Raylib fönster");

            // Ställ in fps
            Raylib.SetTargetFPS(60);

            // En egen färg
            Color GoldenRod = new Color(218, 165, 32, 170);

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                 // Börja rita
                 Raylib.BeginDrawing();

                 // Tömma ritytan
                 Raylib.ClearBackground(Color.DARKBLUE);

                 // Rita en rektangel
                 Raylib.DrawRectangle(1, 250, 800, 80, Color.GOLD);
                 Raylib.DrawRectangle(200, 0, 100, 600, Color.GOLD);

                 // Rita en cirkel
                 Raylib.DrawCircle(400, 300, 100, GoldenRod);

                 // Rita text
                 Raylib.DrawText("Det här är en cirkel", 100, 500, 50, Color.RED);

                 // Sluta rita
                 Raylib.EndDrawing();
            }
        }
    }
}
