using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_09
{
    public class AnimationLogic : IAnimationLogic
    {
        public Ball Ball { get; set; }
        public Pong PongBoard { get; set; }
        public Wall Wall { get; set; }
     
        public AnimationLogic(int areaWidth, int areaHeight)
        {
            PongBoard = new Pong(200, 200, 40, 10);         
            Wall = new Wall(areaWidth, areaHeight);
            Ball = new Ball(100, 100, 5, 1, 1);
        }

        public void TimeStep()
        {
            if (Ball.IsCollision(Wall) || Ball.IsCollision(PongBoard))
            {
                Ball.Collision();
               
            }
            Ball.Move();          
        }

    }
}
