using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya1
{
    class W_aterTap
    {
        public bool State { set; get; }

        public W_ater GetWater()
        {
            if (State)
            {
                return new W_ater();

            }
            else
            {
                return null;
            }
        }
    }
}
