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

namespace Text_Editor
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

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            text.Text = "Hello";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            text.Text = "";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            text.SelectAll();
            text.Focus();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            text.Text = "*preAppend*" + text.Text;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            text.Text = text.Text + "*Append*";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            text.Text = text.Text.Insert(text.CaretIndex, "*insert*");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            text.Undo();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            text.Cut();
        }
        private void edit_checked(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString())
            {
                case "Editable":

                    text.IsReadOnly = false;
                    break;

                case "Read Only":

                    text.IsReadOnly = true;
                    break;
            }

        }
        private void Align_checked(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString())
            {
                case "Left":

                    text.TextAlignment = TextAlignment.Left;
                    break;

                case "Center":

                    text.TextAlignment = TextAlignment.Center;
                    break;
                case "Right":

                    text.TextAlignment = TextAlignment.Right;
                    break;
            }

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            text.Paste();
        }
    }
}
