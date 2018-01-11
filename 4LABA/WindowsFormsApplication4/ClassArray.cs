using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
	class ClassArray<T> where T : ITechnique
	{
		//Словарь хранилище
		private Dictionary<int, T> places;
		//Макс количество
		private int maxCount;
		//Значение по умолчанию
		private T defaultValue;

		public ClassArray(int size, T defVal)
		{
			defaultValue = defVal;
			places = new Dictionary<int, T>();
			maxCount = size;
		}

		public static int operator +(ClassArray<T> p, T plane)
		{
			if (p.places.Count == p.maxCount)
			{
				return -1;
			}
			for (int i = 0; i < p.places.Count; i++)
			{
				if (p.CheckFreePlace(i))
				{
					p.places.Add(i, plane);
					return i;
				}
			}
			p.places.Add(p.places.Count, plane);
			return p.places.Count - 1;
		}

		public static T operator -(ClassArray<T> p, int index)
		{
			if (p.places.ContainsKey(index))
			{
				T plane = p.places[index];
				p.places.Remove(index);
				return plane;
			}
			return p.defaultValue;
		}

		private bool CheckFreePlace(int index)
		{
			return !places.ContainsKey(index);
		}

		// И самое главное - индексатор:

		public T this[int ind]
		{
			get
			{
				if (places.ContainsKey(ind))
				{
					return places[ind];
				}
				return defaultValue;
			}

		}

	}
}
