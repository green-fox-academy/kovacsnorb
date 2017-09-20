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
using GreenFox;

namespace _04_GoToCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.PeachPuff);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // draw 3 lines with that function.
            LineToCenter(foxDraw, 10, 20);
            LineToCenter(foxDraw, 40, 125);
            LineToCenter(foxDraw, 205, 8);
        }

        public void LineToCenter(FoxDraw foxDraw, double xCoordinate, double yCoordinate)
        {
            foxDraw.StrokeColor(Colors.Blue);
            Point endPoint = new Point(canvas.Width / 2, canvas.Height / 2);
            Point startPoint = new Point(xCoordinate, yCoordinate);
            foxDraw.DrawLine(startPoint, endPoint);
        }

    }
}
