using System;
using Raylib_cs;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] bullets = new Rectangle[10];
            // Array for the speed of the bullets
            int [] speed = new int [10];

             // Timer for level 1
            float sec = 120;
            // The actual array 
            // Points for level 2
            float pointwo = 0;
            // Life level 2
            int life = 1;
            // Spikes
            Rectangle spike = new Rectangle(100, 0, 50, 50);
            // Loopa igenom arrayen

             // If the player touches a bullet in level 2
                if (Raylib.CheckCollisionRecs(player, spike))
                {
                    spike.x = 0;
                    spike.y = generator.Next(windowH, 0);
                    life -= 1;
                }

            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new Rectangle(0, 0, 50, 50);
                bullets[i].x = generator.Next(0, windowB);
                bullets[i].y = generator.Next(0, windowH) - windowH;
            }

            for (int i = 0; i < bullets.Length; i++)
            {
                speed[i] = generator.Next(1, 6);
            }
           
                    for (int i = 0; i < bullets.Length; i++)
                    {
                        bullets[i].y += speed[i];
                        if (bullets[i].y > windowH)
                        {
                            bullets[i].y = 0;
                        }
                    }

                    for (int i = 0; i < bullets.Length; i++)
                    {
                        Raylib.DrawRectangleRec(bullets[i], Color.BLACK);
                    }

                    Raylib.DrawRectangleRec(player, Color.RED);

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                    {
                        player.x += 5;
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                    {
                        player.x -= 5;
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                    {
                        player.y += 5;
                    }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                    {
                        player.y -= 5;
                    }
                    
                    if (Raylib.CheckCollisionRecs(player, bullets))
                    {
                        lives--;
                    }

                     if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
                {
                    scene = "scene 4";
                }

                if (scene == "scene 2")
                {
                    Raylib.DrawText("Level 2", 150, 100, 50, Color.BLACK);
                    Raylib.DrawText("Keep dodging until you die", 150, 200, 50, Color.BLACK);
                    Raylib.DrawText("Press enter to play", 150, 300, 50, Color.BLACK);
                }

                if (scene == "scene 4")
                {
                    pointwo -= Raylib.GetFrameTime();
                    Raylib.DrawText($"Points:{pointwo}", 150, 0, 50, Color.BLACK);

                    Raylib.DrawRectangleRec(player, Color.WHITE);
                    Raylib.DrawRectangleRec(spike, Color.BLACK);
                }
        }
    }
}
