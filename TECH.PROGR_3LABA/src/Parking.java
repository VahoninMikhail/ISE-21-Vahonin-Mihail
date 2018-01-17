import java.awt.Color;
import java.awt.Graphics;

public class Parking {
	
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
		return parking.Plus(parking, plane);
	}
	public ITechnique GetPlaneInParking(int ticket)
	{
		return parking.Minus(parking, ticket);
	}


	public void Draw(Graphics g, int wigth, int height)
	{
		DrawMarking(g);
		for (int i = 0; i < countPlaces; i++)
		{
			ITechnique plane = parking.getObject(i);
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
		g.setColor(Color.BLACK);
        // границы парковки
        g.drawRect(0, 0, (countPlaces / 5) * placeSizeWidth, 585);
        for (int i = 0; i < countPlaces / 5; i++)
        {
            //отрисовываем по 5 мест на линии
            for (int j = 0; j < 6; ++j)
            {
                //линия разметки места
                g.drawLine(i * placeSizeWidth, j * placeSizeHeight,
                    i * placeSizeWidth + 110, j * placeSizeHeight);
            }
            g.drawLine(i * placeSizeWidth, 0, i * placeSizeWidth, 585);

        }
    }
}
