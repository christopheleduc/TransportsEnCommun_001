using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfFindYourWay
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private readonly Action _methodToExecute;

        public RelayCommand(Action methodToExecute) => _methodToExecute = methodToExecute;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => _methodToExecute?.Invoke();
    }
}
