using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
	class Parking
	{
		ClassArray<ITechnique> parking;
        int countPlaces = 15;
        int placeSizeWidth = 200;

        int placeSizeHeight = 120;

        public Parking()
		{
			parking = new ClassArray<ITechnique>(countPlaces, null);
		}

		public int PutPlaneInParking(ITechnique plane)
		{
			return parking + plane;
		}
		public ITechnique GetPlaneInParking(int ticket)
		{
			return parking - ticket;
		}


		public void Draw(Graphics g, int wigth, int height)
		{
			DrawMarking(g);

			for (int i = 0; i < countPlaces; i++)
			{
				var plane = parking.getObject(i);
				if (plane != null)
				{
					// если место не пустое
					plane.setPosition(5 + i / 5 * 400 + 15, i % 5 * 240 + 15);
					plane.drawBombardir(g);
				}
			}
		}

		private void DrawMarking(Graphics g)
		{
            Pen pen = new Pen(Color.Black, 3);
            // границы парковки
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 585);
            for (int i = 0; i < countPlaces / 5; i++)
            {
                //отрисовываем по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {
                    //линия разметки места
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight,
                        i * placeSizeWidth + 110, j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 585);

            }
        }
	}
}
