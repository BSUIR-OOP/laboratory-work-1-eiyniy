using System.Windows.Input;

namespace OOTPISP_L1
{
    public interface IDelegateCommand : ICommand
    {
        void RaiseCanExecuteChanged();
    }
}
