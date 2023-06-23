using MVVMDay1Task.WPFApp.Commands;
using MVVMDay1Task.WPFApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVMDay1Task.WPFApp.ViewModel;

public class CarViewModel : INotifyPropertyChanged
{
    private Car? _newCar;

    public Car? NewCar { 
        get => _newCar; 
        set 
        {
            if (_newCar != value)
            {
                _newCar = value;
                OnPropertChanged(nameof(NewCar));
            }
        }
    }
    public ICommand AddCarCommand { get; set; }
    public ObservableCollection<Car> CarsList { get; set; } = new ObservableCollection<Car>()
    {
        new Car () { Id = 1, Brand = "B01", Model="M01"},
        new Car () { Id = 2, Brand = "B02", Model="M02"},
        new Car () { Id = 3, Brand = "B03", Model="M03"},
        new Car () { Id = 4, Brand = "B04", Model="M04"},
    };

    public CarViewModel()
    {
        NewCar = new Car();
        AddCarCommand = new AddCarCommand(Add, CanAdd);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private bool CanAdd(object obj)
    {
        return true;
    }

    private void Add(object obj)
    {
        var car = obj as Car;
        if (car is null) return;

        CarsList.Add(car);
        NewCar = new Car();
        MessageBox.Show("Success");
    }
}
