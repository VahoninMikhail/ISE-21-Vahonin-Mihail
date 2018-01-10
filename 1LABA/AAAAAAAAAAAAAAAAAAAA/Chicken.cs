using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAAAAAAAAAAAAAAAAAAA
{
    class Chicken
    {
        private bool dirty = true;
        private int has_ready = 0;
        public bool Have_scin { set; get; }
        public int Has_ready { get { return has_ready; } }
        public bool Dirty { set { dirty = value; } get { return dirty; } }
        public void GetHeat()
        {
            if (has_ready < 10)
            {
                has_ready++;
            }
        }
    }
}
