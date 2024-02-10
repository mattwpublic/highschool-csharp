using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidemanBrickOutV2
{
    class Brick
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public int brickhp;
        public int bottom;
        public int right;

        public Brick(int x, int y, int width, int height, int brickhp)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.brickhp = brickhp;
            bottom = y + height;
            right = x + width;
        }
    }
}
