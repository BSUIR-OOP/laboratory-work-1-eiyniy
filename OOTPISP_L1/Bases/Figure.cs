using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace OOTPISP_L1
{
    public abstract class Figure
    {
        protected readonly Canvas _canvas;


        public List<FLine> Lines { get; }


        public Figure(Canvas canvas)
        {
            _canvas = canvas;
            Lines = new List<FLine>();
        }


        public void Draw()
        {
            foreach (var fLine in Lines)
                _canvas.Children.Add(new Line
                {
                    X1 = fLine.FirstDot.XPos,
                    X2 = fLine.SecondDot.XPos,
                    Y1 = fLine.FirstDot.YPos,
                    Y2 = fLine.SecondDot.YPos,
                });
        }
    }
}
