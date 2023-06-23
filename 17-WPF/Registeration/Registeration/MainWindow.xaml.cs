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

namespace Registeration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"You Have Entered\nFull Name:{Fname.Text+Lname.Text}\nGender:{Gender.Text}\nAddress:{Adress.Text}\n" +
                $"Jop Title: {Jop.Text}\nPhone:{Phone.Text}\nMobile:{Mobile.Text}\nEmail:{Email.Text}",
                    "Save file",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Data Saved Succsesfully");
            }
            else
            {
                Button_Click_1(sender,e);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Fname.Text = Lname.Text = Gender.Text = Adress.Text = Jop.Text = Phone.Text = Mobile.Text = Email.Text = "";
        }
    }
}
