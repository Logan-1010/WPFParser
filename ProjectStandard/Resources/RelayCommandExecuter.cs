using System;
using System.Windows.Input;

namespace ProjectStandard
{

    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        private Action methodToExecute;
        private Action<object> methodToExecuteParam;
        private Func<bool> canExecuteEvaluator;
        private Func<object, bool> canExecuteEvaluatorParam;
        private ICommand useActivVisuCommand;

        public RelayCommand(Action methodToExecute, Func<bool> canExecuteEvaluator)
        {
            this.methodToExecute = methodToExecute;
            this.canExecuteEvaluator = canExecuteEvaluator;
        }

      
        public RelayCommand(Action<object> methodToExecuteParam, Func<object, bool> canExecuteEvaluator)
        {
            this.methodToExecuteParam = methodToExecuteParam;
            canExecuteEvaluatorParam = canExecuteEvaluator;
        }
        public RelayCommand(Action methodToExecute)
            : this(methodToExecute, null)
        {
        }

     
        public bool CanExecute(object parameter)
        {
            if (canExecuteEvaluator == null)
                return true;
            else
            {
                bool result = canExecuteEvaluator.Invoke();
                return result;
            }
        }

        public void Execute(object parameter)
        {

            if (methodToExecute == null)
                methodToExecuteParam(parameter);
            else
                methodToExecute.Invoke();
        }

  
    }
}
