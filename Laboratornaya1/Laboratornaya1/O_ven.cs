﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya1
{
    class O_ven
    {
        private P_an pan;
        public bool State { set; get; }
        public P_an Pan { set { pan = value; } get { return pan; } }

        public bool pan1()
        {
            if (!pan.ReadyToGo)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Cook()
        {

            if (State)
            {
                while (pan.Isready())
                {
                    pan.Getheat();
                }
            }

        }
    }
}