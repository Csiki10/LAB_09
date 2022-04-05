using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LAB_09
{
    public class AnimationLogic : IAnimationLogic
    {
        public Ball Ball { get; set; }
        public Pong PongBoard { get; set; }
        public Wall Wall { get; set; }

        public int AreaHeight { get; set; }

        public int AreaWidth{ get; set; }

        public AnimationLogic(int areaWidth, int areaHeight)
        {

            AreaHeight = areaHeight;
            AreaWidth = areaWidth;
            PongBoard = new Pong(areaWidth/2, areaHeight - 40);         
            Wall = new Wall(areaWidth, areaHeight);
            Ball = new Ball(300, 400, 10, 2, 2);
        }

        public void TimeStep()
        {
            if (Ball.CenterY > AreaHeight)
            {
                Ball.CenterX = AreaWidth / 2;
                Ball.CenterY = AreaHeight / 2;
                Ball.SpeedX = 1.2;
                Ball.SpeedY = 1.2;
            }

            if (Ball.IsCollision(Wall))
            {
                Ball.Collision();
               
            }
            else if (Ball.IsCollision(PongBoard))
            {
                Ball.CollisionBoard();

            }
            Ball.Move();          
        }

        public void BoardMoveLeft()
        {
            if (PongBoard.CenterX >= 40)
            {
                PongBoard.CenterX -= 20;
            }
            else
            {

            }
                
        }
        public void BoardMoveRight()
        {
            if (PongBoard.CenterX <= AreaWidth-70)
            {
                PongBoard.CenterX += 20;
            }
            else
            {

            }
           
        }

    }
}
