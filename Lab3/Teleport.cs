using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mined_Out
{
    class Teleport : Cell
    {
        public override Bitmap Img
        {
            get
            {
                return new Bitmap(@"C:\Users\KRPS\source\repos\Lab3\Lab3\Sprites\teleport.png");
            }
        }

        public Teleport(int x, int y) : base(x, y)
        {

        }
    }
}
