using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace INK_Convas
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
        private void Color_Checked(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString())
            {
                case "Red":

                    InkCan.DefaultDrawingAttributes.Color = Colors.Red;
                    break;

                case "Green":

                    InkCan.DefaultDrawingAttributes.Color = Colors.Green;
                    break;

                case "Blue":

                    InkCan.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
            }
        }

        private void Modes_Checked(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString())
            {
                case "Ink":

                    InkCan.EditingMode = InkCanvasEditingMode.Ink;
                    break;

                case "Select":

                    InkCan.EditingMode = InkCanvasEditingMode.Select;
                    break;

                case "EraseByPoint":

                    InkCan.EditingMode = InkCanvasEditingMode.EraseByPoint;
                    break;

                case "EraseByStroke":

                    InkCan.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;
            }

        }
        private void draw_Checked(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString())
            {
                case "rectangle":
                    InkCan.DefaultDrawingAttributes.StylusTip = StylusTip.Rectangle;
                    break;

                case "ellipse":
                    InkCan.DefaultDrawingAttributes.StylusTip = StylusTip.Ellipse;
                    break;
            }

        }
        private void brush_Checked(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString())
            {
                case "small":

                    InkCan.DefaultDrawingAttributes.Width = 5;
                    InkCan.DefaultDrawingAttributes.Height = 5;
                    break;

                case "normal":

                    InkCan.DefaultDrawingAttributes.Width = 10;
                    InkCan.DefaultDrawingAttributes.Height = 10;
                    break;

                case "Erase":

                    InkCan.EditingMode = InkCanvasEditingMode.EraseByPoint;
                    break;

                case "large":

                    InkCan.DefaultDrawingAttributes.Width = 20;
                    InkCan.DefaultDrawingAttributes.Height = 20;
                    break;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InkCan.Strokes.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InkCan.CopySelection();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InkCan.CutSelection();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            InkCan.Paste();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            try
            {
                FileStream file = new FileStream(@"G:\fileName.xaml", FileMode.Create, FileAccess.Write);
                InkCan.Strokes.Save(file);
                file.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, Title);
            }

            //FileStream fs = File.Open(@"G:\fileName.xaml", FileMode.Create);
            //XamlWriter.Save(InkCan, fs);
            //fs.Close();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            try
            {
                FileStream file = new FileStream(@"G:\fileName.xaml", FileMode.Open, FileAccess.Read);
                InkCan.Strokes = new StrokeCollection(file);
                file.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, Title);
            }

            //FileStream fs = File.Open(@"G:\fileName.xaml", FileMode.Open, FileAccess.Read);
            //InkCanvas savedCanvas = XamlReader.Load(fs) as InkCanvas;
            //fs.Close();

            //sp.Children.Add(savedCanvas);
        }
    }
}
