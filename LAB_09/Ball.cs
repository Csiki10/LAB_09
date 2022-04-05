using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace LAB_09
{
    public class Ball : GameItem
    {
        private double centerX;
        private double centerY;
        private double radius;

        private double speedX;
        private double speedY;



        public Ball(double centerX, double centerY, double radius, double speedX, double speedY)
        {
            this.CenterX = centerX;
            this.CenterY = centerY;
            this.radius = radius;
            this.SpeedX = speedX;
            this.SpeedY = speedY;
        }

        public void Move()
        {
            CenterX += SpeedX;
            CenterY += SpeedY;
        }

        public void Collision()
        {
            if (CenterY <= 30)
            {
                SpeedX *= 1;
                SpeedY *= -1;
            }
            else if ((SpeedX > 0 && SpeedY > 0) || (SpeedX > 0 && SpeedY < 0))
            {
                SpeedX *= -1;
                SpeedY *= 1;
            }
            else if (SpeedX < 0 && SpeedY < 0 || (SpeedX < 0 && SpeedY > 0))
            {
                SpeedX *= -1;
                SpeedY *= 1;
            }


        }

        public void CollisionBoard()
        {
            SpeedX *= 1.4;
            SpeedY *= -1.4;
        }      

        public override Geometry Area
        {
            get
            {
                return new EllipseGeometry(new Point(CenterX, CenterY), radius, radius);
            }
        }

        public double CenterX { get => centerX; set => centerX = value; }
        public double CenterY { get => centerY; set => centerY = value; }
        public double SpeedX { get => speedX; set => speedX = value; }
        public double SpeedY { get => speedY; set => speedY = value; }
    }
}
