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

		public Bombardir(string info) : base(info)
        {
			string[] strs = info.Split(';');
			if (strs.Length == 7)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				MaxCountBomb = Convert.ToInt32(strs[1]);
				Weight = Convert.ToInt32(strs[2]);
				ColorBody = Color.FromName(strs[3]);
				left = Convert.ToBoolean(strs[4]);
				right = Convert.ToBoolean(strs[5]);
				dopColor = Color.FromName(strs[6]);
			}
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

		public void setDopColor(Color color)
		{
			dopColor = color;
		}

		public override string getInfo()
		{
			return MaxSpeed + ";" + MaxCountBomb + ";" + Weight + ";" + ColorBody.Name + ";" 
				+ left + ";" + right + ";" + dopColor.Name;
		}
		}
}
