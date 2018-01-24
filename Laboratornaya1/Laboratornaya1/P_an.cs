using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya1
{
    class P_an
    {
        private C_hicken[] chicken;
        private S_alt salt;
        private A_pple[] apple;
        private O_il oil;

        public bool ReadyToGo { get { return Check(); } }

        public void AddSalt(S_alt s)
        {
            salt = s;
        }

        public void AddChicken(C_hicken[] p)
        {

            if (chicken == null)
            {
                chicken = p;
                return;
            }

        }
        public void AddOil(O_il ol)
        {
            oil = ol;
        }
        public void AddApple(A_pple[] o)
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
