using System;
using System.Windows.Input;

namespace MVVM2.Model
{
    public class RelayCommand : ICommand
    {
        private Action<object> clickExecute;
        private Func<object, bool> canClickExecute;

        public RelayCommand(Action<object> clickExecute, Func<object, bool> canClickExecute)
        {
            this.clickExecute = clickExecute;
            this.canClickExecute = canClickExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}