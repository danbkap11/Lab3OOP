using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Mined_Out
{
     abstract class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public virtual Bitmap Img { get; set; }


        protected Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
