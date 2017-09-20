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

namespace _09_CenterBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            int[] squareSize = new int[12] { 120, 110, 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };

            for (int i = 0; i < squareSize.Length; i++)
            {
                SquareDrawing(foxDraw, squareSize[i]);
            }
        }

        public void SquareDrawing(FoxDraw foxDraw, double squareSize)
        {
            foxDraw.StrokeColor(Colors.DarkSlateGray);
            foxDraw.FillColor(Colors.White);
            foxDraw.DrawRectangle(canvas.Width / 2 - squareSize / 2, canvas.Height / 2 - squareSize / 2, squareSize, squareSize);
        }
    }
}
