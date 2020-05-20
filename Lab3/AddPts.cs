using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mined_Out;

namespace Lab3
{
    class AddPts : Cell
    {
        public override Bitmap Img
        {
            get
            {
                return new Bitmap(@"C:\Users\KRPS\source\repos\Lab3\Lab3\Sprites\addpts.png");
            }
        }

        public AddPts(int x, int y) : base(x, y)
        {

        }
    }
}
