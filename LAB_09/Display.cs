using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace LAB_09
{
    internal class Display : FrameworkElement
    {
        public IAnimationLogic logic;

        public void SetupLogic(IAnimationLogic logic)
        {
            this.logic = logic;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            if (logic != null)
            {
                drawingContext.DrawGeometry(Brushes.Black, null, logic.Wall.Area);
                drawingContext.DrawGeometry(Brushes.Blue, new Pen(Brushes.Red, 2), logic.PongBoard.Area);
                drawingContext.DrawGeometry(Brushes.Green, null, logic.Ball.Area);             
            }
        }
    }
}
