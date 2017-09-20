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

namespace _03_Diagonals
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            // draw the canvas' diagonals in green.

            Point upperLeft = new Point(0, 0);
            Point upperRight = new Point(0, canvas.Width);
            Point downLeft = new Point(canvas.Height, 0);
            Point downRight = new Point(canvas.Height, canvas.Width);

            DiagonalsInGreen(foxDraw, upperLeft, downRight);
            DiagonalsInGreen(foxDraw, downLeft, upperRight);

            foxDraw.BackgroundColor(Colors.LightCoral);
        }

        public static void DiagonalsInGreen(FoxDraw foxDraw, Point startPoint, Point endPoint)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}
