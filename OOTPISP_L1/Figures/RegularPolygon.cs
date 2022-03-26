using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace OOTPISP_L1
{
    public class RegularPolygon : Figure
    {
        private readonly int _verticesCount;

        private readonly List<FDot> _vertices = new List<FDot>();

        private readonly FDot _centre;


        public RegularPolygon(Canvas canvas, double radius, double x, double y, int verticesCount, double rotate = -Math.PI / 2)
            : base(canvas)
        {
            _verticesCount = verticesCount;
            _centre = new FDot(x, y);

            double angle = rotate;
            double angleStep = 2 * Math.PI / _verticesCount;

            _vertices.Add(new FDot(radius * Math.Cos(angle) + _centre.XPos, radius * Math.Sin(angle) + _centre.YPos));
            angle += angleStep;

            for (int i = 1; i < _verticesCount; i++)
            {
                _vertices.Add(new FDot(radius * Math.Cos(angle) + _centre.XPos, radius * Math.Sin(angle) + _centre.YPos));
                Lines.Add(new FLine(_vertices[i - 1], _vertices[i]));
                angle += angleStep;
            }

            Lines.Add(new FLine(_vertices[_vertices.Count - 1], _vertices[0]));
        }
    }
}
