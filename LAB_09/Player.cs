using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_09
{
    internal class Player
    {
        private int centerX;
        private int centerY;
        private int radius;

        private int speedX;

        public void Move()
        {
            centerX += speedX;
        }

        public void Collision()
        {
            speedX *= -1;
        }
    }
}
