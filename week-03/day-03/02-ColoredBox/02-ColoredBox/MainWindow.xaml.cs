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

namespace _02_ColoredBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a box that has different colored lines on each edge.

            Point upperLeft = new Point(5, 5);
            Point downLeft = new Point(5, canvas.Height - 5);
            Point upperRight = new Point(canvas.Width - 10, 5);
            Point downRight = new Point(canvas.Width - 10, canvas.Height - 5);

            drawLine(foxDraw, Colors.Aqua, upperLeft, upperRight);
            drawLine(foxDraw, Colors.DarkOrchid, downLeft, downRight);
            drawLine(foxDraw, Colors.CadetBlue, upperLeft, downLeft);
            drawLine(foxDraw, Colors.Coral, upperRight, downRight);
        }

        public static void drawLine(FoxDraw foxDraw, Color color, Point startPoint, Point endPoint)
        {
            foxDraw.StrokeColor(color);
            foxDraw.DrawLine(startPoint, endPoint);
        }
    }
}

