using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
	interface ITechnique
	{
		void moveBombardir(Graphics g);

        void moveUpBombardir(Graphics g);

        void giveBomb(Graphics g);

        void moveBomb(Graphics g);

		void setPosition(int x, int y);

		void loadBomb(int count);

		int getBomb();
        void drawBombardir(Graphics gr);
    }
}
