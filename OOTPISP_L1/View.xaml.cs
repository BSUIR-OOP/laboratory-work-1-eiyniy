using System.Windows;

namespace OOTPISP_L1
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class View : Window
    {
        public View()
        {
            InitializeComponent();

            DataContext = new ViewModel();
        }
    }
}
