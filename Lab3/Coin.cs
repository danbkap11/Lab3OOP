﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mined_Out
{
    class Coin : Cell
    {
        public override Bitmap Img
        {
            get
            {
                return new Bitmap(@"C:\Users\KRPS\source\repos\Lab3\Lab3\Sprites\coin.png");
            }
        }

        public Coin(int x, int y) : base(x, y)
        {

        }

    }
}
