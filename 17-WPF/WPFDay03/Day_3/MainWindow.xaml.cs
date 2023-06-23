using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Day_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Employee> Employees { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Employees = new List<Employee>()
            {
                new Employee(){Name="Luffy",Id=10,Salary=2000,Image="1.jpg",Date = "4-4-2000"},
                new Employee(){Name="Zoro",Id=20,Salary=3000,Image="2.jpg" ,Date = "6-7-1998"},
                new Employee(){Name="Sangi",Id=30,Salary=4000,Image="/3.jpg",Date = "3-1-1999"},
                new Employee(){Name="shanks",Id=40,Salary=5000,Image="4.jpg"  ,Date = "2-3-1990"},
                new Employee(){Name="Law",Id=50,Salary=6000,Image="5.jpg", Date = "5-2-2000"},



            };
            lst.ItemsSource = Employees;
        }
    }
}
