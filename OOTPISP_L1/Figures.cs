using System.Collections.Generic;

namespace OOTPISP_L1
{
    public class Figures
    {
        public List<Figure> AllFigures { get; set; }


        public Figures()
        {
            AllFigures = new List<Figure>();
        }


        public void Draw()
        {
            foreach (var figure in AllFigures)
                figure.Draw();
        }
    }
}
