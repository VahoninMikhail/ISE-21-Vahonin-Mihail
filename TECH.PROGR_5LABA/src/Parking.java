import java.awt.Color;
import java.awt.Graphics;
import java.util.ArrayList;
import java.util.List;

public class Parking {
	
	ClassArray<ITechnique> parking;
	// 4
	List<ClassArray<ITechnique>> parkingStages;
	int currentLevel;
	//
    int countPlaces = 15;
    int placeSizeWidth = 200;
    int placeSizeHeight = 120;

    
 // 4
 	public int getCurrentLevel() {
 		return currentLevel;
 	}

 	//

 	// 4
 	public Parking(int countStages) {
 		parkingStages = new ArrayList<ClassArray<ITechnique>>(countStages);
 		for (int i = 0; i < countStages; i++) {
 			parking = new ClassArray<ITechnique>(countPlaces, null);
 			parkingStages.add(parking);
 		}
 	}

 	public void LevelUp() {
 		if (currentLevel + 1 < parkingStages.size()) {
 			currentLevel++;
 		}
 	}

 	public void LevelDown() {
 		if (currentLevel > 0) {
 			currentLevel--;
 		}
 	}

 	//

 	public int PutPlaneInParking(ITechnique plane) {
 		// 4
 		return parking.Plus(parkingStages.get(currentLevel), plane);
 		//
 	}

 	public ITechnique GetPlaneInParking(int ticket) {
 		// 4
 		return parking.Minus(parkingStages.get(currentLevel), ticket);
 		//
 	}

	public void Draw(Graphics g, int wigth, int height)
	{
		DrawMarking(g);
		for (int i = 0; i < countPlaces; i++)
		{
			ITechnique plane = parkingStages.get(currentLevel).getObject(i);
			if (plane != null)
			{ ///если место не пустое
				plane.setPosition(5 + i / 5 * 400 + 5, i % 5 * 235 + 15);
				plane.drawBombardir(g);
			}
		}
	}

	private void DrawMarking(Graphics g)
	{
		g.setColor(Color.BLACK);
		// 4
		g.drawString(("L" + currentLevel + 1), (countPlaces / 5) * placeSizeWidth - 70, 420);
		//
        // границы парковки
        g.drawRect(0, 0, (countPlaces / 5) * placeSizeWidth, 585);
        for (int i = 0; i < countPlaces / 5; i++)
        {
            //отрисовываем по 5 мест на линии
            for (int j = 0; j < 6; ++j)
            {
                //линия разметки места
                g.drawLine(i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
             // 4
				if (j < 5) {
					String str = "" + (i * 5 + j + 1);
					g.drawString(str, i * placeSizeWidth + 30, j * placeSizeHeight + 20);
				}
			//
            }
            g.drawLine(i * placeSizeWidth, 0, i * placeSizeWidth, 585);

        }
    }
}
