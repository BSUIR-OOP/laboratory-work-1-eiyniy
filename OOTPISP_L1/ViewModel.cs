using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace OOTPISP_L1
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Canvas _canvas;


        public DelegateCommand DrawCommand { get; }

        public Canvas Canvas
        {
            get => _canvas;
            set
            {
                _canvas = value;
                NotifyPropertyChanged(nameof(Canvas));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;


        public ViewModel()
        {
            Canvas = new Canvas();
            DrawCommand = new DelegateCommand(DrawCommandDelegate);
        }


        private void DrawCommandDelegate(object param)
        {
            Figures figures = new Figures();

            figures.AllFigures.Add(new Rectangle(_canvas, 10, 20, 60, 90));
            figures.AllFigures.Add(new Polygon(_canvas, new List<FDot>{
                new FDot(10, 200), new FDot(55, 250), new FDot(100, 350), new FDot(50, 400)
            }));
            figures.AllFigures.Add(new MultyLine(_canvas, new List<FDot>{
                new FDot(10, 100), new FDot(85, 150), new FDot(100, 250), new FDot(150, 100)
            }));
            figures.AllFigures.Add(new MultyLine(_canvas, new List<FDot>{
                new FDot(200, 50), new FDot(250, 350)
            }));
            figures.AllFigures.Add(new RegularPolygon(_canvas, 40, 400, 50, 3));
            figures.AllFigures.Add(new RegularPolygon(_canvas, 40, 400, 150, 4, Math.PI / 4));
            figures.AllFigures.Add(new RegularPolygon(_canvas, 40, 400, 250, 5));
            figures.AllFigures.Add(new RegularPolygon(_canvas, 40, 500, 50, 6));
            figures.AllFigures.Add(new RegularPolygon(_canvas, 40, 500, 150, 7));
            figures.AllFigures.Add(new Circle(_canvas, 40, 500, 250));

            figures.Draw();
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
