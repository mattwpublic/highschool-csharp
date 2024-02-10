using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidemanBrickOutV2
{
    class Paddle
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public int xSpeed;
        public Paddle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            xSpeed = 60;
        }
    }
}
