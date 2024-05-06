using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaylibGame
{
    public class Game
    {
        Player player = new Player();
        public Game() 
        {
            float posx = (Raylib.GetScreenWidth() / 2);
            float posy = (Raylib.GetScreenHeight() / 2);
            player.position.X = posx;
            player.position.Y = posy;
            player.speed = 1.0f;
        }
        public void Update()
        {
            player.Update();
        }
        public void Draw()
        {
            player.Draw();
        }

        public void Run()
        {
            Raylib.InitWindow(800, 480, "The Game");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Black);
                Update();
                Draw();
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
