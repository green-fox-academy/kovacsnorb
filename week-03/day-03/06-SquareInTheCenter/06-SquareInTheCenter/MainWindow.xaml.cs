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

namespace _06_SquareInTheCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.Beige);
            // draw a green 10x10 square to the canvas' center.
            Point upperLeft = new Point(canvas.Width / 2 - 25, canvas.Height / 2 - 25);
            Point upperRight = new Point(canvas.Width / 2 + 25, canvas.Height / 2 - 25);
            Point bottomLeft = new Point(canvas.Width / 2 - 25, canvas.Height / 2 + 25);
            Point bottomRight = new Point(canvas.Width / 2 + 25, canvas.Height / 2 + 25);

            DrawLine(foxDraw, upperLeft, upperRight);
            DrawLine(foxDraw, bottomLeft, bottomRight);
            DrawLine(foxDraw, upperLeft, bottomLeft);
            DrawLine(foxDraw, upperRight, bottomRight);
        }

        public void DrawLine(FoxDraw foxDraw, Point startPoint, Point endPoint)
        {
            foxDraw.StrokeColor(Colors.LightSeaGreen);
            foxDraw.DrawLine(startPoint, endPoint);
        }

    }
}
