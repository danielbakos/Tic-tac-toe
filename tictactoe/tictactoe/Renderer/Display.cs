using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace tictactoe.Renderer
{
    public class Display : FrameworkElement
    {
        Size size;
        public void Resize(Size size)
        {
            this.size = size;
            this.InvalidateVisual();
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            int x = 1;
            int y = 1;

            double width = size.Width/3;
            double height = size.Height/3;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    drawingContext.DrawRectangle(Brushes.White, new Pen(Brushes.Black, 1), new Rect(1 + j * width, 1 + i*height, width, height));
                }
            }
        }
    }
}
