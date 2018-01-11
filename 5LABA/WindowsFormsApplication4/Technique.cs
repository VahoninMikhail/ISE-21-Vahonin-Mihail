using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
	public abstract class Technique : ITechnique
	{
		protected float startPosX;
		protected float startPosY;
		protected int countBomb;

		public virtual int MaxCountBomb { protected set; get; }
		public virtual int MaxSpeed { protected set; get; }
		public Color ColorBody { protected set; get; }

		public virtual double Weight { protected set; get; }

		public abstract void moveBombardir(Graphics g);
        public abstract void giveBomb(Graphics g);
        public abstract void moveUpBombardir(Graphics g);
        public abstract void drawBombardir(Graphics g);

		public void setPosition(int x, int y)
		{
			startPosX = x;
			startPosY = y;
		}

		public void loadBomb(int count)
		{
			if (countBomb + count < MaxCountBomb)
			{
				countBomb += count;
			}
		}

		public int getBomb()
		{
			int count = countBomb;
			countBomb = 0;
			return count;
		}

		public virtual void setMainColor(Color color)
		{
			ColorBody = color;
		}

		public abstract void moveBomb(Graphics g);
	}
}
