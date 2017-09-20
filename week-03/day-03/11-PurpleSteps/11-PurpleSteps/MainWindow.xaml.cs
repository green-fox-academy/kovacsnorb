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

namespace _11_PurpleSteps
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.Yellow);
            // reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps/r3.png]

            int numberOfLoops = 20;
            double sizeOfSquares = 10;

            for (int i = 1; i < numberOfLoops; i++)
            {
                DrawSquares(foxDraw, sizeOfSquares, i);
            }
        }

        public void DrawSquares(FoxDraw foxDraw, double size, int startMultiplier)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.MediumPurple);
            foxDraw.DrawRectangle(startMultiplier * size, startMultiplier * size, size, size);
        }
    }
}
