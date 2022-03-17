using System.Windows.Controls;

namespace OOTPISP_L1
{
    public class Rectangle : Figure
    {
        private readonly FDot _TLDot;
        private readonly FDot _TRDot;
        private readonly FDot _BLDot;
        private readonly FDot _BRDot;


        public Rectangle(Canvas canvas, double x, double y, double width, double height) : base(canvas)
        {
            _TLDot = new FDot(x, y);
            _TRDot = new FDot(x, y + width);
            _BLDot = new FDot(x + height, y);
            _BRDot = new FDot(x + height, y + width);

            Lines.Add(new FLine(_TLDot, _TRDot));
            Lines.Add(new FLine(_TRDot, _BRDot));
            Lines.Add(new FLine(_BRDot, _BLDot));
            Lines.Add(new FLine(_BLDot, _TLDot));
        }
    }
}
