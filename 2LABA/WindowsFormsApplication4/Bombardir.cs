using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsFormsApplication4
{
	public class Bombardir : Plane
	{
		private bool left;
		private bool right;

        private Color dopColor;

		public Bombardir(int maxSpeed, int maxCountBomb, double weight, Color color, bool left, bool right, Color dopColor) : base(maxSpeed, maxCountBomb, weight, color)
		{
			this.left = left;
			this.right =right;
            this.dopColor = dopColor;
		}

        protected override void takeBomb(Graphics g)
        {
            Pen pen = new Pen(Color.Red);
            for ( int i = 0; i<=20; i++)
            {
                g.DrawLine(pen, 0, 0, 800+i*30, 800+i*30);
                g.DrawLine(pen, 0, 0, 1200+i*30, 800+i*30);
                g.DrawLine(pen, 1200+i*30, 0, 0, 500+i*30);
                g.DrawLine(pen, 1100+i*30, 0, 0, 200+i*30);
                g.DrawLine(pen, 1100+i*30, 0, 0, 200+i*30);
            }
        }

        protected override void drawLightBombardir(Graphics g)
		{
            base.drawLightBombardir(g);

			if(left)
			{
				Pen pen = new Pen(dopColor);

                g.DrawLine(pen, startPosX + 20, startPosY + 40, startPosX + 105, startPosY + 40);
                g.DrawLine(pen, startPosX + 105, startPosY + 40, startPosX + 125, startPosY + 50);
                g.DrawLine(pen, startPosX + 125, startPosY + 50, startPosX + 105, startPosY + 60);
                g.DrawLine(pen, startPosX + 105, startPosY + 60, startPosX + 20, startPosY + 60);
                g.DrawLine(pen, startPosX + 20, startPosY + 60, startPosX + 20, startPosY + 40);
            }

			if(right)
			{
                Pen pen = new Pen(dopColor);

                g.DrawLine(pen, startPosX + 20, startPosY + 145, startPosX + 105, startPosY + 145);
                g.DrawLine(pen, startPosX + 105, startPosY + 145, startPosX + 125, startPosY + 155);
                g.DrawLine(pen, startPosX + 125, startPosY + 155, startPosX + 105, startPosY + 165);
                g.DrawLine(pen, startPosX + 105, startPosY + 165, startPosX + 20, startPosY + 165);
                g.DrawLine(pen, startPosX + 20, startPosY + 165, startPosX + 20, startPosY + 145);
            }
		}
	}
}
