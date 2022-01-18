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

            // Skapa en spelare av en rektangel
            Rectangle spelare = new Rectangle(100, 100, 50, 50);

             // Skapa en fiende
            Rectangle fiende = new Rectangle(100, 200, 50, 50);
            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                /* Rita ut grafiken */
                 // Börja rita
                 Raylib.BeginDrawing();
                 
                 // Töm ritytan
                 Raylib.ClearBackground(Color.DARKBLUE);

                 // Rita ut spelaren
                 Raylib.DrawRectangleRec(spelare, Color.RED);

                 // Rita ut på fönstret
                 Raylib.EndDrawing();

                 /* Intereaktion med användaren */
                 // Lyssna på tangenter
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                 {
                     spelare.x += 5;
                 }
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                 {
                     spelare.x -= 5;
                 }
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                 {
                     spelare.y -= 5;
                 }
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                 {
                     spelare.y += 5;
                 }

                 // Rita ut spelaren
                 Raylib.DrawRectangleRec(spelare, Color.GREEN);

                 // Rita ut på fönstret
                 Raylib.EndDrawing();

                 /* Intereaktion med användaren */
                 // Lyssna på tangenter
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                 {
                     spelare.x += 5;
                 }
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                 {
                     spelare.x -= 5;
                 }
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                 {
                     spelare.y -= 5;
                 }
                 if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                 {
                     spelare.y += 5;
                 }
            }
        }
    }
}
