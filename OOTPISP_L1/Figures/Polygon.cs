using System.Collections.Generic;
using System.Windows.Controls;

namespace OOTPISP_L1
{
    public class Polygon : Figure
    {
        public Polygon(Canvas canvas, List<FDot> vertices) : base(canvas)
        {
            for (int i = 0; i < vertices.Count - 1; i++)
                Lines.Add(new FLine(vertices[i], vertices[i + 1]));

            Lines.Add(new FLine(vertices[vertices.Count - 1], vertices[0]));
        }
    }
}
