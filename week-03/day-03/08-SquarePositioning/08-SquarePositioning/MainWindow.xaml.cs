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

namespace _08_SquarePositioning
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.  

            SquareDrawing(foxDraw, 0, 0);
            SquareDrawing(foxDraw, 50, 50);
            SquareDrawing(foxDraw, 100, 100);
        }

        public void SquareDrawing(FoxDraw foxDraw, double xCoordinate, double yCoordinate)
        {
            foxDraw.StrokeColor(Colors.SeaGreen);
            foxDraw.DrawRectangle(xCoordinate, yCoordinate, 50, 50);
        }
    }
}
