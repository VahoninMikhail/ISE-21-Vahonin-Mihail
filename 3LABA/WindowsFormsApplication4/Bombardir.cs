using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
	public class Bombardir : Plane
	{
		private bool left;
		private bool right;
        private Color dopColor;


        public Bombardir(int maxSpeed, int maxCountBomb, double weight, Color color, bool left, bool right, bool v, Color dopColor) : base(maxSpeed, maxCountBomb, weight, color, left, right)
        {
            this.left = left;
            this.right = right;
            this.dopColor = dopColor;
        }

        protected override void takeBomb(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, startPosX + 100, startPosY + 150, startPosX + 130, startPosY + 180);
        }

        protected override void drawLightBombardir(Graphics g)
		{
            base.drawLightBombardir(g);
             
            if (left)
			{
				Pen pen = new Pen(dopColor);

                g.DrawLine(pen, (startPosX + 20)/2, (startPosY + 40)/2, (startPosX + 105)/2, (startPosY + 40)/2);
                g.DrawLine(pen, (startPosX + 105)/2, (startPosY + 40)/2, (startPosX + 125)/2, (startPosY + 50)/2);
                g.DrawLine(pen, (startPosX + 125)/2, (startPosY + 50)/2, (startPosX + 105)/2, (startPosY + 60)/2);
                g.DrawLine(pen, (startPosX + 105)/2, (startPosY + 60)/2, (startPosX + 20)/2, (startPosY + 60)/2);
                g.DrawLine(pen, (startPosX + 20)/2, (startPosY + 60)/2, (startPosX + 20)/2, (startPosY + 40)/2);
            }

			if(right)
			{
                Pen pen = new Pen(dopColor);

                g.DrawLine(pen, (startPosX + 20)/2, (startPosY + 145)/2, (startPosX + 105)/2, (startPosY + 145)/2);
                g.DrawLine(pen, (startPosX + 105)/2, (startPosY + 145)/2, (startPosX + 125)/2, (startPosY + 155)/2);
                g.DrawLine(pen, (startPosX + 125)/2, (startPosY + 155)/2, (startPosX + 105)/2, (startPosY + 165)/2);
                g.DrawLine(pen, (startPosX + 105)/2, (startPosY + 165)/2, (startPosX + 20)/2, (startPosY + 165)/2);
                g.DrawLine(pen, (startPosX + 20)/2, (startPosY + 165)/2, (startPosX + 20)/2, (startPosY + 145)/2);
            }
		}
	}
}
