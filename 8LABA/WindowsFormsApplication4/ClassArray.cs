using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class ClassArray<T> : IEnumerator<T>, IEnumerable<T>, IComparable<ClassArray<T>>
    {
        private int currentIndex;
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];

            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public void Dispose()
        {

        }
        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public int CompareTo(ClassArray<T> other)
        {
            if (this.Count() > other.Count())
            {
                return -1;
            }
            else if (this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i = 0; i < this.places.Count; ++i)
                {
                    if (this.places[thisKeys[i]] is Plane && other.places[thisKeys[i]] is Bombardir)
                    {
                        return 1;
                    }
                    if (this.places[thisKeys[i]] is Bombardir && other.places[thisKeys[i]] is Plane)
                    {
                        return -1;
                    }
                    if (this.places[thisKeys[i]] is Plane && other.places[thisKeys[i]] is Plane)
                    {
                        return (this.places[thisKeys[i]] is Plane).CompareTo(other.places[thisKeys[i]] is Plane);
                    }
                    if (this.places[thisKeys[i]] is Bombardir && other.places[thisKeys[i]] is Bombardir)
                    {
                        return (this.places[thisKeys[i]] is Bombardir).CompareTo(other.places[thisKeys[i]] is Bombardir);
                    }
                }
            }
            return 0;
        }


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
            var isTigherShark = plane is Bombardir;
            if (p.places.Count == p.maxCount)
            {
                throw new ParkingOverflowException();
            }
            int index = p.places.Count;
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = i;
                }
                if (plane.GetType() == p.places[i].GetType())
                {
                    if (isTigherShark)
                    {
                        if ((plane as Bombardir).Equals(p.places[i]))
                        {
                            throw new ParkingAlreadyHaveException();
                        }
                    }
                    else if ((plane as Plane).Equals(p.places[i]))
                    {
                        throw new ParkingAlreadyHaveException();
                    }
                }
            }
            if (index != p.places.Count)
            {
                p.places.Add(index, plane);
                return index;
            }
            p.places.Add(p.places.Count, plane);
            return p.places.Count - 1;
        }

        public static T operator -(ClassArray<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T shark = p.places[index];
                p.places.Remove(index);
                return shark;
            }
            throw new ParkingIndexOutOfRangeException();
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
        public T getObject(int ind)
        {
            if (ind > -1 && ind < places.Count)
            {
                return places[ind];
            }
            return defaultValue;
        }

    }
}
