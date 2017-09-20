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

namespace _05_HorizontalLines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.Aqua);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a 50 long horizontal line from that point.
            // draw 3 lines with that function.

            DrawHorizontal(foxDraw, 43, 78);
            DrawHorizontal(foxDraw, 100, 23);
            DrawHorizontal(foxDraw, 91, 129);
        }

        public void DrawHorizontal(FoxDraw foxDraw, double xCoordinate, double yCoordinate)
        {
            foxDraw.StrokeColor(Colors.Yellow);
            Point startPoint = new Point(xCoordinate, yCoordinate);
            Point endPoint = new Point(xCoordinate + 50, yCoordinate);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}
