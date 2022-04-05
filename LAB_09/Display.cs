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
        IAnimationLogic logic;

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
                drawingContext.DrawGeometry(Brushes.DarkGreen, null, logic.PongBoard.Area);
                drawingContext.DrawGeometry(Brushes.Red, null, logic.Ball.Area);
                
            }
        }
    }
}
