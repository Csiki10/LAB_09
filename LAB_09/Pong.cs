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
        private int size;
        private int radiusX;
        private int radiusY;

        public Pong(int centerX, int centerY, int size, int radiusX, int radiusY)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.size = size;
            this.radiusX = radiusX;
            this.radiusY = radiusY;
        }

        public override Geometry Area
        {
            get
            {
                Rect r = new Rect(30, 40, 100, 20);
                return new RectangleGeometry(r, radiusX, radiusY);                           
            }
        }


    }
}
