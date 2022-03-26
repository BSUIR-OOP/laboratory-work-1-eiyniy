using System;

namespace OOTPISP_L1
{
    public class DelegateCommand : IDelegateCommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;


        public event EventHandler CanExecuteChanged;


        public DelegateCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public DelegateCommand(Action<object> execute)
        {
            _execute = execute;
            _canExecute = AlwaysCanExecute;
        }


        public void Execute(object param) => _execute(param);

        public bool CanExecute(object param) => _canExecute(param);

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        private bool AlwaysCanExecute(object param) => true;
    }
}
