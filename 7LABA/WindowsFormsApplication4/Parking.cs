using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
	public class Parking
	{
		//список с уровнями парковки
		List<ClassArray<ITechnique>> parkingStages;
		///сколько мест на каждом уровне
		int countPlaces = 20;
		//// ширина парковочного места
		int placeSizeWidth = 200;
		//// длина парковочного места
		int placeSizeHeighth = 120;
		///текущий уровень 
		int currentLevel;
		///получить текущий уровень
		public int getCurrentLevel { get { return currentLevel; } }
		public Parking(int countStages)
		{
			parkingStages = new List<ClassArray<ITechnique>>(countStages);
			for( int i = 0; i<countStages; i++)
			{
				parkingStages.Add(new ClassArray<ITechnique>(countPlaces, null));
			}
		}

		// перейти на уровень выше
		public void LevelUp()
		{
			if (currentLevel + 1 < parkingStages.Count)
			{
				currentLevel++;
			}
		}

		////перейти на уровень ниже
		public void LevelDown()
		{
			if (currentLevel > 0)
			{
				currentLevel--;
			}
		}

		// поставить машину на парковку

		public int PutPlaneInParking(ITechnique plane)
		{
			return parkingStages[currentLevel] + plane;
		}

		//// забрать машину с парковки

		public ITechnique GetPlaneInParking(int ticket)
		{
			return parkingStages[currentLevel] - ticket;
		}

		/////отрисовка 


		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < countPlaces; i++)
			{
				var plane = parkingStages[currentLevel][i];
				if (plane != null)
				{ ///если место не пустое
					plane.setPosition(5 + i / 5 * 400 + 5, i % 5 * 235 + 15);
					plane.drawBombardir(g);
				}
			}
		}

		/// отрисовка разметки парковки


		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);
			///границы парковки
			g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue), (countPlaces / 5) * placeSizeWidth - 70, 420);

			g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 580);
			for (int i = 0; i < countPlaces / 5; i++)
			{
				///отрисовываем, по 5 мест на линии
				for (int j = 0; j < 6; ++j)
				{/// линия разметки места
					g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeighth, i * placeSizeWidth + 110, j * placeSizeHeighth);
					if (j < 5)
					{
						g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30),
						new SolidBrush(Color.Blue), i * placeSizeWidth + 30, j * placeSizeHeighth + 20);
					}
				}
				g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 580);
			}
		}

		public bool SaveData(string filename)
		{
			if (File.Exists(filename))
			{
				File.Delete(filename);
			}
			using (FileStream fs = new FileStream(filename, FileMode.Create))
			{
				using (BufferedStream bs = new BufferedStream(fs))
				{
					//Записываем кол-во уровней
					byte[] info = new UTF8Encoding(true).GetBytes("CountLeveles:" +
						parkingStages.Count + Environment.NewLine);
					fs.Write(info, 0, info.Length);
					foreach (var level in parkingStages)
					{
						//Начинаем уровень
						info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
						fs.Write(info, 0, info.Length);
						for (int i = 0; i < countPlaces; i++)
						{
							var plane = level[i];
							if (plane != null)
							{//Если место не пустое
							 //записываем тип машины
								if (plane.GetType().Name == "Plane")
								{
									info = new UTF8Encoding(true).GetBytes("Plane:");
									fs.Write(info, 0, info.Length);
								}
								if (plane.GetType().Name == "Bombardir")
								{
									info = new UTF8Encoding(true).GetBytes("Bombardir:");
									fs.Write(info, 0, info.Length);
								}
								//Записываем параметры
								info = new UTF8Encoding(true).GetBytes(plane.getInfo() + Environment.NewLine);

								fs.Write(info, 0, info.Length);
							}
						}
					}
				}
			}
			return true;
		}

		public bool LoadData(string filename)
		{
			if (!File.Exists(filename))
			{
				return false;
			}
			using (FileStream fs = new FileStream(filename, FileMode.Open))
			{
				string s = "";
				using (BufferedStream bs = new BufferedStream(fs))
				{
					byte[] b = new byte[fs.Length];
					UTF8Encoding temp = new UTF8Encoding(true);
					while (bs.Read(b, 0, b.Length) > 0)
					{
						s += temp.GetString(b);
					}
				}
				s = s.Replace("\r", "");
				var strs = s.Split('\n');
				if (strs[0].Contains("CountLeveles"))
				{//считываем кол-во уровней
					int count = Convert.ToInt32(strs[0].Split(':')[1]);
					if (parkingStages != null)
					{
						parkingStages.Clear();
					}
					parkingStages = new List<ClassArray<ITechnique>>(count);
				}
				else
				{ /// если нет такой записи, то это не те данные
					return false;
				}
				int counter = -1;
				for (int i = 1; i < strs.Length; ++i)
				{//идем по считанным записям
					if (strs[i] == "Level")
					{//Начинаем новый уровень
						counter++;
						parkingStages.Add(new ClassArray<ITechnique>(countPlaces, null));
					}
					else if (strs[i].Split(':')[0] == "Plane")
					{
						ITechnique plane = new Plane(strs[i].Split(':')[1]);
						int number = parkingStages[counter] + plane;
						if (number == -1)
						{
							return false;
						}
					}
					else if (strs[i].Split(':')[0] == "Bombardir")
					{
						ITechnique plane = new Bombardir(strs[i].Split(':')[1]);
						int number = parkingStages[counter] + plane;
						if (number == -1)
						{
							return false;
						}
					}
				}
			}
			return true;
		}

	}
}
