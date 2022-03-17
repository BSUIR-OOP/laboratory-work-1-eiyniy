namespace OOTPISP_L1
{
    public class FLine
    {
        public FDot FirstDot { get; set; }

        public FDot SecondDot { get; set; }


        public FLine(FDot dot1, FDot dot2)
        {
            FirstDot = dot1;
            SecondDot = dot2;
        }
    }
}
