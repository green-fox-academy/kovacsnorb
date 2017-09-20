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

namespace _14_FunctionToCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // fill the canvas with lines from the edges, every 20 px, to the center.

            for (int i = 0; i < canvas.Width;)
            {
                LineDrawerToCenter(foxDraw, i, 0);
                i += 20;
            }

            for (int i = 0; i < canvas.Height;)
            {
                LineDrawerToCenter(foxDraw, canvas.Width, i);
                i += 20;
            }

            for (int i = 0; i < canvas.Height;)
            {
                LineDrawerToCenter(foxDraw, 0, i);
                i += 20;
            }

            for (int i = 0; i < canvas.Width + 1;)
            {
                LineDrawerToCenter(foxDraw, i, canvas.Height);
                i += 20;
            }
        }

        public void LineDrawerToCenter(FoxDraw foxDraw, double xCoordinate, double yCoordinate)
        {
            foxDraw.StrokeColor(Colors.Blue);
            Point startPoint = new Point(xCoordinate, yCoordinate);
            Point endPoint = new Point(canvas.Width / 2, canvas.Height / 2);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}
