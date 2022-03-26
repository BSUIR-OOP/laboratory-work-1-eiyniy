using System.Windows.Controls;

namespace OOTPISP_L1
{
    public class Circle : RegularPolygon
    {
        private const int _circleVerticesCount = 100;


        public Circle(Canvas canvas, double radius, double x, double y) 
            : base(canvas, radius, x, y, _circleVerticesCount)
        { }
    }
}
