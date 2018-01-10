using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAAAAAAAAAAAAAAAAAAA
{
    class Pan
    {
        private Chicken[] chicken;
        private Salt salt;
        private Apple[] apple;
        private Oil oil;

        public bool ReadyToGo { get { return Check(); } }

        public void AddSalt(Salt s)
        {
            salt = s;
        }

        public void AddChicken(Chicken[] p)
        {

            if (chicken == null)
            {
                chicken = p;
                return;
            }

        }
        public void AddOil(Oil ol)
        {
            oil = ol;
        }
        public void AddApple(Apple[] o)
        {

            if (apple == null)
            {
                apple = o;
                return;
            }
        }
        private bool Check()
        {
            if (chicken.Length == 0)
            {
                return false;
            }
            if (oil == null)
            {
                return false;
            }
            if (apple.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < chicken.Length; ++i)
            {
                if (chicken[i] == null)
                {
                    return false;
                }
            }
            for (int i = 0; i < apple.Length; ++i)
            {
                if (apple[i] == null)
                {
                    return false;
                }
            }
            return true;
        }

        public void Getheat()
        {
            if (!Check())
            {
                return;
            }

            bool flag = false;
            if (flag)
            {
                for (int i = 0; i < chicken.Length; ++i)
                {
                    chicken[i].GetHeat();
                }
                for (int i = 0; i < apple.Length; ++i)
                {
                    apple[i].GetHeat();
                }

                oil.GetHeat();
            }

            else
            {
                for (int i = 0; i < chicken.Length; ++i)
                {
                    chicken[i].GetHeat();
                }
                for (int i = 0; i < apple.Length; ++i)
                {
                    apple[i].GetHeat();
                }
                oil.GetHeat();
            }
        }
        public bool Isready()
        {
            for (int i = 0; i < chicken.Length; ++i)
            {
                if (chicken[i].Has_ready < 10)
                {
                    return false;
                }
            }
            for (int i = 0; i < apple.Length; ++i)
            {
                if (apple[i].Has_ready < 10)
                {
                    return false;
                }
            }

            if (oil.Has_ready < 10)
            {
                return false;
            }
            return true;
        }
    }
}
