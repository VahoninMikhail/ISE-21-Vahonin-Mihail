using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class Plane : Technique
    {
        private bool left;
        private bool right;

        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }
            protected set
            {
                if (value > 0 && value < 1500)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 1000;
                }
            }
        }

        public override int MaxCountBomb
        {
            get
            {
                return base.MaxCountBomb;
            }
            protected set
            {
                if (value > 0 && value < 5)
                {
                    base.MaxCountBomb = value;
                }
                else
                {
                    base.MaxCountBomb = 4;
                }
            }
        }

        public override double Weight
        {
            get
            {
                return base.Weight;
            }
            protected set
            {
                if (value > 500 && value < 1500)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 1000;
                }
            }
        }

        public Plane(int maxSpeed, int maxCountBomb, double weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountBomb = maxCountBomb;
            this.ColorBody = color;
            this.Weight = weight;
            this.countBomb = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }

        public Plane(int maxSpeed, int maxCountBomb, double weight, Color color, bool left, bool right) : this(maxSpeed, maxCountBomb, weight, color)
        {
            this.left = left;
            this.right = right;
        }

        public override void moveBombardir(Graphics g)
        {
            startPosX += (MaxSpeed * 50 / (float)Weight) / (countBomb == 0 ? 1 : countBomb);
            drawBombardir(g);
        }

        public override void moveUpBombardir(Graphics g)
        {
            startPosY -= (MaxSpeed * 50 / (float)Weight) / (countBomb == 0 ? 1 : countBomb);
            drawBombardir(g);
        }

        public override void drawBombardir(Graphics g)
        {
            drawLightBombardir(g);
        }

        protected virtual void drawLightBombardir(Graphics g)
        {
            Pen pen = new Pen(this.ColorBody);
            g.DrawLine(pen, (startPosX + 25)/2, (startPosY + 20)/2, (startPosX + 40)/2, (startPosY + 20)/2);
            g.DrawLine(pen, (startPosX + 40)/2, (startPosY + 20)/2, (startPosX + 130)/2, (startPosY + 95)/2);
            g.DrawLine(pen, (startPosX + 130)/2, (startPosY + 95)/2, (startPosX + 130)/2, (startPosY + 110)/2);
            g.DrawLine(pen, (startPosX + 130)/2, (startPosY + 110)/2, (startPosX + 40)/2, (startPosY + 190)/2);
            g.DrawLine(pen, (startPosX + 40)/2, (startPosY + 190)/2, (startPosX + 25)/2, (startPosY + 190)/2);
            g.DrawLine(pen, (startPosX + 25)/2, (startPosY + 190)/2, (startPosX + 80)/2, (startPosY + 110)/2);
            g.DrawLine(pen, (startPosX + 80)/2, (startPosY + 110)/2, (startPosX + 80)/2, (startPosY + 95)/2);
            g.DrawLine(pen, (startPosX + 80)/2, (startPosY + 95)/2, (startPosX + 25)/2, (startPosY + 20)/2);
        }

        public override void moveBomb(Graphics g)
        {
            throw new NotImplementedException();
        }

        public override void giveBomb(Graphics g)
        {
            takeBomb(g);
        }

        protected virtual void takeBomb(Graphics g)
        {

        }

    }

}
