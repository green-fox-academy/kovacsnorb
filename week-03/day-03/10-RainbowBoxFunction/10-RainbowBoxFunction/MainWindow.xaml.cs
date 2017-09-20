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

namespace _10_RainbowBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            // create a square drawing function that takes 2 parameters:
            // the square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // create a loop that fills the canvas with rainbow colored squares.

            Random rand = new Random();
            Color color = new Color();

            for (int i = 500; i > 0;)
            {
                color = Color.FromRgb((byte)rand.Next(0, 256), (byte)rand.Next(0, 256), (byte)rand.Next(0, 256));
                SquareDrawing(foxDraw, i, color);
                i -= (byte)rand.Next(0, 30);
            }
        }

        public void SquareDrawing(FoxDraw foxDraw, double squareSize, Color color)
        {
            foxDraw.FillColor(color);
            foxDraw.DrawRectangle(canvas.Width / 2 - squareSize / 2, canvas.Height / 2 - squareSize / 2, squareSize, squareSize);
        }
    }
}
