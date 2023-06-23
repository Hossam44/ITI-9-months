using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDay1Task.WPFApp.Commands;

public class AddCarCommand : ICommand
{
    private readonly Action<object> _excute;
    private readonly Predicate<object> _canExcute;

    public AddCarCommand(Action<object> excute, Predicate<object> canExcute)
    {
        _excute = excute;
        _canExcute = canExcute;
    }

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter)
    {
        return parameter is null ? false : _canExcute?.Invoke(parameter) == true;
    }

    public void Execute(object? parameter)
    {
        if (parameter is not null)
            _excute?.Invoke(parameter);
    }
}
