using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RadioButtonCheckBox_Example
{
    public class RelayCommand : ICommand
    {
        private Func<object, bool> canExecute; private Action<object> execute;
        public event EventHandler CanExecuteChanged;
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute) { this.canExecute = canExecute; this.execute = execute; }
        public bool CanExecute(object parameter) => canExecute(parameter);
        public void Execute(object parameter) => execute(parameter);
    }
}
