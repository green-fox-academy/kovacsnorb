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

namespace _01_LineInTheMiddle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            //  draw a red horizontal line to the canvas' middle.
            DrawRedHorizontal(foxDraw, canvas);
            //  draw a green vertical line to the canvas' middle.
            DrawGreenVertical(foxDraw, canvas);
        }

        public static void DrawRedHorizontal(FoxDraw foxDraw, Canvas canvas)
        {
            foxDraw.StrokeColor(Colors.Red);
            var startPoint = new Point(0, canvas.Height / 2);
            var endPoint = new Point(canvas.Width, canvas.Height / 2);
            foxDraw.DrawLine(startPoint, endPoint);
        }

        public static void DrawGreenVertical(FoxDraw foxDraw, Canvas canvas)
        {
            foxDraw.StrokeColor(Colors.Green);
            var startPoint = new Point(canvas.Width / 2, canvas.Height);
            var endPoint = new Point(canvas.Width / 2, 0);
            foxDraw.DrawLine(startPoint, endPoint);
        }

    }
}
