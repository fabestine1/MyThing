using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Week2_ExtraPractical
{
    class GameCharacter
    {
        public string Name { get; private set; }
        public Color Color { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Speed { get; private set; }


        public string HorizontalDirection { get; private set; }

        static int edge = 665;

        int velocity = 0;

        bool stopJump;

        public GameCharacter(string nwName, Color nwColor, string nwSize, int nwX, int nwY, int nwSpeed)
        {
            Name = nwName;
            Color = nwColor;
            if(nwSize == "Normal")
            {
                Width = 30;
                Height = 30;
            }
            else if (nwSize == "Small")
            {
                Width = 15;
                Height = 15;
            }
            else
            {
                Width = 45;
                Height = 45;
            }
            X = nwX;
            Y = nwY;
            if(Name == "Enemy 1")
            {
                HorizontalDirection = "right";
            }
            if (Name == "Enemy 2")
            {
                HorizontalDirection = "still";
            }
            if (Name == "Enemy 3")
            {
                HorizontalDirection = "left";
            }
            Speed = nwSpeed;
        }
        public void Draw(Graphics g, Brush brush)
        {
            g.FillRectangle(brush, X, Y, Width, Height);
        }
        public void UpdateAI()
        {
            if (X == 0)
            {
                HorizontalDirection = "right";
            }
            else if (X == edge)
            {
                HorizontalDirection = "left";
            }
            if (HorizontalDirection == "right")
            {
                X += Speed;
            }
            else if (HorizontalDirection == "left")
            {
                X -= Speed;
            }
            else if (HorizontalDirection == "still")
            {
            }
            else
            {
                X += Speed;
            }
            }
        public void Update(bool leftMovement, bool rightMovement, bool jump)
        {
            if (X == 0)
            {
                rightMovement = true;
                leftMovement = false;
            }
            else if (X == edge)
            {
                leftMovement = true;
                rightMovement = false;
            }
            if (rightMovement)
            {
                X += Speed;
            }
            else if (leftMovement)
            {
                X -= Speed;
            }
            else
            {
            }
            if (jump)
            {
                if (!stopJump)
                {
                    if (Y + velocity < 149)
                    {
                        velocity -= 1;
                        Y += velocity;
                    }
                    else
                    {
                        velocity += 1;
                        Y -= velocity;
                    }
                    if (velocity == 0)
                    {
                        stopJump = true;
                    }
                    X++;
                }
            }
        }
        }
    }
