using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RaylibGame
{   
    public class Player
    {
        private Texture2D Texture;
        public Vector2 position;
        public float speed;
        public Player()
        {
            Texture = Raylib.LoadTexture("assets/Block.png");
        }

        public void Update()
        {
            int direction;
            if(Raylib.IsKeyDown(KeyboardKey.W))
            {
                direction = -1;
                position.Y += speed * direction * 0.03f;
            }
            if (Raylib.IsKeyDown(KeyboardKey.S))
            {
                direction = 1;
                position.Y += speed * direction * 0.03f;
            }
            if (Raylib.IsKeyDown(KeyboardKey.A))
            {
                direction = -1;
                position.X += speed * direction * 0.03f;
            }
            if (Raylib.IsKeyDown(KeyboardKey.D))
            {
                direction = 1;
                position.X += speed * direction * 0.03f;
            }
        }
        public void Draw()
        {
            Raylib.DrawTexture(Texture, (int)position.X,(int)position.Y,Color.White);
        }

    }
}
