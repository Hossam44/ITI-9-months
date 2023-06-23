using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool dotIsValid;
        int cnt, cnt_plus_sub;

        public MainWindow()
        {
            InitializeComponent();
            dotIsValid = true;
            cnt = 0;
            cnt_plus_sub = 0;
        }

        private void seven(object sender, RoutedEventArgs e)
        {
            text.Text += "7";
        }

        private void zero(object sender, RoutedEventArgs e)
        {
            text.Text += "0";
        }

        private void one(object sender, RoutedEventArgs e)
        {
            text.Text += "1";
        }

        private void two(object sender, RoutedEventArgs e)
        {
            text.Text += "2";
        }

        private void three(object sender, RoutedEventArgs e)
        {
            text.Text += "3";
        }

        private void four(object sender, RoutedEventArgs e)
        {
            text.Text += "4";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "5";
        }

        private void six(object sender, RoutedEventArgs e)
        {
            text.Text += "6";
        }

        private void eight(object sender, RoutedEventArgs e)
        {
            text.Text += "8";
        }

        private void nine(object sender, RoutedEventArgs e)
        {
            text.Text += "9";
        }

        private void del(object sender, RoutedEventArgs e)
        {
            if (text.Text.Length > 0)
                text.Text = text.Text.Substring(0, text.Text.Length - 1);

        }

        private void div(object sender, RoutedEventArgs e)
        {
            if (check())
            {
                text.Text += "/";
                dotIsValid = true;
                cnt++;
            }

        }

        private void mul(object sender, RoutedEventArgs e)
        {
            if (check())
            {
                text.Text += "*";
                dotIsValid = true;
                cnt++;
            }

        }

        private void sub(object sender, RoutedEventArgs e)
        {
            if (check())
            {
                dotIsValid = true;
                text.Text += "-";
                cnt_plus_sub++;
            }

        }


        private void dot(object sender, RoutedEventArgs e)
        {
            if (check() && dotIsValid)
            {
                text.Text += ".";
                dotIsValid = false;

            }

        }

        private void five(object sender, RoutedEventArgs e)
        {
            text.Text += "5";
        }

        private void plus(object sender, RoutedEventArgs e)
        {
            if (check())
            {
                dotIsValid = true;
                text.Text += "+";
                cnt_plus_sub++;
            }
        }
        private void equal(object sender, RoutedEventArgs e)
        {
            if (check())
            {
                int begin = 0, end = text.Text.Length, mid = 0;
                for (int i = 0; i < cnt; i++)
                {
                    begin = 0; end = text.Text.Length; mid = 0;
                    get_indexes(ref begin, ref mid,ref end,'/','*');

                    if (text.Text[mid] == '/')
                    {
                        text.Text = text.Text[..begin] 
                            + (double.Parse(text.Text[begin..mid]) / double.Parse(text.Text[(mid + 1)..end])) 
                            + text.Text[end..];
                    }
                    else
                    {
                        text.Text = text.Text[..begin] 
                            + (double.Parse(text.Text[begin..mid]) * double.Parse(text.Text[(mid + 1)..end]))
                            + text.Text[end..];
                    }
                }

                    //if (text.Text[0]=='-')
                    //{
                    //    text.Text = '0' + text.Text;
                    //    cnt_plus_sub++;
                    //}
                for (int i = 0; i < cnt_plus_sub; i++)
                {           
                    begin = 0; end = text.Text.Length; mid = 0;
                    get_indexes(ref begin, ref mid, ref end,'+','-');
                    if (text.Text[mid] == '+')
                    {
                        text.Text = text.Text[..begin]
                            + (double.Parse(text.Text[begin..mid]) + double.Parse(text.Text[(mid + 1)..end])).ToString()
                            + text.Text[end..];
                    }
                    else
                    {
                        text.Text = text.Text[..begin]
                            + (double.Parse(text.Text[begin..mid]) - double.Parse(text.Text[(mid + 1)..end])).ToString()
                            + text.Text[end..];
                    }

                }
                cnt = 0;
                cnt_plus_sub = 0;
            }
        }
        private bool check()
        {
            if (text.Text.Length > 0)
                return (text.Text[text.Text.Length - 1] >= '0' && text.Text[text.Text.Length - 1] <= '9');
            return false;
        }
        private void get_indexes(ref int begin,ref int mid,ref int end,char s,char d)
        {
            for (int j = 0; j < text.Text.Length; j++)
            {
                if (text.Text[j] == s || text.Text[j] == d)
                {
                    mid = j;
                    for (int k = j + 1; k < text.Text.Length; k++)
                    {
                        if (!(text.Text[k] >= '0' && text.Text[k] <= '9') && text.Text[k] != '.')
                        {
                            end = k;
                            break;
                        }
                    }

                    for (int k = j - 1; k >= 0; k--)
                    {
                        if (!(text.Text[k] >= '0' && text.Text[k] <= '9') && text.Text[k] != '.')
                        {
                            begin = k + 1;
                            break;
                        }
                    }
                    break;
                }
            }
        }
    }
}
