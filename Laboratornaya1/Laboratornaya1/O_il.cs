using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya1
{
    class O_il
    {
        private int has_ready = 0;
        public int Has_ready { get { return has_ready; } }
        public bool cutting { set; get; }
        public void GetHeat()
        {
            if (has_ready < 10)
            {
                has_ready++;
            }
        }
    }
}
