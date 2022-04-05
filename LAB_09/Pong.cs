using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace LAB_09
{
    public class Pong : GameItem
    {       
        private int centerX;
        private int centerY;     

        public Pong(int centerX, int centerY)
        {
            this.CenterX = centerX;
            this.centerY = centerY;   
        }

        public override Geometry Area
        {
            get
            {
                Rect r = new Rect(CenterX, centerY, 100, 30);
                return new RectangleGeometry(r);                           
            }
        }

        public int CenterX { get => centerX; set => centerX = value; }

        

    }
}
