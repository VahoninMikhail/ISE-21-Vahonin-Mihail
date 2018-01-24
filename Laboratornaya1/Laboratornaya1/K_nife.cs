using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya1
{
    class K_nife
    {
        public void Clean_chicken(C_hicken p)
        {
            if (p.Have_scin)
            {
                p.Have_scin = false;
            }
        }

        public void Clean_apple(A_pple p)
        {
            if (p.Have_scin)
            {
                p.Have_scin = false;
            }
        }
    }
}
