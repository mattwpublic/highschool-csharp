using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidemanBrickOutV2
{
    class Ball
    {
        public double x;
        public double y;
        public double size;
        public double speedX;
        public double speedY;
        public double widthofball;

        public Ball(double x, double y, double size, double speedX, double speedY)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            this.speedX = speedX;
            this.speedY = speedY;
            widthofball = x + size;
        }
    }
}