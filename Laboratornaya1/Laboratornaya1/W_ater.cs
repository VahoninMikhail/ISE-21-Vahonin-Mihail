using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya1
{
    class W_ater
    {
        private int temp = 0;

        public int Temp { get { return temp; } }

        public void Getheat()
        {
            if (temp < 100)
            {
                temp++;
            }
        }
    }
}
