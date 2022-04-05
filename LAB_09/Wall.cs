using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace LAB_09
{
    public class Wall : GameItem
    {
        private int displayWidth;
        private int displayHeight;

        public Wall(int displayWidth, int displayHeight)
        {
            this.displayWidth = displayWidth;
            this.displayHeight = displayHeight;
        }

        public override Geometry Area
        {
            get
            {
                GeometryGroup gg = new GeometryGroup();
                gg.Children.Add(new RectangleGeometry(new Rect(0, 0, displayWidth, 5)));//tető
                gg.Children.Add(new RectangleGeometry(new Rect(0, 0, 5, displayHeight)));//balfal
                gg.Children.Add(new RectangleGeometry(new Rect(displayWidth - 5, 0, 5, displayHeight))); //jobbfal
                gg.Children.Add(new RectangleGeometry(new Rect(0, displayHeight - 5, displayWidth, 1))); //padló
                return gg;
            }
        }
    }
}
